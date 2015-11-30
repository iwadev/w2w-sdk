namespace W2W_SDK
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.file_list = new System.Windows.Forms.ToolStripMenuItem();
            this.new_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.open_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.save_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.saveas_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.latest_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.latest_proj_lbl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quit_but = new System.Windows.Forms.ToolStripMenuItem();
            this.build_list = new System.Windows.Forms.ToolStripMenuItem();
            this.compile_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.options_but = new System.Windows.Forms.ToolStripMenuItem();
            this.options_list = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_compile_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.opt_ui_but = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_update_but = new System.Windows.Forms.ToolStripMenuItem();
            this.help_list = new System.Windows.Forms.ToolStripMenuItem();
            this.about_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.docs_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.soft_site_but = new System.Windows.Forms.ToolStripMenuItem();
            this.dev_site_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.gh_but = new System.Windows.Forms.ToolStripMenuItem();
            this.state_bar = new System.Windows.Forms.StatusStrip();
            this.state_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.open_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.save_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.n_open_but = new System.Windows.Forms.ToolStripMenuItem();
            this.n_hide_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.n_quit_but = new System.Windows.Forms.ToolStripMenuItem();
            this.form_container = new System.Windows.Forms.Panel();
            this.project_tabs = new System.Windows.Forms.TabControl();
            this.project_options = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.soure_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.build_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menu_bar.SuspendLayout();
            this.state_bar.SuspendLayout();
            this.notify_menu.SuspendLayout();
            this.form_container.SuspendLayout();
            this.project_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_bar
            // 
            this.menu_bar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_list,
            this.build_list,
            this.options_list,
            this.help_list});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(923, 28);
            this.menu_bar.TabIndex = 0;
            this.menu_bar.Text = "menuStrip1";
            // 
            // file_list
            // 
            this.file_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_project_but,
            this.toolStripSeparator1,
            this.open_project_but,
            this.save_project_but,
            this.saveas_project_but,
            this.toolStripSeparator2,
            this.latest_project_but,
            this.toolStripSeparator3,
            this.quit_but});
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(57, 24);
            this.file_list.Text = "&Файл";
            // 
            // new_project_but
            // 
            this.new_project_but.Image = global::W2W_SDK.Properties.Resources._new;
            this.new_project_but.Name = "new_project_but";
            this.new_project_but.Size = new System.Drawing.Size(218, 24);
            this.new_project_but.Text = "&Новый проект";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // open_project_but
            // 
            this.open_project_but.Image = global::W2W_SDK.Properties.Resources.folder;
            this.open_project_but.Name = "open_project_but";
            this.open_project_but.Size = new System.Drawing.Size(218, 24);
            this.open_project_but.Text = "О&ткрыть проект";
            this.open_project_but.Click += new System.EventHandler(this.open_project_but_Click);
            // 
            // save_project_but
            // 
            this.save_project_but.Enabled = false;
            this.save_project_but.Image = global::W2W_SDK.Properties.Resources.save;
            this.save_project_but.Name = "save_project_but";
            this.save_project_but.Size = new System.Drawing.Size(218, 24);
            this.save_project_but.Text = "&Сохранить";
            // 
            // saveas_project_but
            // 
            this.saveas_project_but.Enabled = false;
            this.saveas_project_but.Image = global::W2W_SDK.Properties.Resources.save;
            this.saveas_project_but.Name = "saveas_project_but";
            this.saveas_project_but.Size = new System.Drawing.Size(218, 24);
            this.saveas_project_but.Text = "&Сохранить как";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // latest_project_but
            // 
            this.latest_project_but.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latest_proj_lbl,
            this.toolStripSeparator9});
            this.latest_project_but.Image = global::W2W_SDK.Properties.Resources.clock;
            this.latest_project_but.Name = "latest_project_but";
            this.latest_project_but.Size = new System.Drawing.Size(218, 24);
            this.latest_project_but.Text = "&Последние проекты";
            // 
            // latest_proj_lbl
            // 
            this.latest_proj_lbl.Enabled = false;
            this.latest_proj_lbl.Name = "latest_proj_lbl";
            this.latest_proj_lbl.Size = new System.Drawing.Size(218, 24);
            this.latest_proj_lbl.Text = "Последние проекты";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // quit_but
            // 
            this.quit_but.Image = global::W2W_SDK.Properties.Resources.quit;
            this.quit_but.Name = "quit_but";
            this.quit_but.Size = new System.Drawing.Size(218, 24);
            this.quit_but.Text = "&Выйти";
            this.quit_but.Click += new System.EventHandler(this.quit_but_Click);
            // 
            // build_list
            // 
            this.build_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compile_but,
            this.toolStripSeparator4,
            this.options_but});
            this.build_list.Name = "build_list";
            this.build_list.Size = new System.Drawing.Size(72, 24);
            this.build_list.Text = "&Сброка";
            // 
            // compile_but
            // 
            this.compile_but.Enabled = false;
            this.compile_but.Image = global::W2W_SDK.Properties.Resources.monitor;
            this.compile_but.Name = "compile_but";
            this.compile_but.Size = new System.Drawing.Size(189, 24);
            this.compile_but.Text = "&Сборка проекта";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // options_but
            // 
            this.options_but.Enabled = false;
            this.options_but.Image = global::W2W_SDK.Properties.Resources.prefs;
            this.options_but.Name = "options_but";
            this.options_but.Size = new System.Drawing.Size(189, 24);
            this.options_but.Text = "&Настройки";
            // 
            // options_list
            // 
            this.options_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_compile_but,
            this.toolStripSeparator5,
            this.opt_ui_but,
            this.opt_update_but});
            this.options_list.Name = "options_list";
            this.options_list.Size = new System.Drawing.Size(96, 24);
            this.options_list.Text = "&Настройки";
            // 
            // opt_compile_but
            // 
            this.opt_compile_but.Image = global::W2W_SDK.Properties.Resources.code;
            this.opt_compile_but.Name = "opt_compile_but";
            this.opt_compile_but.Size = new System.Drawing.Size(166, 24);
            this.opt_compile_but.Text = "&Компилятор";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // opt_ui_but
            // 
            this.opt_ui_but.Image = global::W2W_SDK.Properties.Resources.ui;
            this.opt_ui_but.Name = "opt_ui_but";
            this.opt_ui_but.Size = new System.Drawing.Size(166, 24);
            this.opt_ui_but.Text = "И&нтерфейс";
            // 
            // opt_update_but
            // 
            this.opt_update_but.Image = global::W2W_SDK.Properties.Resources.update;
            this.opt_update_but.Name = "opt_update_but";
            this.opt_update_but.Size = new System.Drawing.Size(166, 24);
            this.opt_update_but.Text = "О&бновление";
            // 
            // help_list
            // 
            this.help_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_but,
            this.toolStripSeparator6,
            this.docs_but,
            this.toolStripSeparator7,
            this.soft_site_but,
            this.dev_site_but,
            this.toolStripSeparator8,
            this.gh_but});
            this.help_list.Name = "help_list";
            this.help_list.Size = new System.Drawing.Size(81, 24);
            this.help_list.Text = "&Помощь";
            // 
            // about_but
            // 
            this.about_but.Image = global::W2W_SDK.Properties.Resources.info;
            this.about_but.Name = "about_but";
            this.about_but.Size = new System.Drawing.Size(211, 24);
            this.about_but.Text = "О &программе";
            this.about_but.Click += new System.EventHandler(this.about_but_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(208, 6);
            // 
            // docs_but
            // 
            this.docs_but.Image = global::W2W_SDK.Properties.Resources.help;
            this.docs_but.Name = "docs_but";
            this.docs_but.Size = new System.Drawing.Size(211, 24);
            this.docs_but.Text = "&Справка";
            this.docs_but.Click += new System.EventHandler(this.docs_but_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(208, 6);
            // 
            // soft_site_but
            // 
            this.soft_site_but.Image = global::W2W_SDK.Properties.Resources.web;
            this.soft_site_but.Name = "soft_site_but";
            this.soft_site_but.Size = new System.Drawing.Size(211, 24);
            this.soft_site_but.Text = "&Сайт продукта";
            this.soft_site_but.Click += new System.EventHandler(this.soft_site_but_Click);
            // 
            // dev_site_but
            // 
            this.dev_site_but.Image = global::W2W_SDK.Properties.Resources.web;
            this.dev_site_but.Name = "dev_site_but";
            this.dev_site_but.Size = new System.Drawing.Size(211, 24);
            this.dev_site_but.Text = "&Сайт разработчика";
            this.dev_site_but.Click += new System.EventHandler(this.dev_site_but_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(208, 6);
            // 
            // gh_but
            // 
            this.gh_but.Image = global::W2W_SDK.Properties.Resources.github;
            this.gh_but.Name = "gh_but";
            this.gh_but.Size = new System.Drawing.Size(211, 24);
            this.gh_but.Text = "&Git Hub";
            this.gh_but.Click += new System.EventHandler(this.gh_but_Click);
            // 
            // state_bar
            // 
            this.state_bar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.state_progress});
            this.state_bar.Location = new System.Drawing.Point(0, 622);
            this.state_bar.Name = "state_bar";
            this.state_bar.Size = new System.Drawing.Size(923, 22);
            this.state_bar.TabIndex = 1;
            this.state_bar.Text = "statusStrip1";
            // 
            // state_progress
            // 
            this.state_progress.Name = "state_progress";
            this.state_progress.Size = new System.Drawing.Size(100, 16);
            // 
            // open_project_dialog
            // 
            this.open_project_dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.open_project_dialog.ShowNewFolderButton = false;
            // 
            // save_project_dialog
            // 
            this.save_project_dialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.n_open_but,
            this.n_hide_but,
            this.toolStripSeparator10,
            this.n_quit_but});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(124, 76);
            // 
            // n_open_but
            // 
            this.n_open_but.Name = "n_open_but";
            this.n_open_but.Size = new System.Drawing.Size(123, 22);
            this.n_open_but.Text = "Открыть";
            this.n_open_but.Click += new System.EventHandler(this.n_open_but_Click);
            // 
            // n_hide_but
            // 
            this.n_hide_but.Name = "n_hide_but";
            this.n_hide_but.Size = new System.Drawing.Size(123, 22);
            this.n_hide_but.Text = "Свернуть";
            this.n_hide_but.Click += new System.EventHandler(this.n_hide_but_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(120, 6);
            // 
            // n_quit_but
            // 
            this.n_quit_but.Name = "n_quit_but";
            this.n_quit_but.Size = new System.Drawing.Size(123, 22);
            this.n_quit_but.Text = "Выход";
            this.n_quit_but.Click += new System.EventHandler(this.n_quit_but_Click);
            // 
            // form_container
            // 
            this.form_container.Controls.Add(this.project_tabs);
            this.form_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_container.Location = new System.Drawing.Point(0, 28);
            this.form_container.Name = "form_container";
            this.form_container.Size = new System.Drawing.Size(923, 594);
            this.form_container.TabIndex = 2;
            // 
            // project_tabs
            // 
            this.project_tabs.Controls.Add(this.project_options);
            this.project_tabs.Controls.Add(this.tabPage2);
            this.project_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_tabs.Location = new System.Drawing.Point(0, 0);
            this.project_tabs.Name = "project_tabs";
            this.project_tabs.SelectedIndex = 0;
            this.project_tabs.Size = new System.Drawing.Size(923, 594);
            this.project_tabs.TabIndex = 0;
            this.project_tabs.Visible = false;
            // 
            // project_options
            // 
            this.project_options.Location = new System.Drawing.Point(4, 22);
            this.project_options.Name = "project_options";
            this.project_options.Padding = new System.Windows.Forms.Padding(3);
            this.project_options.Size = new System.Drawing.Size(915, 568);
            this.project_options.TabIndex = 0;
            this.project_options.Text = "Настройки проекта";
            this.project_options.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Компиляция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(923, 644);
            this.Controls.Add(this.form_container);
            this.Controls.Add(this.state_bar);
            this.Controls.Add(this.menu_bar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::W2W_SDK.Properties.Settings.Default, "window_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::W2W_SDK.Properties.Settings.Default.window_location;
            this.MainMenuStrip = this.menu_bar;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Web2Win SDK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.state_bar.ResumeLayout(false);
            this.state_bar.PerformLayout();
            this.notify_menu.ResumeLayout(false);
            this.form_container.ResumeLayout(false);
            this.project_tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.StatusStrip state_bar;
        private System.Windows.Forms.ToolStripMenuItem file_list;
        private System.Windows.Forms.ToolStripMenuItem build_list;
        private System.Windows.Forms.ToolStripMenuItem options_list;
        private System.Windows.Forms.ToolStripMenuItem help_list;
        private System.Windows.Forms.ToolStripMenuItem new_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem open_project_but;
        private System.Windows.Forms.ToolStripMenuItem save_project_but;
        private System.Windows.Forms.ToolStripMenuItem saveas_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem latest_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quit_but;
        private System.Windows.Forms.ToolStripMenuItem compile_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem options_but;
        private System.Windows.Forms.ToolStripMenuItem opt_compile_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem opt_ui_but;
        private System.Windows.Forms.ToolStripMenuItem opt_update_but;
        private System.Windows.Forms.ToolStripMenuItem about_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem docs_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem soft_site_but;
        private System.Windows.Forms.ToolStripMenuItem dev_site_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem gh_but;
        private System.Windows.Forms.FolderBrowserDialog open_project_dialog;
        private System.Windows.Forms.FolderBrowserDialog save_project_dialog;
        private System.Windows.Forms.ToolStripMenuItem latest_proj_lbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripProgressBar state_progress;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel form_container;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem n_open_but;
        private System.Windows.Forms.ToolStripMenuItem n_hide_but;
        private System.Windows.Forms.ToolStripMenuItem n_quit_but;
        private System.Windows.Forms.TabControl project_tabs;
        private System.Windows.Forms.TabPage project_options;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.FolderBrowserDialog soure_project_dialog;
        private System.Windows.Forms.FolderBrowserDialog build_project_dialog;

    }
}

