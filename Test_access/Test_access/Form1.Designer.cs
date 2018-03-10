namespace Test_access
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.UID = new System.Windows.Forms.Label();
            this.PASS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.loginInfoDataSet = new Test_access.LoginInfoDataSet();
            this.loginInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginInfoTableAdapter = new Test_access.LoginInfoDataSetTableAdapters.LoginInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UID
            // 
            this.UID.AutoSize = true;
            this.UID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID.Location = new System.Drawing.Point(58, 46);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(69, 13);
            this.UID.TabIndex = 1;
            this.UID.Text = "User Name";
            // 
            // PASS
            // 
            this.PASS.AutoSize = true;
            this.PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASS.Location = new System.Drawing.Point(58, 84);
            this.PASS.Name = "PASS";
            this.PASS.Size = new System.Drawing.Size(61, 13);
            this.PASS.TabIndex = 2;
            this.PASS.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.loginInfoBindingSource, "UID", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(150, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(150, 128);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // loginInfoDataSet
            // 
            this.loginInfoDataSet.DataSetName = "LoginInfoDataSet";
            this.loginInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginInfoBindingSource
            // 
            this.loginInfoBindingSource.DataMember = "LoginInfo";
            this.loginInfoBindingSource.DataSource = this.loginInfoDataSet;
            // 
            // loginInfoTableAdapter
            // 
            this.loginInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 216);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PASS);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UID;
        private System.Windows.Forms.Label PASS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Login;
        private LoginInfoDataSet loginInfoDataSet;
        private System.Windows.Forms.BindingSource loginInfoBindingSource;
        private LoginInfoDataSetTableAdapters.LoginInfoTableAdapter loginInfoTableAdapter;
    }
}

