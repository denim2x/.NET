using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library;
using System.Drawing;

namespace Laboratory02 {
  using OperatorKeys = Dictionary<Keys, Operator>;
  
  enum Operator {
    None, Add, Sub, Mul, Div, Sign, Dot, Calc, Del, Clear
  } 

  public partial class Main : Form {
    float _value = 0;
    Operator _op = Operator.None;
    bool _decimal = false;

    public Main() {
      InitializeComponent();

      bind_events();
    }

    #region Event handlers
    private void num_Click(object sender, EventArgs e) {
      if (sender is Button button) {
        do_num(button.Text);
      }
    }

    private void op_Click(object sender, EventArgs e) {
      if (sender is Button button) {
        switch (button.Name) {
          case "sign":
            do_op(Operator.Sign);
            break;

          case "dot":
            do_op(Operator.Dot);
            break;

          case "calc":
            do_op(Operator.Calc);
            break;

          case "del":
            do_op(Operator.Del);
            break;

          case "add":
            do_op(Operator.Add);
            break;

          case "sub":
            do_op(Operator.Sub);
            break;

          case "mul":
            do_op(Operator.Mul);
            break;

          case "div":
            do_op(Operator.Div);
            break;
        }
      }
    }

    private void dblClick(object sender, EventArgs e) {
      if (sender is Control control) {
        switch (control.Name) {
          case "result":
            do_op(Operator.Clear);
            break;
        }
      }
    }

    private void del_Click(object sender, EventArgs e) {
      result.Text = result.Text.slice(0, -1);
    }

    private void bind_events() {
      num0.Click += num_Click;
      num1.Click += num_Click;
      num2.Click += num_Click;
      num3.Click += num_Click;
      num4.Click += num_Click;
      num5.Click += num_Click;
      num6.Click += num_Click;
      num7.Click += num_Click;
      num8.Click += num_Click;
      num9.Click += num_Click;

      sign.Click += op_Click;
      dot.Click += op_Click;
      calc.Click += op_Click;

      add.Click += op_Click;
      sub.Click += op_Click;
      mul.Click += op_Click;
      div.Click += op_Click;

      del.Click += op_Click;
      result.DoubleClick += dblClick;
    }
    #endregion

    #region Calculator operations
    private void compute() {
      switch (_op) {
        case Operator.Add:
          _value += parsedValue;
          break;
        case Operator.Sub:
          _value -= parsedValue;
          break;
        case Operator.Mul:
          _value *= parsedValue;
          break;
        case Operator.Div:
          _value /= parsedValue;
          break;
        default:
          _value = parsedValue;
          break;
      }
    }

    private void do_num(string text) {
      if (result.Text == "0") {
        result.Text = "";
      }
      result.Text += text;
    }

    private void do_num(int number) => do_num(number.ToString());

    private void do_op(Operator op) {
      switch (op) {
        case Operator.Calc:
          compute();
          result.Text = _value.ToString();
          _op = Operator.None;
          expr.Text = "";
          break;

        case Operator.Clear:
          result.Text = "0";
          _value = parsedValue;
          _op = Operator.None;
          expr.Text = "";
          break;

        case Operator.Del:
          if (result.Text.slice(-1) == ".") {
            _decimal = false;
          }

          result.Text = result.Text.slice(0, -1);
          if (result.Text == "-" || result.Text == "") {
            result.Text = "0";
          }
          break;

        case Operator.Sign:
          result.Text = (-parsedValue).ToString();
          break;

        case Operator.Dot:
          if (!_decimal) {
            _decimal = true;
            result.Text += ".";
          }
          break;

        default:
          compute();
          expr.Text = _value.ToString() + " " + op_toString(op);
          result.Text = "0";
          _op = op;
          break;
      }
    }
    #endregion

    #region Helpers
    private float parsedValue {
      get => float.Parse(result.Text);
    }

    private string op_toString(Operator op) {
      if (Extras.within(op, Operator.Add, Operator.Div)) {
        return $"{_operators[(int)op - (int)Operator.Add]}";
      }
      return null;
    }

    static string _operators = "+-×÷";
    #endregion

    #region Keyboard handler
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
      if (Extras.within(keyData, Keys.D0, Keys.D9)) {
        do_num((int)keyData - (int)Keys.D0);
        return true;
      }

      if (Extras.within(keyData, Keys.NumPad0, Keys.NumPad9)) {
        do_num((int)keyData - (int)Keys.NumPad0);
        return true;
      }

      if (_keys.TryGetValue(keyData, out var op)) {
        do_op(op);
        return true;
      }

      return base.ProcessCmdKey(ref msg, keyData);
    }

    static OperatorKeys _keys = new OperatorKeys() {
      { Keys.Oem5 /* backslash */, Operator.Sign },
      { Keys.OemPeriod, Operator.Dot },
      { Keys.Enter, Operator.Calc },
      { Keys.Back, Operator.Del },
      { Keys.Delete, Operator.Clear },
      { Keys.Oem2 /* slash */, Operator.Div },
      { Keys.Shift | Keys.D8, Operator.Mul },
      { Keys.OemMinus, Operator.Sub },
      { Keys.Shift | Keys.Oemplus, Operator.Add },

      // Numpad hotkeys
      { Keys.Decimal, Operator.Dot },
      { Keys.Divide, Operator.Div },
      { Keys.Multiply, Operator.Mul },
      { Keys.Subtract, Operator.Sub },
      { Keys.Add, Operator.Add }
    };
    #endregion
  }
}
