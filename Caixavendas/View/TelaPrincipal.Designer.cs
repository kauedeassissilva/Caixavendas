namespace Caixavendas.View
{
    partial class TelaPrincipal
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxTotal = new TextBox();
            tbxPago = new TextBox();
            tbxTroco = new TextBox();
            btnCalcular = new Button();
            btnLimparTudo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 68);
            label1.Name = "label1";
            label1.Size = new Size(198, 23);
            label1.TabIndex = 0;
            label1.Text = "Caixa - Venda Final";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(250, 141);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Valor Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(250, 184);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Valor Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(266, 231);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Troco";
            // 
            // tbxTotal
            // 
            tbxTotal.Location = new Point(353, 143);
            tbxTotal.Name = "tbxTotal";
            tbxTotal.Size = new Size(100, 23);
            tbxTotal.TabIndex = 4;
            // 
            // tbxPago
            // 
            tbxPago.Location = new Point(353, 186);
            tbxPago.Name = "tbxPago";
            tbxPago.Size = new Size(100, 23);
            tbxPago.TabIndex = 5;
            // 
            // tbxTroco
            // 
            tbxTroco.Location = new Point(353, 229);
            tbxTroco.Name = "tbxTroco";
            tbxTroco.ReadOnly = true;
            tbxTroco.Size = new Size(100, 23);
            tbxTroco.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(178, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(166, 49);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(409, 278);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(156, 49);
            btnLimparTudo.TabIndex = 8;
            btnLimparTudo.Text = "Limpar Tudo";
            btnLimparTudo.UseVisualStyleBackColor = true;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimparTudo);
            Controls.Add(btnCalcular);
            Controls.Add(tbxTroco);
            Controls.Add(tbxPago);
            Controls.Add(tbxTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistemas de Venda de Produtos ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxTotal;
        private TextBox tbxPago;
        private TextBox tbxTroco;
        private Button btnCalcular;
        private Button btnLimparTudo;
    }
}