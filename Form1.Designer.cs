namespace Calculadora_CSharp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        button2 = new Button();
        btnCalcular = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();
        button13 = new Button();
        button14 = new Button();
        button15 = new Button();
        button16 = new Button();
        txtVisor = new TextBox();
        button17 = new Button();
        button18 = new Button();
        button19 = new Button();
        btn_raizQuadrada = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(20, 405);
        button1.Name = "button1";
        button1.Size = new Size(78, 66);
        button1.TabIndex = 0;
        button1.Text = "0";
        button1.UseVisualStyleBackColor = true;
        button1.Click += PressionarBotao;
        // 
        // button2
        // 
        button2.Location = new Point(104, 405);
        button2.Name = "button2";
        button2.Size = new Size(78, 66);
        button2.TabIndex = 1;
        button2.Text = ",";
        button2.UseVisualStyleBackColor = true;
        button2.Click += PressionarBotao;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(188, 405);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(78, 66);
        btnCalcular.TabIndex = 2;
        btnCalcular.Text = "=";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // button4
        // 
        button4.Location = new Point(272, 405);
        button4.Name = "button4";
        button4.Size = new Size(78, 66);
        button4.TabIndex = 3;
        button4.Text = "+";
        button4.UseVisualStyleBackColor = true;
        button4.Click += PressionarBotao;
        // 
        // button5
        // 
        button5.Location = new Point(272, 333);
        button5.Name = "button5";
        button5.Size = new Size(78, 66);
        button5.TabIndex = 7;
        button5.Text = "-";
        button5.UseVisualStyleBackColor = true;
        button5.Click += PressionarBotao;
        // 
        // button6
        // 
        button6.Location = new Point(188, 333);
        button6.Name = "button6";
        button6.Size = new Size(78, 66);
        button6.TabIndex = 6;
        button6.Text = "3";
        button6.UseVisualStyleBackColor = true;
        button6.Click += PressionarBotao;
        // 
        // button7
        // 
        button7.Location = new Point(104, 333);
        button7.Name = "button7";
        button7.Size = new Size(78, 66);
        button7.TabIndex = 5;
        button7.Text = "2";
        button7.UseVisualStyleBackColor = true;
        button7.Click += PressionarBotao;
        // 
        // button8
        // 
        button8.Location = new Point(20, 333);
        button8.Name = "button8";
        button8.Size = new Size(78, 66);
        button8.TabIndex = 4;
        button8.Text = "1";
        button8.UseVisualStyleBackColor = true;
        button8.Click += PressionarBotao;
        // 
        // button9
        // 
        button9.Location = new Point(272, 261);
        button9.Name = "button9";
        button9.Size = new Size(78, 66);
        button9.TabIndex = 11;
        button9.Text = "x";
        button9.UseVisualStyleBackColor = true;
        button9.Click += PressionarBotao;
        // 
        // button10
        // 
        button10.Location = new Point(188, 261);
        button10.Name = "button10";
        button10.Size = new Size(78, 66);
        button10.TabIndex = 10;
        button10.Text = "6";
        button10.UseVisualStyleBackColor = true;
        button10.Click += PressionarBotao;
        // 
        // button11
        // 
        button11.Location = new Point(104, 261);
        button11.Name = "button11";
        button11.Size = new Size(78, 66);
        button11.TabIndex = 9;
        button11.Text = "5";
        button11.UseVisualStyleBackColor = true;
        button11.Click += PressionarBotao;
        // 
        // button12
        // 
        button12.Location = new Point(20, 261);
        button12.Name = "button12";
        button12.Size = new Size(78, 66);
        button12.TabIndex = 8;
        button12.Text = "4";
        button12.UseVisualStyleBackColor = true;
        button12.Click += PressionarBotao;
        // 
        // button13
        // 
        button13.Location = new Point(272, 189);
        button13.Name = "button13";
        button13.Size = new Size(78, 66);
        button13.TabIndex = 15;
        button13.Text = "/";
        button13.UseVisualStyleBackColor = true;
        button13.Click += PressionarBotao;
        // 
        // button14
        // 
        button14.Location = new Point(188, 189);
        button14.Name = "button14";
        button14.Size = new Size(78, 66);
        button14.TabIndex = 14;
        button14.Text = "9";
        button14.UseVisualStyleBackColor = true;
        button14.Click += PressionarBotao;
        // 
        // button15
        // 
        button15.Location = new Point(104, 189);
        button15.Name = "button15";
        button15.Size = new Size(78, 66);
        button15.TabIndex = 13;
        button15.Text = "8";
        button15.UseVisualStyleBackColor = true;
        button15.Click += PressionarBotao;
        // 
        // button16
        // 
        button16.Location = new Point(20, 189);
        button16.Name = "button16";
        button16.Size = new Size(78, 66);
        button16.TabIndex = 12;
        button16.Text = "7";
        button16.UseVisualStyleBackColor = true;
        button16.Click += PressionarBotao;
        // 
        // txtVisor
        // 
        txtVisor.BackColor = SystemColors.ControlLightLight;
        txtVisor.Font = new Font("Segoe UI", 25F);
        txtVisor.Location = new Point(20, 24);
        txtVisor.Multiline = true;
        txtVisor.Name = "txtVisor";
        txtVisor.ReadOnly = true;
        txtVisor.Size = new Size(330, 75);
        txtVisor.TabIndex = 16;
        txtVisor.TextAlign = HorizontalAlignment.Right;
        // 
        // button17
        // 
        button17.Location = new Point(272, 117);
        button17.Name = "button17";
        button17.Size = new Size(78, 66);
        button17.TabIndex = 17;
        button17.Text = "C";
        button17.UseVisualStyleBackColor = true;
        button17.Click += LimparVisor;
        // 
        // button18
        // 
        button18.Location = new Point(188, 117);
        button18.Name = "button18";
        button18.Size = new Size(78, 66);
        button18.TabIndex = 18;
        button18.Text = ")";
        button18.UseVisualStyleBackColor = true;
        button18.Click += PressionarBotao;
        // 
        // button19
        // 
        button19.Location = new Point(104, 117);
        button19.Name = "button19";
        button19.Size = new Size(78, 66);
        button19.TabIndex = 19;
        button19.Text = "(";
        button19.UseVisualStyleBackColor = true;
        button19.Click += PressionarBotao;
        // 
        // btn_raizQuadrada
        // 
        btn_raizQuadrada.Font = new Font("Segoe UI", 12F);
        btn_raizQuadrada.Location = new Point(20, 117);
        btn_raizQuadrada.Name = "btn_raizQuadrada";
        btn_raizQuadrada.Size = new Size(78, 66);
        btn_raizQuadrada.TabIndex = 20;
        btn_raizQuadrada.Text = "√";
        btn_raizQuadrada.UseVisualStyleBackColor = true;
        btn_raizQuadrada.Click += btn_raizQuadrada_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(381, 483);
        Controls.Add(btn_raizQuadrada);
        Controls.Add(button19);
        Controls.Add(button18);
        Controls.Add(button17);
        Controls.Add(txtVisor);
        Controls.Add(button13);
        Controls.Add(button14);
        Controls.Add(button15);
        Controls.Add(button16);
        Controls.Add(button9);
        Controls.Add(button10);
        Controls.Add(button11);
        Controls.Add(button12);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button7);
        Controls.Add(button8);
        Controls.Add(button4);
        Controls.Add(btnCalcular);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button btnCalcular;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private Button button15;
    private Button button16;
    private TextBox txtVisor;
    private Button button17;
    private Button button18;
    private Button button19;
    private Button btn_raizQuadrada;
}
