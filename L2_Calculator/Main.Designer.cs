namespace Laboratory02 {
  partial class Main {
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
      this.root = new System.Windows.Forms.TableLayoutPanel();
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.ops = new System.Windows.Forms.TableLayoutPanel();
      this.del = new System.Windows.Forms.Button();
      this.add = new System.Windows.Forms.Button();
      this.sub = new System.Windows.Forms.Button();
      this.mul = new System.Windows.Forms.Button();
      this.div = new System.Windows.Forms.Button();
      this.util = new System.Windows.Forms.TableLayoutPanel();
      this.sign = new System.Windows.Forms.Button();
      this.dot = new System.Windows.Forms.Button();
      this.calc = new System.Windows.Forms.Button();
      this.num0 = new System.Windows.Forms.Button();
      this.keyPad = new System.Windows.Forms.TableLayoutPanel();
      this.num3 = new System.Windows.Forms.Button();
      this.num2 = new System.Windows.Forms.Button();
      this.num1 = new System.Windows.Forms.Button();
      this.num6 = new System.Windows.Forms.Button();
      this.num5 = new System.Windows.Forms.Button();
      this.num4 = new System.Windows.Forms.Button();
      this.num9 = new System.Windows.Forms.Button();
      this.num8 = new System.Windows.Forms.Button();
      this.num7 = new System.Windows.Forms.Button();
      this.result = new System.Windows.Forms.Label();
      this.expr = new System.Windows.Forms.Label();
      this.root.SuspendLayout();
      this.body.SuspendLayout();
      this.ops.SuspendLayout();
      this.util.SuspendLayout();
      this.keyPad.SuspendLayout();
      this.SuspendLayout();
      // 
      // root
      // 
      this.root.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.root.ColumnCount = 1;
      this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.root.Controls.Add(this.body, 0, 2);
      this.root.Controls.Add(this.result, 0, 1);
      this.root.Controls.Add(this.expr, 0, 0);
      this.root.Dock = System.Windows.Forms.DockStyle.Fill;
      this.root.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.root.Location = new System.Drawing.Point(0, 0);
      this.root.Margin = new System.Windows.Forms.Padding(2);
      this.root.Name = "root";
      this.root.RowCount = 3;
      this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
      this.root.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.root.Size = new System.Drawing.Size(600, 417);
      this.root.TabIndex = 5;
      // 
      // body
      // 
      this.body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.body.ColumnCount = 2;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.body.Controls.Add(this.ops, 1, 0);
      this.body.Controls.Add(this.util, 0, 1);
      this.body.Controls.Add(this.keyPad, 0, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.body.Location = new System.Drawing.Point(0, 81);
      this.body.Margin = new System.Windows.Forms.Padding(0);
      this.body.Name = "body";
      this.body.RowCount = 2;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.body.Size = new System.Drawing.Size(600, 336);
      this.body.TabIndex = 8;
      // 
      // ops
      // 
      this.ops.AutoSize = true;
      this.ops.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ops.ColumnCount = 1;
      this.ops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.ops.Controls.Add(this.del, 0, 0);
      this.ops.Controls.Add(this.add, 0, 4);
      this.ops.Controls.Add(this.sub, 0, 3);
      this.ops.Controls.Add(this.mul, 0, 2);
      this.ops.Controls.Add(this.div, 0, 1);
      this.ops.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ops.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.ops.Location = new System.Drawing.Point(450, 0);
      this.ops.Margin = new System.Windows.Forms.Padding(0);
      this.ops.Name = "ops";
      this.ops.RowCount = 5;
      this.body.SetRowSpan(this.ops, 2);
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.ops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.ops.Size = new System.Drawing.Size(150, 336);
      this.ops.TabIndex = 15;
      // 
      // del
      // 
      this.del.AccessibleName = "Backspace";
      this.del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.del.AutoSize = true;
      this.del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.del.BackColor = System.Drawing.Color.Transparent;
      this.del.Dock = System.Windows.Forms.DockStyle.Fill;
      this.del.FlatAppearance.BorderSize = 0;
      this.del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.del.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.del.ForeColor = System.Drawing.Color.White;
      this.del.Location = new System.Drawing.Point(2, 2);
      this.del.Margin = new System.Windows.Forms.Padding(2);
      this.del.Name = "del";
      this.del.Size = new System.Drawing.Size(146, 63);
      this.del.TabIndex = 20;
      this.del.Text = "⌫";
      this.del.UseVisualStyleBackColor = false;
      // 
      // add
      // 
      this.add.AccessibleName = "+";
      this.add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.add.AutoSize = true;
      this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.add.BackColor = System.Drawing.Color.Transparent;
      this.add.Dock = System.Windows.Forms.DockStyle.Fill;
      this.add.FlatAppearance.BorderSize = 0;
      this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.add.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.add.ForeColor = System.Drawing.Color.White;
      this.add.Location = new System.Drawing.Point(2, 270);
      this.add.Margin = new System.Windows.Forms.Padding(2);
      this.add.Name = "add";
      this.add.Size = new System.Drawing.Size(146, 64);
      this.add.TabIndex = 19;
      this.add.Text = "+";
      this.add.UseVisualStyleBackColor = false;
      // 
      // sub
      // 
      this.sub.AccessibleName = "-";
      this.sub.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.sub.AutoSize = true;
      this.sub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.sub.BackColor = System.Drawing.Color.Transparent;
      this.sub.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sub.FlatAppearance.BorderSize = 0;
      this.sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.sub.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sub.ForeColor = System.Drawing.Color.White;
      this.sub.Location = new System.Drawing.Point(2, 203);
      this.sub.Margin = new System.Windows.Forms.Padding(2);
      this.sub.Name = "sub";
      this.sub.Size = new System.Drawing.Size(146, 63);
      this.sub.TabIndex = 18;
      this.sub.Text = "-";
      this.sub.UseVisualStyleBackColor = false;
      // 
      // mul
      // 
      this.mul.AccessibleName = "*";
      this.mul.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.mul.AutoSize = true;
      this.mul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.mul.BackColor = System.Drawing.Color.Transparent;
      this.mul.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mul.FlatAppearance.BorderSize = 0;
      this.mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.mul.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mul.ForeColor = System.Drawing.Color.White;
      this.mul.Location = new System.Drawing.Point(2, 136);
      this.mul.Margin = new System.Windows.Forms.Padding(2);
      this.mul.Name = "mul";
      this.mul.Size = new System.Drawing.Size(146, 63);
      this.mul.TabIndex = 17;
      this.mul.Text = "×";
      this.mul.UseVisualStyleBackColor = false;
      // 
      // div
      // 
      this.div.AccessibleName = "/";
      this.div.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.div.AutoSize = true;
      this.div.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.div.BackColor = System.Drawing.Color.Transparent;
      this.div.Dock = System.Windows.Forms.DockStyle.Fill;
      this.div.FlatAppearance.BorderSize = 0;
      this.div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.div.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.div.ForeColor = System.Drawing.Color.White;
      this.div.Location = new System.Drawing.Point(2, 69);
      this.div.Margin = new System.Windows.Forms.Padding(2);
      this.div.Name = "div";
      this.div.Size = new System.Drawing.Size(146, 63);
      this.div.TabIndex = 16;
      this.div.Text = "÷";
      this.div.UseVisualStyleBackColor = false;
      // 
      // util
      // 
      this.util.AutoSize = true;
      this.util.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.util.ColumnCount = 4;
      this.util.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.util.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.util.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.util.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.util.Controls.Add(this.sign, 0, 0);
      this.util.Controls.Add(this.dot, 2, 0);
      this.util.Controls.Add(this.calc, 3, 0);
      this.util.Controls.Add(this.num0, 1, 0);
      this.util.Dock = System.Windows.Forms.DockStyle.Fill;
      this.util.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.util.Location = new System.Drawing.Point(0, 252);
      this.util.Margin = new System.Windows.Forms.Padding(0);
      this.util.Name = "util";
      this.util.RowCount = 1;
      this.util.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.util.Size = new System.Drawing.Size(450, 84);
      this.util.TabIndex = 16;
      // 
      // sign
      // 
      this.sign.AccessibleName = "F2";
      this.sign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.sign.AutoSize = true;
      this.sign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.sign.BackColor = System.Drawing.Color.Transparent;
      this.sign.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sign.FlatAppearance.BorderSize = 0;
      this.sign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.sign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.sign.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sign.ForeColor = System.Drawing.Color.White;
      this.sign.Location = new System.Drawing.Point(2, 2);
      this.sign.Margin = new System.Windows.Forms.Padding(2);
      this.sign.Name = "sign";
      this.sign.Size = new System.Drawing.Size(108, 80);
      this.sign.TabIndex = 18;
      this.sign.Text = "±";
      this.sign.UseVisualStyleBackColor = false;
      // 
      // dot
      // 
      this.dot.AccessibleName = ".";
      this.dot.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.dot.AutoSize = true;
      this.dot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.dot.BackColor = System.Drawing.Color.Transparent;
      this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot.FlatAppearance.BorderSize = 0;
      this.dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dot.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot.ForeColor = System.Drawing.Color.White;
      this.dot.Location = new System.Drawing.Point(226, 2);
      this.dot.Margin = new System.Windows.Forms.Padding(2);
      this.dot.Name = "dot";
      this.dot.Size = new System.Drawing.Size(108, 80);
      this.dot.TabIndex = 17;
      this.dot.Text = ".";
      this.dot.UseVisualStyleBackColor = false;
      // 
      // calc
      // 
      this.calc.AccessibleName = "Return";
      this.calc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.calc.AutoSize = true;
      this.calc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.calc.BackColor = System.Drawing.Color.Transparent;
      this.calc.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.calc.Dock = System.Windows.Forms.DockStyle.Fill;
      this.calc.FlatAppearance.BorderSize = 0;
      this.calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.calc.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.calc.ForeColor = System.Drawing.Color.White;
      this.calc.Location = new System.Drawing.Point(338, 2);
      this.calc.Margin = new System.Windows.Forms.Padding(2);
      this.calc.Name = "calc";
      this.calc.Size = new System.Drawing.Size(110, 80);
      this.calc.TabIndex = 16;
      this.calc.Text = "=";
      this.calc.UseVisualStyleBackColor = false;
      // 
      // num0
      // 
      this.num0.AccessibleName = "0";
      this.num0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num0.AutoSize = true;
      this.num0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num0.BackColor = System.Drawing.Color.Transparent;
      this.num0.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num0.FlatAppearance.BorderSize = 0;
      this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num0.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num0.ForeColor = System.Drawing.Color.White;
      this.num0.Location = new System.Drawing.Point(114, 2);
      this.num0.Margin = new System.Windows.Forms.Padding(2);
      this.num0.Name = "num0";
      this.num0.Size = new System.Drawing.Size(108, 80);
      this.num0.TabIndex = 15;
      this.num0.Text = "0";
      this.num0.UseVisualStyleBackColor = false;
      // 
      // keyPad
      // 
      this.keyPad.AutoSize = true;
      this.keyPad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.keyPad.ColumnCount = 3;
      this.keyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.Controls.Add(this.num3, 2, 2);
      this.keyPad.Controls.Add(this.num2, 1, 2);
      this.keyPad.Controls.Add(this.num1, 0, 2);
      this.keyPad.Controls.Add(this.num6, 2, 1);
      this.keyPad.Controls.Add(this.num5, 1, 1);
      this.keyPad.Controls.Add(this.num4, 0, 1);
      this.keyPad.Controls.Add(this.num9, 2, 0);
      this.keyPad.Controls.Add(this.num8, 1, 0);
      this.keyPad.Controls.Add(this.num7, 0, 0);
      this.keyPad.Dock = System.Windows.Forms.DockStyle.Fill;
      this.keyPad.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.keyPad.Location = new System.Drawing.Point(0, 0);
      this.keyPad.Margin = new System.Windows.Forms.Padding(0);
      this.keyPad.Name = "keyPad";
      this.keyPad.RowCount = 3;
      this.keyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.keyPad.Size = new System.Drawing.Size(450, 252);
      this.keyPad.TabIndex = 17;
      // 
      // num3
      // 
      this.num3.AccessibleName = "3";
      this.num3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num3.AutoSize = true;
      this.num3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num3.BackColor = System.Drawing.Color.Transparent;
      this.num3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num3.FlatAppearance.BorderSize = 0;
      this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num3.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num3.ForeColor = System.Drawing.Color.White;
      this.num3.Location = new System.Drawing.Point(302, 170);
      this.num3.Margin = new System.Windows.Forms.Padding(2);
      this.num3.Name = "num3";
      this.num3.Size = new System.Drawing.Size(146, 80);
      this.num3.TabIndex = 11;
      this.num3.Text = "3";
      this.num3.UseVisualStyleBackColor = false;
      // 
      // num2
      // 
      this.num2.AccessibleName = "2";
      this.num2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num2.AutoSize = true;
      this.num2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num2.BackColor = System.Drawing.Color.Transparent;
      this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num2.FlatAppearance.BorderSize = 0;
      this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num2.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num2.ForeColor = System.Drawing.Color.White;
      this.num2.Location = new System.Drawing.Point(152, 170);
      this.num2.Margin = new System.Windows.Forms.Padding(2);
      this.num2.Name = "num2";
      this.num2.Size = new System.Drawing.Size(146, 80);
      this.num2.TabIndex = 10;
      this.num2.Text = "2";
      this.num2.UseVisualStyleBackColor = false;
      // 
      // num1
      // 
      this.num1.AccessibleName = "1";
      this.num1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num1.AutoSize = true;
      this.num1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num1.BackColor = System.Drawing.Color.Transparent;
      this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num1.FlatAppearance.BorderSize = 0;
      this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num1.ForeColor = System.Drawing.Color.White;
      this.num1.Location = new System.Drawing.Point(2, 170);
      this.num1.Margin = new System.Windows.Forms.Padding(2);
      this.num1.Name = "num1";
      this.num1.Size = new System.Drawing.Size(146, 80);
      this.num1.TabIndex = 9;
      this.num1.Text = "1";
      this.num1.UseVisualStyleBackColor = false;
      // 
      // num6
      // 
      this.num6.AccessibleName = "6";
      this.num6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num6.AutoSize = true;
      this.num6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num6.BackColor = System.Drawing.Color.Transparent;
      this.num6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num6.FlatAppearance.BorderSize = 0;
      this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num6.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num6.ForeColor = System.Drawing.Color.White;
      this.num6.Location = new System.Drawing.Point(302, 86);
      this.num6.Margin = new System.Windows.Forms.Padding(2);
      this.num6.Name = "num6";
      this.num6.Size = new System.Drawing.Size(146, 80);
      this.num6.TabIndex = 7;
      this.num6.Text = "6";
      this.num6.UseVisualStyleBackColor = false;
      // 
      // num5
      // 
      this.num5.AccessibleName = "5";
      this.num5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num5.AutoSize = true;
      this.num5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num5.BackColor = System.Drawing.Color.Transparent;
      this.num5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num5.FlatAppearance.BorderSize = 0;
      this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num5.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num5.ForeColor = System.Drawing.Color.White;
      this.num5.Location = new System.Drawing.Point(152, 86);
      this.num5.Margin = new System.Windows.Forms.Padding(2);
      this.num5.Name = "num5";
      this.num5.Size = new System.Drawing.Size(146, 80);
      this.num5.TabIndex = 6;
      this.num5.Text = "5";
      this.num5.UseVisualStyleBackColor = false;
      // 
      // num4
      // 
      this.num4.AccessibleName = "4";
      this.num4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num4.AutoSize = true;
      this.num4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num4.BackColor = System.Drawing.Color.Transparent;
      this.num4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num4.FlatAppearance.BorderSize = 0;
      this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num4.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num4.ForeColor = System.Drawing.Color.White;
      this.num4.Location = new System.Drawing.Point(2, 86);
      this.num4.Margin = new System.Windows.Forms.Padding(2);
      this.num4.Name = "num4";
      this.num4.Size = new System.Drawing.Size(146, 80);
      this.num4.TabIndex = 5;
      this.num4.Text = "4";
      this.num4.UseVisualStyleBackColor = false;
      // 
      // num9
      // 
      this.num9.AccessibleName = "9";
      this.num9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num9.AutoSize = true;
      this.num9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num9.BackColor = System.Drawing.Color.Transparent;
      this.num9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num9.FlatAppearance.BorderSize = 0;
      this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num9.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num9.ForeColor = System.Drawing.Color.White;
      this.num9.Location = new System.Drawing.Point(302, 2);
      this.num9.Margin = new System.Windows.Forms.Padding(2);
      this.num9.Name = "num9";
      this.num9.Size = new System.Drawing.Size(146, 80);
      this.num9.TabIndex = 3;
      this.num9.Text = "9";
      this.num9.UseVisualStyleBackColor = false;
      // 
      // num8
      // 
      this.num8.AccessibleName = "8";
      this.num8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num8.AutoSize = true;
      this.num8.BackColor = System.Drawing.Color.Transparent;
      this.num8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num8.FlatAppearance.BorderSize = 0;
      this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num8.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num8.ForeColor = System.Drawing.Color.White;
      this.num8.Location = new System.Drawing.Point(152, 2);
      this.num8.Margin = new System.Windows.Forms.Padding(2);
      this.num8.Name = "num8";
      this.num8.Size = new System.Drawing.Size(146, 80);
      this.num8.TabIndex = 2;
      this.num8.Text = "8";
      this.num8.UseVisualStyleBackColor = false;
      // 
      // num7
      // 
      this.num7.AccessibleName = "7";
      this.num7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.num7.AutoSize = true;
      this.num7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.num7.BackColor = System.Drawing.Color.Transparent;
      this.num7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num7.FlatAppearance.BorderSize = 0;
      this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.num7.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num7.ForeColor = System.Drawing.Color.White;
      this.num7.Location = new System.Drawing.Point(2, 2);
      this.num7.Margin = new System.Windows.Forms.Padding(2);
      this.num7.Name = "num7";
      this.num7.Size = new System.Drawing.Size(146, 80);
      this.num7.TabIndex = 1;
      this.num7.Text = "7";
      this.num7.UseVisualStyleBackColor = false;
      // 
      // result
      // 
      this.result.AutoSize = true;
      this.result.Dock = System.Windows.Forms.DockStyle.Fill;
      this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.result.Location = new System.Drawing.Point(0, 24);
      this.result.Margin = new System.Windows.Forms.Padding(0);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(600, 57);
      this.result.TabIndex = 5;
      this.result.Text = "0";
      this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // expr
      // 
      this.expr.Dock = System.Windows.Forms.DockStyle.Fill;
      this.expr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.expr.Location = new System.Drawing.Point(2, 0);
      this.expr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.expr.Name = "expr";
      this.expr.Size = new System.Drawing.Size(596, 24);
      this.expr.TabIndex = 4;
      this.expr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Main
      // 
      this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(600, 417);
      this.Controls.Add(this.root);
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(616, 456);
      this.Name = "Main";
      this.ShowIcon = false;
      this.Text = "Calculator";
      this.root.ResumeLayout(false);
      this.root.PerformLayout();
      this.body.ResumeLayout(false);
      this.body.PerformLayout();
      this.ops.ResumeLayout(false);
      this.ops.PerformLayout();
      this.util.ResumeLayout(false);
      this.util.PerformLayout();
      this.keyPad.ResumeLayout(false);
      this.keyPad.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
    private System.Windows.Forms.TableLayoutPanel root;
    private System.Windows.Forms.Label result;
    private System.Windows.Forms.Label expr;
    private System.Windows.Forms.TableLayoutPanel body;
    private System.Windows.Forms.TableLayoutPanel ops;
    private System.Windows.Forms.Button del;
    private System.Windows.Forms.Button add;
    private System.Windows.Forms.Button sub;
    private System.Windows.Forms.Button mul;
    private System.Windows.Forms.Button div;
    private System.Windows.Forms.TableLayoutPanel util;
    private System.Windows.Forms.Button sign;
    private System.Windows.Forms.Button dot;
    private System.Windows.Forms.Button calc;
    private System.Windows.Forms.Button num0;
    private System.Windows.Forms.TableLayoutPanel keyPad;
    private System.Windows.Forms.Button num3;
    private System.Windows.Forms.Button num2;
    private System.Windows.Forms.Button num1;
    private System.Windows.Forms.Button num6;
    private System.Windows.Forms.Button num5;
    private System.Windows.Forms.Button num4;
    private System.Windows.Forms.Button num9;
    private System.Windows.Forms.Button num8;
    private System.Windows.Forms.Button num7;
  }
}

