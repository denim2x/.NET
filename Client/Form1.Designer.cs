namespace Client {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.layout_Main = new System.Windows.Forms.TableLayoutPanel();
      this.grid_Media = new System.Windows.Forms.DataGridView();
      this.grid_Attribute = new System.Windows.Forms.DataGridView();
      this.grid_AttributeValue = new System.Windows.Forms.DataGridView();
      this.layout_Main.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_Media)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid_Attribute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid_AttributeValue)).BeginInit();
      this.SuspendLayout();
      // 
      // layout_Main
      // 
      this.layout_Main.ColumnCount = 2;
      this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layout_Main.Controls.Add(this.grid_Attribute, 1, 1);
      this.layout_Main.Controls.Add(this.grid_Media, 0, 0);
      this.layout_Main.Controls.Add(this.grid_AttributeValue, 1, 0);
      this.layout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout_Main.Location = new System.Drawing.Point(0, 0);
      this.layout_Main.Name = "layout_Main";
      this.layout_Main.RowCount = 2;
      this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layout_Main.Size = new System.Drawing.Size(800, 450);
      this.layout_Main.TabIndex = 1;
      // 
      // grid_Media
      // 
      this.grid_Media.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_Media.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_Media.Location = new System.Drawing.Point(3, 3);
      this.grid_Media.Name = "grid_Media";
      this.grid_Media.RowHeadersWidth = 51;
      this.layout_Main.SetRowSpan(this.grid_Media, 2);
      this.grid_Media.Size = new System.Drawing.Size(394, 444);
      this.grid_Media.TabIndex = 1;
      // 
      // grid_Attribute
      // 
      this.grid_Attribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_Attribute.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_Attribute.Location = new System.Drawing.Point(403, 228);
      this.grid_Attribute.Name = "grid_Attribute";
      this.grid_Attribute.RowHeadersWidth = 51;
      this.grid_Attribute.Size = new System.Drawing.Size(394, 219);
      this.grid_Attribute.TabIndex = 2;
      // 
      // grid_AttributeValue
      // 
      this.grid_AttributeValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_AttributeValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_AttributeValue.Location = new System.Drawing.Point(403, 3);
      this.grid_AttributeValue.Name = "grid_AttributeValue";
      this.grid_AttributeValue.RowHeadersWidth = 51;
      this.grid_AttributeValue.Size = new System.Drawing.Size(394, 219);
      this.grid_AttributeValue.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.layout_Main);
      this.Name = "Form1";
      this.Text = "MyPhotos [Client]";
      this.layout_Main.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid_Media)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid_Attribute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid_AttributeValue)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_Main;
        private System.Windows.Forms.DataGridView grid_Attribute;
        private System.Windows.Forms.DataGridView grid_Media;
        private System.Windows.Forms.DataGridView grid_AttributeValue;
    }
}

