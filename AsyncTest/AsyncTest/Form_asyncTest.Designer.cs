namespace AsyncTest
{
    partial class Form_asyncTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.button_run = new System.Windows.Forms.Button();
            this.groupBox_setup = new System.Windows.Forms.GroupBox();
            this.label_param = new System.Windows.Forms.Label();
            this.textBox_param = new System.Windows.Forms.TextBox();
            this.radioButton_async = new System.Windows.Forms.RadioButton();
            this.radioButton_task = new System.Windows.Forms.RadioButton();
            this.radioButton_threadpool = new System.Windows.Forms.RadioButton();
            this.radioButton_thread = new System.Windows.Forms.RadioButton();
            this.groupBox_log.SuspendLayout();
            this.groupBox_setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(6, 20);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(344, 137);
            this.textBox_log.TabIndex = 0;
            // 
            // groupBox_log
            // 
            this.groupBox_log.Controls.Add(this.textBox_log);
            this.groupBox_log.Location = new System.Drawing.Point(12, 92);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(356, 163);
            this.groupBox_log.TabIndex = 1;
            this.groupBox_log.TabStop = false;
            this.groupBox_log.Text = "Log";
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(275, 49);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 21);
            this.button_run.TabIndex = 2;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // groupBox_setup
            // 
            this.groupBox_setup.Controls.Add(this.label_param);
            this.groupBox_setup.Controls.Add(this.textBox_param);
            this.groupBox_setup.Controls.Add(this.radioButton_async);
            this.groupBox_setup.Controls.Add(this.radioButton_task);
            this.groupBox_setup.Controls.Add(this.radioButton_threadpool);
            this.groupBox_setup.Controls.Add(this.radioButton_thread);
            this.groupBox_setup.Controls.Add(this.button_run);
            this.groupBox_setup.Location = new System.Drawing.Point(12, 6);
            this.groupBox_setup.Name = "groupBox_setup";
            this.groupBox_setup.Size = new System.Drawing.Size(356, 80);
            this.groupBox_setup.TabIndex = 3;
            this.groupBox_setup.TabStop = false;
            this.groupBox_setup.Text = "Setup";
            // 
            // label_param
            // 
            this.label_param.AutoSize = true;
            this.label_param.Location = new System.Drawing.Point(10, 53);
            this.label_param.Name = "label_param";
            this.label_param.Size = new System.Drawing.Size(65, 12);
            this.label_param.TabIndex = 8;
            this.label_param.Text = "Parameter:";
            // 
            // textBox_param
            // 
            this.textBox_param.Location = new System.Drawing.Point(81, 50);
            this.textBox_param.Name = "textBox_param";
            this.textBox_param.Size = new System.Drawing.Size(132, 21);
            this.textBox_param.TabIndex = 7;
            this.textBox_param.Text = "Here is a paramter.";
            // 
            // radioButton_async
            // 
            this.radioButton_async.AutoSize = true;
            this.radioButton_async.Location = new System.Drawing.Point(219, 20);
            this.radioButton_async.Name = "radioButton_async";
            this.radioButton_async.Size = new System.Drawing.Size(89, 16);
            this.radioButton_async.TabIndex = 6;
            this.radioButton_async.TabStop = true;
            this.radioButton_async.Text = "async await";
            this.radioButton_async.UseVisualStyleBackColor = true;
            // 
            // radioButton_task
            // 
            this.radioButton_task.AutoSize = true;
            this.radioButton_task.Location = new System.Drawing.Point(166, 20);
            this.radioButton_task.Name = "radioButton_task";
            this.radioButton_task.Size = new System.Drawing.Size(47, 16);
            this.radioButton_task.TabIndex = 5;
            this.radioButton_task.TabStop = true;
            this.radioButton_task.Text = "Task";
            this.radioButton_task.UseVisualStyleBackColor = true;
            // 
            // radioButton_threadpool
            // 
            this.radioButton_threadpool.AutoSize = true;
            this.radioButton_threadpool.Location = new System.Drawing.Point(77, 20);
            this.radioButton_threadpool.Name = "radioButton_threadpool";
            this.radioButton_threadpool.Size = new System.Drawing.Size(83, 16);
            this.radioButton_threadpool.TabIndex = 4;
            this.radioButton_threadpool.TabStop = true;
            this.radioButton_threadpool.Text = "ThreadPool";
            this.radioButton_threadpool.UseVisualStyleBackColor = true;
            // 
            // radioButton_thread
            // 
            this.radioButton_thread.AutoSize = true;
            this.radioButton_thread.Location = new System.Drawing.Point(12, 20);
            this.radioButton_thread.Name = "radioButton_thread";
            this.radioButton_thread.Size = new System.Drawing.Size(59, 16);
            this.radioButton_thread.TabIndex = 3;
            this.radioButton_thread.TabStop = true;
            this.radioButton_thread.Text = "Thread";
            this.radioButton_thread.UseVisualStyleBackColor = true;
            // 
            // Form_asyncTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.groupBox_setup);
            this.Controls.Add(this.groupBox_log);
            this.Name = "Form_asyncTest";
            this.Text = "AsyncTest";
            this.groupBox_log.ResumeLayout(false);
            this.groupBox_log.PerformLayout();
            this.groupBox_setup.ResumeLayout(false);
            this.groupBox_setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.GroupBox groupBox_setup;
        private System.Windows.Forms.Label label_param;
        private System.Windows.Forms.TextBox textBox_param;
        private System.Windows.Forms.RadioButton radioButton_async;
        private System.Windows.Forms.RadioButton radioButton_task;
        private System.Windows.Forms.RadioButton radioButton_threadpool;
        private System.Windows.Forms.RadioButton radioButton_thread;
    }
}

