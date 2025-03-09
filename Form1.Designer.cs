namespace PortalDoAluno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_nome = new TextBox();
            tb_idade = new TextBox();
            tb_curso = new TextBox();
            btn_adicionar = new Button();
            panel1 = new Panel();
            lv__alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 135);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 199);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 267);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Curso";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(31, 164);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(193, 23);
            tb_nome.TabIndex = 4;
            // 
            // tb_idade
            // 
            tb_idade.Location = new Point(32, 237);
            tb_idade.Name = "tb_idade";
            tb_idade.Size = new Size(192, 23);
            tb_idade.TabIndex = 5;
            // 
            // tb_curso
            // 
            tb_curso.Location = new Point(34, 298);
            tb_curso.Name = "tb_curso";
            tb_curso.Size = new Size(190, 23);
            tb_curso.TabIndex = 6;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(66, 350);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(119, 43);
            btn_adicionar.TabIndex = 7;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv__alunos);
            panel1.Location = new Point(257, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 456);
            panel1.TabIndex = 8;
            // 
            // lv__alunos
            // 
            lv__alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv__alunos.Location = new Point(16, 121);
            lv__alunos.Name = "lv__alunos";
            lv__alunos.Size = new Size(418, 300);
            lv__alunos.TabIndex = 0;
            lv__alunos.UseCompatibleStateImageBehavior = false;
            lv__alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 160;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 120;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 140;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 37);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 9;
            label5.Text = "Lista Alunos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(703, 453);
            Controls.Add(panel1);
            Controls.Add(btn_adicionar);
            Controls.Add(tb_curso);
            Controls.Add(tb_idade);
            Controls.Add(tb_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_nome;
        private TextBox tb_idade;
        private TextBox tb_curso;
        private Button btn_adicionar;
        private Panel panel1;
        private ListView lv__alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
    }
}
