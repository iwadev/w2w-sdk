namespace W2W_SDK.Forms.Project {
    partial class NewProject {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.npw_panel_bottom = new System.Windows.Forms.Panel();
            this.npw_panel_body = new System.Windows.Forms.Panel();
            this.prj_creation_ok = new System.Windows.Forms.Button();
            this.prj_creation_cancel = new System.Windows.Forms.Button();
            this.prj_creation_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpl_list = new System.Windows.Forms.ComboBox();
            this.tpl_selector = new System.Windows.Forms.GroupBox();
            this.tpl_workpath = new System.Windows.Forms.GroupBox();
            this.tpl_prj_path = new System.Windows.Forms.TextBox();
            this.tpl_prj_path_but = new System.Windows.Forms.Button();
            this.choose_prj_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.html_workpath = new System.Windows.Forms.GroupBox();
            this.html_prj_path_but = new System.Windows.Forms.Button();
            this.html_prj_path = new System.Windows.Forms.TextBox();
            this.html_selector = new System.Windows.Forms.GroupBox();
            this.html_prj_source_but = new System.Windows.Forms.Button();
            this.html_prj_source = new System.Windows.Forms.TextBox();
            this.choose_html_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.npw_panel_bottom.SuspendLayout();
            this.npw_panel_body.SuspendLayout();
            this.prj_creation_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpl_selector.SuspendLayout();
            this.tpl_workpath.SuspendLayout();
            this.html_workpath.SuspendLayout();
            this.html_selector.SuspendLayout();
            this.SuspendLayout();
            // 
            // npw_panel_bottom
            // 
            this.npw_panel_bottom.Controls.Add(this.prj_creation_cancel);
            this.npw_panel_bottom.Controls.Add(this.prj_creation_ok);
            this.npw_panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.npw_panel_bottom.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npw_panel_bottom.Location = new System.Drawing.Point(0, 306);
            this.npw_panel_bottom.Name = "npw_panel_bottom";
            this.npw_panel_bottom.Size = new System.Drawing.Size(681, 63);
            this.npw_panel_bottom.TabIndex = 0;
            // 
            // npw_panel_body
            // 
            this.npw_panel_body.Controls.Add(this.prj_creation_tab);
            this.npw_panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npw_panel_body.Location = new System.Drawing.Point(0, 0);
            this.npw_panel_body.Name = "npw_panel_body";
            this.npw_panel_body.Size = new System.Drawing.Size(681, 306);
            this.npw_panel_body.TabIndex = 1;
            // 
            // prj_creation_ok
            // 
            this.prj_creation_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.prj_creation_ok.Enabled = false;
            this.prj_creation_ok.Location = new System.Drawing.Point(547, 14);
            this.prj_creation_ok.Name = "prj_creation_ok";
            this.prj_creation_ok.Size = new System.Drawing.Size(122, 35);
            this.prj_creation_ok.TabIndex = 0;
            this.prj_creation_ok.Text = "Создать проект";
            this.prj_creation_ok.UseVisualStyleBackColor = true;
            this.prj_creation_ok.Click += new System.EventHandler(this.prj_creation_ok_Click);
            // 
            // prj_creation_cancel
            // 
            this.prj_creation_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.prj_creation_cancel.Location = new System.Drawing.Point(12, 14);
            this.prj_creation_cancel.Name = "prj_creation_cancel";
            this.prj_creation_cancel.Size = new System.Drawing.Size(110, 35);
            this.prj_creation_cancel.TabIndex = 1;
            this.prj_creation_cancel.Text = "Отмена";
            this.prj_creation_cancel.UseVisualStyleBackColor = true;
            // 
            // prj_creation_tab
            // 
            this.prj_creation_tab.Controls.Add(this.tabPage1);
            this.prj_creation_tab.Controls.Add(this.tabPage2);
            this.prj_creation_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prj_creation_tab.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prj_creation_tab.Location = new System.Drawing.Point(0, 0);
            this.prj_creation_tab.Name = "prj_creation_tab";
            this.prj_creation_tab.SelectedIndex = 0;
            this.prj_creation_tab.Size = new System.Drawing.Size(681, 306);
            this.prj_creation_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpl_workpath);
            this.tabPage1.Controls.Add(this.tpl_selector);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создать из шаблона";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.html_selector);
            this.tabPage2.Controls.Add(this.html_workpath);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Импорт HTML5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tpl_list
            // 
            this.tpl_list.FormattingEnabled = true;
            this.tpl_list.Location = new System.Drawing.Point(6, 24);
            this.tpl_list.Name = "tpl_list";
            this.tpl_list.Size = new System.Drawing.Size(647, 25);
            this.tpl_list.TabIndex = 2;
            // 
            // tpl_selector
            // 
            this.tpl_selector.Controls.Add(this.tpl_list);
            this.tpl_selector.Location = new System.Drawing.Point(6, 6);
            this.tpl_selector.Name = "tpl_selector";
            this.tpl_selector.Size = new System.Drawing.Size(659, 61);
            this.tpl_selector.TabIndex = 3;
            this.tpl_selector.TabStop = false;
            this.tpl_selector.Text = "Выберите шаблон из списка";
            // 
            // tpl_workpath
            // 
            this.tpl_workpath.Controls.Add(this.tpl_prj_path_but);
            this.tpl_workpath.Controls.Add(this.tpl_prj_path);
            this.tpl_workpath.Location = new System.Drawing.Point(6, 73);
            this.tpl_workpath.Name = "tpl_workpath";
            this.tpl_workpath.Size = new System.Drawing.Size(659, 60);
            this.tpl_workpath.TabIndex = 4;
            this.tpl_workpath.TabStop = false;
            this.tpl_workpath.Text = "Укажите рабочую папку проекта";
            // 
            // tpl_prj_path
            // 
            this.tpl_prj_path.Enabled = false;
            this.tpl_prj_path.Location = new System.Drawing.Point(6, 24);
            this.tpl_prj_path.Name = "tpl_prj_path";
            this.tpl_prj_path.Size = new System.Drawing.Size(567, 25);
            this.tpl_prj_path.TabIndex = 0;
            // 
            // tpl_prj_path_but
            // 
            this.tpl_prj_path_but.Location = new System.Drawing.Point(578, 23);
            this.tpl_prj_path_but.Name = "tpl_prj_path_but";
            this.tpl_prj_path_but.Size = new System.Drawing.Size(75, 27);
            this.tpl_prj_path_but.TabIndex = 1;
            this.tpl_prj_path_but.Text = "Обзор";
            this.tpl_prj_path_but.UseVisualStyleBackColor = true;
            this.tpl_prj_path_but.Click += new System.EventHandler(this.tpl_prj_path_but_Click);
            // 
            // choose_prj_dir
            // 
            this.choose_prj_dir.Description = "Выберите рабочую папку проекта";
            // 
            // html_workpath
            // 
            this.html_workpath.Controls.Add(this.html_prj_path_but);
            this.html_workpath.Controls.Add(this.html_prj_path);
            this.html_workpath.Location = new System.Drawing.Point(6, 72);
            this.html_workpath.Name = "html_workpath";
            this.html_workpath.Size = new System.Drawing.Size(659, 60);
            this.html_workpath.TabIndex = 5;
            this.html_workpath.TabStop = false;
            this.html_workpath.Text = "Укажите рабочую папку проекта";
            // 
            // html_prj_path_but
            // 
            this.html_prj_path_but.Location = new System.Drawing.Point(578, 23);
            this.html_prj_path_but.Name = "html_prj_path_but";
            this.html_prj_path_but.Size = new System.Drawing.Size(75, 27);
            this.html_prj_path_but.TabIndex = 1;
            this.html_prj_path_but.Text = "Обзор";
            this.html_prj_path_but.UseVisualStyleBackColor = true;
            this.html_prj_path_but.Click += new System.EventHandler(this.html_prj_path_but_Click);
            // 
            // html_prj_path
            // 
            this.html_prj_path.Enabled = false;
            this.html_prj_path.Location = new System.Drawing.Point(6, 24);
            this.html_prj_path.Name = "html_prj_path";
            this.html_prj_path.Size = new System.Drawing.Size(567, 25);
            this.html_prj_path.TabIndex = 0;
            // 
            // html_selector
            // 
            this.html_selector.Controls.Add(this.html_prj_source_but);
            this.html_selector.Controls.Add(this.html_prj_source);
            this.html_selector.Location = new System.Drawing.Point(6, 6);
            this.html_selector.Name = "html_selector";
            this.html_selector.Size = new System.Drawing.Size(659, 60);
            this.html_selector.TabIndex = 6;
            this.html_selector.TabStop = false;
            this.html_selector.Text = "Выберите папку с вашим HTML5 проектом";
            // 
            // html_prj_source_but
            // 
            this.html_prj_source_but.Location = new System.Drawing.Point(578, 23);
            this.html_prj_source_but.Name = "html_prj_source_but";
            this.html_prj_source_but.Size = new System.Drawing.Size(75, 27);
            this.html_prj_source_but.TabIndex = 1;
            this.html_prj_source_but.Text = "Обзор";
            this.html_prj_source_but.UseVisualStyleBackColor = true;
            this.html_prj_source_but.Click += new System.EventHandler(this.html_prj_source_but_Click);
            // 
            // html_prj_source
            // 
            this.html_prj_source.Enabled = false;
            this.html_prj_source.Location = new System.Drawing.Point(6, 24);
            this.html_prj_source.Name = "html_prj_source";
            this.html_prj_source.Size = new System.Drawing.Size(567, 25);
            this.html_prj_source.TabIndex = 0;
            // 
            // choose_html_dir
            // 
            this.choose_html_dir.Description = "Выберите папку с вашим HTML5 проектом";
            this.choose_html_dir.ShowNewFolderButton = false;
            // 
            // NewProject
            // 
            this.AcceptButton = this.prj_creation_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.prj_creation_cancel;
            this.ClientSize = new System.Drawing.Size(681, 369);
            this.Controls.Add(this.npw_panel_body);
            this.Controls.Add(this.npw_panel_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание проекта";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.npw_panel_bottom.ResumeLayout(false);
            this.npw_panel_body.ResumeLayout(false);
            this.prj_creation_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tpl_selector.ResumeLayout(false);
            this.tpl_workpath.ResumeLayout(false);
            this.tpl_workpath.PerformLayout();
            this.html_workpath.ResumeLayout(false);
            this.html_workpath.PerformLayout();
            this.html_selector.ResumeLayout(false);
            this.html_selector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel npw_panel_bottom;
        private System.Windows.Forms.Button prj_creation_cancel;
        private System.Windows.Forms.Button prj_creation_ok;
        private System.Windows.Forms.Panel npw_panel_body;
        private System.Windows.Forms.TabControl prj_creation_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox tpl_list;
        private System.Windows.Forms.GroupBox tpl_selector;
        private System.Windows.Forms.GroupBox tpl_workpath;
        private System.Windows.Forms.TextBox tpl_prj_path;
        private System.Windows.Forms.Button tpl_prj_path_but;
        private System.Windows.Forms.FolderBrowserDialog choose_prj_dir;
        private System.Windows.Forms.GroupBox html_selector;
        private System.Windows.Forms.Button html_prj_source_but;
        private System.Windows.Forms.TextBox html_prj_source;
        private System.Windows.Forms.GroupBox html_workpath;
        private System.Windows.Forms.Button html_prj_path_but;
        private System.Windows.Forms.TextBox html_prj_path;
        private System.Windows.Forms.FolderBrowserDialog choose_html_dir;
    }
}