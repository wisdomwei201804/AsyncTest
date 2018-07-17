using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    public partial class Form_asyncTest : Form
    {
        public Form_asyncTest()
        {
            InitializeComponent();
        }
        private void ThreadTest()
        {
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "ThreadTest main thread start ..." + "\r\n");
            System.Console.WriteLine("ThreadTest main thread start ...");

            //thread with no parameter.
            //不带参数子线程
            //var thread = new Thread(new ThreadStart(AsyncThread)); 
            //thread.Start();

            //thread with parameter.
            //带参数子线程
            var thread = new Thread(new ParameterizedThreadStart(AsyncThread));  
            thread.Start(textBox_param.Text.ToString());

            //wait for sub thread end.
            //等待子线程结束
            //thread.Join(); 

            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "ThreadTest main thread end here." + "\r\n");
            System.Console.WriteLine("ThreadTest main thread end here.");
            System.Console.ReadLine();
        }

        private void AsyncThread(object param)
        {
            //call the mainform TextBox control between different threads.
            //跨线程调用窗体控件。

            //thread with no parameter.
            //不带参数子线程
            //SetText(System.DateTime.Now.ToString() + " " + "AsyncThread running here ..." + "\r\n");
            //System.Console.WriteLine("AsyncThread running here ...");

            //thread with parameter.
            //带参数子线程
            SetText(System.DateTime.Now.ToString() + " " + "AsyncThread running with parameter:" + param + "\r\n");            
            System.Console.WriteLine("AsyncThread running with parameter:{0}", param);

            //delay
            //延迟输出
            Thread.Sleep(100);
        }

        private void ThreadPoolTest()
        {
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "ThreadPoolTest main thread start ..." + "\r\n");
            System.Console.WriteLine("ThreadPoolTest main thread start ...");

            AutoResetEvent mainEvent = new AutoResetEvent(false);
            int workerThreads;
            int portThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "\r\nMaximum worker threads:" + workerThreads.ToString() + "\r\nMaximum completion port threads:" + portThreads.ToString() + "\r\n");
            Console.WriteLine("\nMaximum worker threads: \t{0}" +
            "\nMaximum completion port threads: {1}",
            workerThreads, portThreads);

            var thread = new Thread(new ParameterizedThreadStart(AsyncThread));
            thread.Start(textBox_param.Text.ToString());

            ThreadPool.QueueUserWorkItem(new WaitCallback(AsyncThread), mainEvent);

            ThreadPool.GetAvailableThreads(out workerThreads, out portThreads);
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "\r\nAvailable worker threads:" + workerThreads.ToString() + "\r\nAvailable completion port threads:" + portThreads.ToString() + "\r\n");
            Console.WriteLine("\nAvailable worker threads: \t{0}" +
            "\nAvailable completion port threads: {1}\n",
            workerThreads, portThreads);

            // Since ThreadPool threads are background threads, 
            // wait for the work item to signal before ending Main.
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "Since ThreadPool threads are background threads, count 10 seconds wait for the work item to signal before ending Main." + "\r\n");
            System.Console.WriteLine("Since ThreadPool threads are background threads, count 10 seconds wait for the work item to signal before ending Main.");
            mainEvent.WaitOne(10000, false);

            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "ThreadPoolTest main thread end here." + "\r\n");
            System.Console.WriteLine("ThreadPoolTest main thread end here.");
            System.Console.ReadLine();
        }

        private void TaskTest()
        {
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "TaskTest main thread start ..." + "\r\n");
            System.Console.WriteLine("TaskTest main thread start ...");
            // new Task 创建方式-不带参数
            //Task task = new Task(AsyncThread);
            //task.Start();

            // new Task 创建方式-带参数
            //Task task=new Task(() =>  AsyncThread(10));

            //Task.Factory 创建方式-不带参数
            //Task task = Task.Factory.StartNew(AsyncThread);
            //task.Start();

            //Task.Factory 创建方式-带参数
            //Task task = Task.Factory.StartNew(() => AsyncThread(10));
            //task.Start();

            //Task task = Task.Run(() => AsyncThread());
            Task task = Task.Run(() => AsyncThread(textBox_param.Text.ToString()));
            //task.Wait();

            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "TaskTest main thread end here." + "\r\n");
            System.Console.WriteLine("TaskTest main thread end here.");
            System.Console.ReadLine();
        }

        private void AsyncAwaitTest()
        {
            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "AsyncAwaitTest main thread start ..." + "\r\n");
            System.Console.WriteLine("AsyncAwaitTest main thread start ...");

            AsyncAwaitThread();

            textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "AsyncAwaitTest main thread end here." + "\r\n");
            System.Console.WriteLine("AsyncAwaitTest main thread end here.");
            System.Console.ReadLine();
        }

        private async void AsyncAwaitThread()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(100);
                AsyncThread(textBox_param.Text.ToString());
            });
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if(radioButton_thread.Checked)
            {
                ThreadTest();
            }
            else if(radioButton_threadpool.Checked)
            {
                ThreadPoolTest();
            }
            else if(radioButton_task.Checked)
            {
                TaskTest();
            }
            else if(radioButton_async.Checked)
            {
                AsyncAwaitTest();
            }
            else
            {
                textBox_log.AppendText(System.DateTime.Now.ToString() + " " + "Nothing selected ..." + "\r\n");
            }
        }

        // This method demonstrates a pattern for making thread-safe
        // calls on a Windows Forms control. 
        //
        // If the calling thread is different from the thread that
        // created the TextBox control, this method creates a
        // SetTextCallback and calls itself asynchronously using the
        // Invoke method.
        //
        // If the calling thread is the same as the thread that created
        // the TextBox control, the Text property is set directly. 

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox_log.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox_log.AppendText(text);
            }
        }
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);
    }
}
