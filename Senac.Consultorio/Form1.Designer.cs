namespace Senac.Consultorio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProfessor = new TextBox();
            txtAluno = new TextBox();
            txtAula = new TextBox();
            Cadastrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Professor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Aluno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 158);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Aula";
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(53, 53);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(100, 23);
            txtProfessor.TabIndex = 3;
            // 
            // txtAluno
            // 
            txtAluno.Location = new Point(53, 113);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(100, 23);
            txtAluno.TabIndex = 4;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(53, 176);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(100, 23);
            txtAula.TabIndex = 5;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(110, 239);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(75, 23);
            Cadastrar.TabIndex = 6;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(307, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 35);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Data da Aula";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(541, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 69);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade de alunos cadastrados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(Cadastrar);
            Controls.Add(txtAula);
            Controls.Add(txtAluno);
            Controls.Add(txtProfessor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProfessor;
        private TextBox txtAluno;
        private TextBox txtAula;
        private Button Cadastrar;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private GroupBox groupBox1;
    }
}