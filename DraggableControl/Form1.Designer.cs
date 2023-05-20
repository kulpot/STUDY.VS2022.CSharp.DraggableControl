namespace DraggableControls
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
            this.draggableControl1 = new DraggableControls.DraggableControl();
            this.SuspendLayout();
            // 
            // draggableControl1
            // 
            this.draggableControl1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.draggableControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.draggableControl1.Location = new System.Drawing.Point(24, 22);
            this.draggableControl1.Name = "draggableControl1";
            this.draggableControl1.Size = new System.Drawing.Size(137, 95);
            this.draggableControl1.TabIndex = 0;
            this.draggableControl1.Text = "draggableControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 205);
            this.Controls.Add(this.draggableControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DraggableControl draggableControl1;
    }
}

