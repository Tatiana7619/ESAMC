namespace Exercícios__TBL4
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            bntRestaurar = new Button();
            bntMaximizar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            btnSugestões = new Button();
            btnVendas = new Button();
            btnProduto = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bntRestaurar);
            panel1.Controls.Add(bntMaximizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 132);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // bntRestaurar
            // 
            bntRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntRestaurar.FlatAppearance.BorderColor = Color.White;
            bntRestaurar.FlatAppearance.BorderSize = 0;
            bntRestaurar.FlatAppearance.MouseDownBackColor = Color.White;
            bntRestaurar.FlatAppearance.MouseOverBackColor = Color.Red;
            bntRestaurar.FlatStyle = FlatStyle.Flat;
            bntRestaurar.Image = Properties.Resources.botao_recarregar_preto_50x50_transparente;
            bntRestaurar.Location = new Point(619, 4);
            bntRestaurar.Name = "bntRestaurar";
            bntRestaurar.Size = new Size(48, 45);
            bntRestaurar.TabIndex = 3;
            bntRestaurar.UseVisualStyleBackColor = true;
            bntRestaurar.Click += bntRestaurar_Click;
            // 
            // bntMaximizar
            // 
            bntMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMaximizar.FlatAppearance.BorderColor = Color.White;
            bntMaximizar.FlatAppearance.BorderSize = 0;
            bntMaximizar.FlatAppearance.MouseDownBackColor = Color.White;
            bntMaximizar.FlatAppearance.MouseOverBackColor = Color.Red;
            bntMaximizar.FlatStyle = FlatStyle.Flat;
            bntMaximizar.Image = Properties.Resources.maximizar_janelas_preto_40x40_transparente;
            bntMaximizar.Location = new Point(673, 6);
            bntMaximizar.Name = "bntMaximizar";
            bntMaximizar.Size = new Size(43, 43);
            bntMaximizar.TabIndex = 2;
            bntMaximizar.UseVisualStyleBackColor = true;
            bntMaximizar.Click += bntMaximizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 26);
            label1.Name = "label1";
            label1.Size = new Size(202, 45);
            label1.TabIndex = 1;
            label1.Text = "Meu Sistema";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(711, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 44);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnSugestões);
            panel2.Controls.Add(btnVendas);
            panel2.Controls.Add(btnProduto);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 317);
            panel2.TabIndex = 1;
            // 
            // btnSugestões
            // 
            btnSugestões.FlatAppearance.BorderColor = Color.White;
            btnSugestões.FlatAppearance.BorderSize = 0;
            btnSugestões.FlatAppearance.MouseDownBackColor = Color.White;
            btnSugestões.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnSugestões.FlatStyle = FlatStyle.Flat;
            btnSugestões.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSugestões.ForeColor = Color.White;
            btnSugestões.Location = new Point(16, 186);
            btnSugestões.Name = "btnSugestões";
            btnSugestões.Size = new Size(175, 48);
            btnSugestões.TabIndex = 3;
            btnSugestões.Text = "Sugestões";
            btnSugestões.UseVisualStyleBackColor = true;
            btnSugestões.Click += btnSugestões_Click;
            // 
            // btnVendas
            // 
            btnVendas.FlatAppearance.BorderColor = Color.White;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseDownBackColor = Color.White;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(15, 126);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(176, 50);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnProduto
            // 
            btnProduto.FlatAppearance.BorderColor = Color.White;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatAppearance.MouseDownBackColor = Color.White;
            btnProduto.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(12, 70);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(179, 48);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.imagem_50x50_transparente;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(2, 23);
            button2.Name = "button2";
            button2.Size = new Size(197, 53);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button bntRestaurar;
        private Button bntMaximizar;
        private Button btnSugestões;
        private Button btnVendas;
        private Button btnProduto;
    }
}
