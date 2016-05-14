namespace ICU_FINAL
{
    partial class fileformats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileformats));
            this.formatsListBox = new System.Windows.Forms.CheckedListBox();
            this.btnAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // formatsListBox
            // 
            this.formatsListBox.FormattingEnabled = true;
            this.formatsListBox.HorizontalScrollbar = true;
            this.formatsListBox.Location = new System.Drawing.Point(12, 71);
            this.formatsListBox.Name = "formatsListBox";
            this.formatsListBox.Size = new System.Drawing.Size(185, 214);
            this.formatsListBox.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Depth = 0;
            this.btnAll.Location = new System.Drawing.Point(203, 71);
            this.btnAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAll.Name = "btnAll";
            this.btnAll.Primary = true;
            this.btnAll.Size = new System.Drawing.Size(101, 27);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Select All";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // btnNone
            // 
            this.btnNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNone.Depth = 0;
            this.btnNone.Location = new System.Drawing.Point(203, 104);
            this.btnNone.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNone.Name = "btnNone";
            this.btnNone.Primary = true;
            this.btnNone.Size = new System.Drawing.Size(101, 27);
            this.btnNone.TabIndex = 2;
            this.btnNone.Text = "Select None";
            this.btnNone.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(203, 258);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(101, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fileformats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(316, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.formatsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fileformats";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Formats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox formatsListBox;
        private MaterialSkin.Controls.MaterialRaisedButton btnAll;
        private MaterialSkin.Controls.MaterialRaisedButton btnNone;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;

    }
}