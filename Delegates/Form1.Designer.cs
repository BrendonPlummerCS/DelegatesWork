namespace Delegates
{
    partial class Form1
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
            this.btn_ButtonPress = new System.Windows.Forms.Button();
            this.txtBox_TextDisplay = new System.Windows.Forms.TextBox();
            this.lbl_ScreenLabel = new System.Windows.Forms.Label();
            this.lbl_ScreenLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ButtonPress
            // 
            this.btn_ButtonPress.Location = new System.Drawing.Point(142, 255);
            this.btn_ButtonPress.Name = "btn_ButtonPress";
            this.btn_ButtonPress.Size = new System.Drawing.Size(507, 98);
            this.btn_ButtonPress.TabIndex = 0;
            this.btn_ButtonPress.Text = "Button";
            this.btn_ButtonPress.UseVisualStyleBackColor = true;
            this.btn_ButtonPress.Click += new System.EventHandler(this.ButtonClick);
            // 
            // txtBox_TextDisplay
            // 
            this.txtBox_TextDisplay.Location = new System.Drawing.Point(142, 55);
            this.txtBox_TextDisplay.Multiline = true;
            this.txtBox_TextDisplay.Name = "txtBox_TextDisplay";
            this.txtBox_TextDisplay.Size = new System.Drawing.Size(507, 69);
            this.txtBox_TextDisplay.TabIndex = 1;
            // 
            // lbl_ScreenLabel
            // 
            this.lbl_ScreenLabel.AutoSize = true;
            this.lbl_ScreenLabel.Location = new System.Drawing.Point(377, 368);
            this.lbl_ScreenLabel.Name = "lbl_ScreenLabel";
            this.lbl_ScreenLabel.Size = new System.Drawing.Size(33, 13);
            this.lbl_ScreenLabel.TabIndex = 2;
            this.lbl_ScreenLabel.Text = "Label";
            // 
            // lbl_ScreenLabel2
            // 
            this.lbl_ScreenLabel2.AutoSize = true;
            this.lbl_ScreenLabel2.Location = new System.Drawing.Point(377, 405);
            this.lbl_ScreenLabel2.Name = "lbl_ScreenLabel2";
            this.lbl_ScreenLabel2.Size = new System.Drawing.Size(33, 13);
            this.lbl_ScreenLabel2.TabIndex = 3;
            this.lbl_ScreenLabel2.Text = "Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ScreenLabel2);
            this.Controls.Add(this.lbl_ScreenLabel);
            this.Controls.Add(this.txtBox_TextDisplay);
            this.Controls.Add(this.btn_ButtonPress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ButtonPress;
        private System.Windows.Forms.TextBox txtBox_TextDisplay;
        private System.Windows.Forms.Label lbl_ScreenLabel;
        private System.Windows.Forms.Label lbl_ScreenLabel2;
    }
}

