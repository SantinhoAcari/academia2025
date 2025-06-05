namespace Academia2025
{
    partial class RegistroPagamento
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
            label1 = new Label();
            MatriculaCaixa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ValorCaixa = new TextBox();
            DataCaixa = new DateTimePicker();
            B_Pagamento = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Calibri", 9F);
            label1.Location = new Point(174, 119);
            label1.Name = "label1";
            label1.Size = new Size(125, 16);
            label1.TabIndex = 0;
            label1.Text = "Matrícula do Membro";
            // 
            // MatriculaCaixa
            // 
            MatriculaCaixa.BorderStyle = BorderStyle.FixedSingle;
            MatriculaCaixa.Font = new Font("Arial Narrow", 9F);
            MatriculaCaixa.Location = new Point(174, 150);
            MatriculaCaixa.Name = "MatriculaCaixa";
            MatriculaCaixa.Size = new Size(289, 21);
            MatriculaCaixa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Calibri", 9F);
            label2.Location = new Point(174, 201);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 2;
            label2.Text = "Valor Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Calibri", 9F);
            label3.Location = new Point(174, 282);
            label3.Name = "label3";
            label3.Size = new Size(116, 16);
            label3.TabIndex = 3;
            label3.Text = "Data do Pagamento";
            // 
            // ValorCaixa
            // 
            ValorCaixa.BorderStyle = BorderStyle.FixedSingle;
            ValorCaixa.Font = new Font("Arial Narrow", 9F);
            ValorCaixa.Location = new Point(174, 230);
            ValorCaixa.Name = "ValorCaixa";
            ValorCaixa.Size = new Size(289, 21);
            ValorCaixa.TabIndex = 4;
            // 
            // DataCaixa
            // 
            DataCaixa.Format = DateTimePickerFormat.Short;
            DataCaixa.Location = new Point(174, 310);
            DataCaixa.Name = "DataCaixa";
            DataCaixa.Size = new Size(114, 23);
            DataCaixa.TabIndex = 5;
            // 
            // B_Pagamento
            // 
            B_Pagamento.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Pagamento.Location = new Point(328, 310);
            B_Pagamento.Name = "B_Pagamento";
            B_Pagamento.Size = new Size(135, 23);
            B_Pagamento.TabIndex = 6;
            B_Pagamento.Text = "Confirmar Pagamento";
            B_Pagamento.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 450);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 11);
            button1.Name = "button1";
            button1.Size = new Size(153, 53);
            button1.TabIndex = 0;
            button1.Text = "Tela Inicial";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegistroPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 450);
            Controls.Add(panel1);
            Controls.Add(B_Pagamento);
            Controls.Add(DataCaixa);
            Controls.Add(ValorCaixa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MatriculaCaixa);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "RegistroPagamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Pagamento";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MatriculaCaixa;
        private Label label2;
        private Label label3;
        private TextBox ValorCaixa;
        private DateTimePicker DataCaixa;
        private Button B_Pagamento;
        private Panel panel1;
        private Button button1;
    }
}