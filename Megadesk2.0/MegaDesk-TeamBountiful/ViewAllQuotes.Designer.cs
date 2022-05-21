namespace MegaDesk_TeamBountiful
{
    partial class ViewAllQuotes
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
      
            this.label1 = new System.Windows.Forms.Label();
            this.quotesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quotesTable)).BeginInit();
            this.SuspendLayout();          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Quotes";
            // 
            // quotesTable
            // 
            this.quotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quotesTable.Location = new System.Drawing.Point(0, 91);
            this.quotesTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quotesTable.Name = "quotesTable";
            this.quotesTable.RowHeadersWidth = 51;
            this.quotesTable.RowTemplate.Height = 24;
            this.quotesTable.Size = new System.Drawing.Size(880, 462);
            this.quotesTable.TabIndex = 1;
            //
            // ViewAllQuotes
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quotesTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.quotesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView quotesTable;
    }
}