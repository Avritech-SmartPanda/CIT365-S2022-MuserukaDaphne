namespace MegaDesk_TeamBountiful
{
    partial class AddQuote
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialsInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.totalQuote = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.widthError = new System.Windows.Forms.Label();
            this.depthError = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(334, 83);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(386, 26);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            this.customerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerName_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cutomer Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(334, 147);
            this.widthInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(386, 26);
            this.widthInput.TabIndex = 2;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged_1);
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_TextChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(334, 219);
            this.depthInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(386, 26);
            this.depthInput.TabIndex = 3;
            this.depthInput.TextChanged += new System.EventHandler(this.depthInput_TextChanged);
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(159, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(159, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(334, 292);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(388, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // materialsInput
            // 
            this.materialsInput.FormattingEnabled = true;
            this.materialsInput.Location = new System.Drawing.Point(334, 356);
            this.materialsInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialsInput.Name = "materialsInput";
            this.materialsInput.Size = new System.Drawing.Size(386, 28);
            this.materialsInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(159, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "No of Drawers: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(159, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(159, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rush Order: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(322, 566);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(184, 80);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(541, 566);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(184, 80);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Place Order";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // totalQuote
            // 
            this.totalQuote.BackColor = System.Drawing.SystemColors.Control;
            this.totalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuote.Location = new System.Drawing.Point(330, 481);
            this.totalQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalQuote.Name = "totalQuote";
            this.totalQuote.Size = new System.Drawing.Size(386, 40);
            this.totalQuote.TabIndex = 18;
            // 
            // nameError
            // 
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(339, 118);
            this.nameError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(381, 27);
            this.nameError.TabIndex = 19;
            // 
            // widthError
            // 
            this.widthError.ForeColor = System.Drawing.Color.Red;
            this.widthError.Location = new System.Drawing.Point(335, 184);
            this.widthError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(381, 27);
            this.widthError.TabIndex = 20;
            // 
            // depthError
            // 
            this.depthError.ForeColor = System.Drawing.Color.Red;
            this.depthError.Location = new System.Drawing.Point(339, 255);
            this.depthError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthError.Name = "depthError";
            this.depthError.Size = new System.Drawing.Size(381, 27);
            this.depthError.TabIndex = 21;
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Location = new System.Drawing.Point(335, 424);
            this.rushOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(386, 28);
            this.rushOrder.TabIndex = 22;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(943, 793);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.depthError);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.totalQuote);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialsInput);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerName);
            this.Name = "AddQuote";
            this.Text = "Add Quote Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox materialsInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label totalQuote;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.Label depthError;
        private System.Windows.Forms.ComboBox rushOrder;
    }
}