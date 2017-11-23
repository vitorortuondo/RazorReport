namespace RazorReport.Example {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.precompiled = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.run = new System.Windows.Forms.Button();
            this.runPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // precompiled
            // 
            this.precompiled.Location = new System.Drawing.Point(56, 29);
            this.precompiled.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.precompiled.Name = "precompiled";
            this.precompiled.Size = new System.Drawing.Size(264, 55);
            this.precompiled.TabIndex = 0;
            this.precompiled.Text = "Run Compiled";
            this.precompiled.UseVisualStyleBackColor = true;
            this.precompiled.Click += new System.EventHandler(this.runCompiled_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(32, 98);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(53, 48);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1693, 1066);
            this.webBrowser1.TabIndex = 1;
            // 
            // run
            // 
            this.run.AutoEllipsis = true;
            this.run.Location = new System.Drawing.Point(379, 29);
            this.run.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(264, 55);
            this.run.TabIndex = 2;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // runPdf
            // 
            this.runPdf.AutoEllipsis = true;
            this.runPdf.Location = new System.Drawing.Point(696, 29);
            this.runPdf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.runPdf.Name = "runPdf";
            this.runPdf.Size = new System.Drawing.Size(264, 55);
            this.runPdf.TabIndex = 3;
            this.runPdf.Text = "Run PDF";
            this.runPdf.UseVisualStyleBackColor = true;
            this.runPdf.Click += new System.EventHandler(this.runPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 1161);
            this.Controls.Add(this.runPdf);
            this.Controls.Add(this.run);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.precompiled);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button precompiled;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button runPdf;
    }
}

