namespace Flask
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolBoxPanel = new System.Windows.Forms.Panel();
            this.HelloWorldBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBoxPanel
            // 
            this.ToolBoxPanel.Controls.Add(this.HelloWorldBtn);
            this.ToolBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBoxPanel.Name = "ToolBoxPanel";
            this.ToolBoxPanel.Size = new System.Drawing.Size(200, 751);
            this.ToolBoxPanel.TabIndex = 0;
            // 
            // HelloWorldBtn
            // 
            this.HelloWorldBtn.Location = new System.Drawing.Point(12, 12);
            this.HelloWorldBtn.Name = "HelloWorldBtn";
            this.HelloWorldBtn.Size = new System.Drawing.Size(75, 23);
            this.HelloWorldBtn.TabIndex = 0;
            this.HelloWorldBtn.Text = "HelloWorld";
            this.HelloWorldBtn.UseVisualStyleBackColor = true;
            this.HelloWorldBtn.Click += new System.EventHandler(this.HelloWorldBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(312, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 444);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 751);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ToolBoxPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.ToolBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBoxPanel;
        private System.Windows.Forms.Button HelloWorldBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}