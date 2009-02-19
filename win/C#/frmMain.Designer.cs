/*  frmMain.Designer.cs 
 	
 	   This file is part of the HandBrake source code.
 	   Homepage: <http://handbrake.fr>.
 	   It may be used under the terms of the GNU General Public License. */

namespace Handbrake
{
    partial class frmMain
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
            System.Windows.Forms.ContextMenuStrip notifyIconMenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.DVD_Save = new System.Windows.Forms.SaveFileDialog();
            this.File_Save = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.drop_chapterFinish = new System.Windows.Forms.ComboBox();
            this.drop_chapterStart = new System.Windows.Forms.ComboBox();
            this.drp_dvdtitle = new System.Windows.Forms.ComboBox();
            this.text_source = new System.Windows.Forms.TextBox();
            this.text_destination = new System.Windows.Forms.TextBox();
            this.drp_videoEncoder = new System.Windows.Forms.ComboBox();
            this.drp_audbit_1 = new System.Windows.Forms.ComboBox();
            this.drp_audsr_1 = new System.Windows.Forms.ComboBox();
            this.check_largeFile = new System.Windows.Forms.CheckBox();
            this.check_turbo = new System.Windows.Forms.CheckBox();
            this.drp_videoFramerate = new System.Windows.Forms.ComboBox();
            this.slider_videoQuality = new System.Windows.Forms.TrackBar();
            this.text_filesize = new System.Windows.Forms.TextBox();
            this.text_bitrate = new System.Windows.Forms.TextBox();
            this.drp_subtitle = new System.Windows.Forms.ComboBox();
            this.btn_setDefault = new System.Windows.Forms.Button();
            this.drp_audmix_1 = new System.Windows.Forms.ComboBox();
            this.text_height = new System.Windows.Forms.TextBox();
            this.text_width = new System.Windows.Forms.TextBox();
            this.check_optimiseMP4 = new System.Windows.Forms.CheckBox();
            this.check_iPodAtom = new System.Windows.Forms.CheckBox();
            this.data_chpt = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addPreset = new System.Windows.Forms.Button();
            this.btn_removePreset = new System.Windows.Forms.Button();
            this.drp_audenc_1 = new System.Windows.Forms.ComboBox();
            this.drop_format = new System.Windows.Forms.ComboBox();
            this.check_customCrop = new System.Windows.Forms.RadioButton();
            this.check_autoCrop = new System.Windows.Forms.RadioButton();
            this.lbl_src_res = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DVD_Open = new System.Windows.Forms.FolderBrowserDialog();
            this.File_Open = new System.Windows.Forms.OpenFileDialog();
            this.ISO_Open = new System.Windows.Forms.OpenFileDialog();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_killCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_encode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_encodeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_options = new System.Windows.Forms.ToolStripMenuItem();
            this.PresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_presetReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delete_preset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_new_preset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SelectDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_user_guide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_handbrake_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_handbrake_forums = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_UpdateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainMenu = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_qptest = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_source = new System.Windows.Forms.GroupBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.lv_audioList = new System.Windows.Forms.ListView();
            this.col_Source = new System.Windows.Forms.ColumnHeader();
            this.col_codec = new System.Windows.Forms.ColumnHeader();
            this.col_mixdown = new System.Windows.Forms.ColumnHeader();
            this.col_samplerate = new System.Windows.Forms.ColumnHeader();
            this.col_bitrate = new System.Windows.Forms.ColumnHeader();
            this.col_drc = new System.Windows.Forms.ColumnHeader();
            this.audioMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.audioList_moveup = new System.Windows.Forms.ToolStripMenuItem();
            this.audioList_movedown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.audioList_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioMenuRowHeightHack = new System.Windows.Forms.ImageList(this.components);
            this.btn_RemoveAudioTrack = new System.Windows.Forms.Button();
            this.btn_addAudioTrack = new System.Windows.Forms.Button();
            this.lbl_drc = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_drc = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.check_forced = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.drp_track1Audio = new System.Windows.Forms.ComboBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.radio_cq = new System.Windows.Forms.RadioButton();
            this.radio_avgBitrate = new System.Windows.Forms.RadioButton();
            this.radio_targetFilesize = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.check_2PassEncode = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SliderValue = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.check_grayscale = new System.Windows.Forms.CheckBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.drp_anamorphic = new System.Windows.Forms.ComboBox();
            this.text_bottom = new System.Windows.Forms.NumericUpDown();
            this.text_top = new System.Windows.Forms.NumericUpDown();
            this.text_left = new System.Windows.Forms.NumericUpDown();
            this.text_right = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.lbl_Aspect = new System.Windows.Forms.Label();
            this.Label91 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.slider_deblock = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_deblockVal = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Check_ChapterMarkers = new System.Windows.Forms.CheckBox();
            this.tabs_panel = new System.Windows.Forms.TabControl();
            this.tab_Filters = new System.Windows.Forms.TabPage();
            this.tab_chapters = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.h264Tab = new System.Windows.Forms.TabPage();
            this.tab_query = new System.Windows.Forms.TabPage();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.btn_generate_Query = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.rtf_query = new System.Windows.Forms.RichTextBox();
            this.groupBox_dest = new System.Windows.Forms.GroupBox();
            this.btn_destBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_presets = new System.Windows.Forms.TreeView();
            this.presets_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnu_expandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnu_collapse = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.pmnu_saveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_source = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_file_source = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_dvd_source = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_dvd_drive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_start = new System.Windows.Forms.ToolStripButton();
            this.btn_add2Queue = new System.Windows.Forms.ToolStripButton();
            this.btn_showQueue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_preview = new System.Windows.Forms.ToolStripButton();
            this.btn_ActivityWindow = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lbl_encode = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_max = new System.Windows.Forms.Label();
            this.ctl_deinterlace = new Handbrake.Deinterlace();
            this.ctl_denoise = new Handbrake.Denoise();
            this.ctl_decomb = new Handbrake.Decomb();
            this.ctl_detelecine = new Handbrake.Detelecine();
            this.x264Panel = new Handbrake.Controls.x264Panel();
            notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            notifyIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_videoQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chpt)).BeginInit();
            this.frmMainMenu.SuspendLayout();
            this.gb_source.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.audioMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_drc)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_deblock)).BeginInit();
            this.tabs_panel.SuspendLayout();
            this.tab_Filters.SuspendLayout();
            this.tab_chapters.SuspendLayout();
            this.h264Tab.SuspendLayout();
            this.tab_query.SuspendLayout();
            this.groupBox_dest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.presets_menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconMenu
            // 
            notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_restore});
            notifyIconMenu.Name = "notifyIconMenu";
            notifyIconMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            notifyIconMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // btn_restore
            // 
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(128, 22);
            this.btn_restore.Text = "Restore";
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // DVD_Save
            // 
            this.DVD_Save.Filter = "mp4|*.mp4|m4v|*.m4v|mkv|*.mkv|avi|*.avi|ogm|*.ogm";
            this.DVD_Save.SupportMultiDottedExtensions = true;
            // 
            // File_Save
            // 
            this.File_Save.DefaultExt = "hb";
            this.File_Save.Filter = "hb|*.hb";
            // 
            // ToolTip
            // 
            this.ToolTip.Active = false;
            this.ToolTip.AutomaticDelay = 1000;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Tooltip";
            // 
            // drop_chapterFinish
            // 
            this.drop_chapterFinish.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_chapterFinish.FormattingEnabled = true;
            this.drop_chapterFinish.Location = new System.Drawing.Point(427, 52);
            this.drop_chapterFinish.Name = "drop_chapterFinish";
            this.drop_chapterFinish.Size = new System.Drawing.Size(69, 21);
            this.drop_chapterFinish.TabIndex = 10;
            this.drop_chapterFinish.Text = "Auto";
            this.ToolTip.SetToolTip(this.drop_chapterFinish, "Select the chapter range you would like to enocde. (default: All Chapters)");
            this.drop_chapterFinish.SelectedIndexChanged += new System.EventHandler(this.drop_chapterFinish_SelectedIndexChanged);
            // 
            // drop_chapterStart
            // 
            this.drop_chapterStart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_chapterStart.FormattingEnabled = true;
            this.drop_chapterStart.Location = new System.Drawing.Point(295, 52);
            this.drop_chapterStart.Name = "drop_chapterStart";
            this.drop_chapterStart.Size = new System.Drawing.Size(69, 21);
            this.drop_chapterStart.TabIndex = 9;
            this.drop_chapterStart.Text = "Auto";
            this.ToolTip.SetToolTip(this.drop_chapterStart, "Select the chapter range you would like to enocde. (default: All Chapters)");
            this.drop_chapterStart.SelectedIndexChanged += new System.EventHandler(this.drop_chapterStart_SelectedIndexChanged);
            // 
            // drp_dvdtitle
            // 
            this.drp_dvdtitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_dvdtitle.FormattingEnabled = true;
            this.drp_dvdtitle.Items.AddRange(new object[] {
            "Automatic"});
            this.drp_dvdtitle.Location = new System.Drawing.Point(99, 52);
            this.drp_dvdtitle.Name = "drp_dvdtitle";
            this.drp_dvdtitle.Size = new System.Drawing.Size(119, 21);
            this.drp_dvdtitle.TabIndex = 7;
            this.drp_dvdtitle.Text = "Automatic";
            this.ToolTip.SetToolTip(this.drp_dvdtitle, "Select the title you wish to encode.\r\nThe longest title is selected by default af" +
                    "ter you have scanned a source.");
            this.drp_dvdtitle.SelectedIndexChanged += new System.EventHandler(this.drp_dvdtitle_SelectedIndexChanged);
            this.drp_dvdtitle.Click += new System.EventHandler(this.drp_dvdtitle_Click);
            // 
            // text_source
            // 
            this.text_source.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_source.Location = new System.Drawing.Point(99, 19);
            this.text_source.Name = "text_source";
            this.text_source.ReadOnly = true;
            this.text_source.Size = new System.Drawing.Size(584, 21);
            this.text_source.TabIndex = 1;
            this.text_source.Text = "Click \'Source\' to continue";
            this.ToolTip.SetToolTip(this.text_source, "Location of the source input file, folder or dvd.");
            // 
            // text_destination
            // 
            this.text_destination.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_destination.Location = new System.Drawing.Point(99, 19);
            this.text_destination.Name = "text_destination";
            this.text_destination.Size = new System.Drawing.Size(503, 21);
            this.text_destination.TabIndex = 1;
            this.ToolTip.SetToolTip(this.text_destination, "Location where the encoded file will be saved.");
            this.text_destination.TextChanged += new System.EventHandler(this.text_destination_TextChanged);
            // 
            // drp_videoEncoder
            // 
            this.drp_videoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drp_videoEncoder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_videoEncoder.FormattingEnabled = true;
            this.drp_videoEncoder.Items.AddRange(new object[] {
            "MPEG-4 (FFmpeg)",
            "MPEG-4 (XviD)",
            "H.264 (x264)",
            "VP3 (Theora)"});
            this.drp_videoEncoder.Location = new System.Drawing.Point(125, 35);
            this.drp_videoEncoder.Name = "drp_videoEncoder";
            this.drp_videoEncoder.Size = new System.Drawing.Size(126, 21);
            this.drp_videoEncoder.TabIndex = 1;
            this.ToolTip.SetToolTip(this.drp_videoEncoder, "Select a video encoder");
            this.drp_videoEncoder.SelectedIndexChanged += new System.EventHandler(this.drp_videoEncoder_SelectedIndexChanged);
            // 
            // drp_audbit_1
            // 
            this.drp_audbit_1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_audbit_1.FormattingEnabled = true;
            this.drp_audbit_1.Items.AddRange(new object[] {
            "32",
            "40",
            "48",
            "56",
            "64",
            "80",
            "86",
            "112",
            "128",
            "160"});
            this.drp_audbit_1.Location = new System.Drawing.Point(526, 47);
            this.drp_audbit_1.Name = "drp_audbit_1";
            this.drp_audbit_1.Size = new System.Drawing.Size(70, 20);
            this.drp_audbit_1.TabIndex = 11;
            this.drp_audbit_1.Text = "160";
            this.ToolTip.SetToolTip(this.drp_audbit_1, "Set the Audio Bit-Rate");
            this.drp_audbit_1.SelectedIndexChanged += new System.EventHandler(this.drp_audbit_1_SelectedIndexChanged);
            // 
            // drp_audsr_1
            // 
            this.drp_audsr_1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_audsr_1.FormattingEnabled = true;
            this.drp_audsr_1.Items.AddRange(new object[] {
            "Auto",
            "48",
            "44.1",
            "32",
            "24",
            "22.05"});
            this.drp_audsr_1.Location = new System.Drawing.Point(468, 47);
            this.drp_audsr_1.Name = "drp_audsr_1";
            this.drp_audsr_1.Size = new System.Drawing.Size(55, 20);
            this.drp_audsr_1.TabIndex = 9;
            this.drp_audsr_1.Text = "Auto";
            this.ToolTip.SetToolTip(this.drp_audsr_1, "Set the Audio Sample Rate");
            this.drp_audsr_1.SelectedIndexChanged += new System.EventHandler(this.drp_audsr_1_SelectedIndexChanged);
            // 
            // check_largeFile
            // 
            this.check_largeFile.AutoSize = true;
            this.check_largeFile.BackColor = System.Drawing.Color.Transparent;
            this.check_largeFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_largeFile.Location = new System.Drawing.Point(193, 22);
            this.check_largeFile.Name = "check_largeFile";
            this.check_largeFile.Size = new System.Drawing.Size(105, 17);
            this.check_largeFile.TabIndex = 4;
            this.check_largeFile.Text = "Large file size";
            this.ToolTip.SetToolTip(this.check_largeFile, "Caution: This option will likely break device compatibility with all but the Appl" +
                    "eTV Take 2.\r\nChecking this box enables a 64bit mp4 file which can be over 4GB.");
            this.check_largeFile.UseVisualStyleBackColor = false;
            // 
            // check_turbo
            // 
            this.check_turbo.AutoSize = true;
            this.check_turbo.BackColor = System.Drawing.Color.Transparent;
            this.check_turbo.Enabled = false;
            this.check_turbo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_turbo.Location = new System.Drawing.Point(146, 123);
            this.check_turbo.Name = "check_turbo";
            this.check_turbo.Size = new System.Drawing.Size(115, 17);
            this.check_turbo.TabIndex = 7;
            this.check_turbo.Text = "Turbo first Pass";
            this.ToolTip.SetToolTip(this.check_turbo, "Makes the first pass of a 2 pass encode faster.");
            this.check_turbo.UseVisualStyleBackColor = false;
            // 
            // drp_videoFramerate
            // 
            this.drp_videoFramerate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_videoFramerate.FormattingEnabled = true;
            this.drp_videoFramerate.Items.AddRange(new object[] {
            "Same as source",
            "5",
            "10",
            "12",
            "15",
            "23.976",
            "24",
            "25",
            "29.97"});
            this.drp_videoFramerate.Location = new System.Drawing.Point(125, 68);
            this.drp_videoFramerate.Name = "drp_videoFramerate";
            this.drp_videoFramerate.Size = new System.Drawing.Size(126, 21);
            this.drp_videoFramerate.TabIndex = 2;
            this.drp_videoFramerate.Text = "Same as source";
            this.ToolTip.SetToolTip(this.drp_videoFramerate, "Can be left to \"Same as source\" in most cases.");
            // 
            // slider_videoQuality
            // 
            this.slider_videoQuality.Enabled = false;
            this.slider_videoQuality.Location = new System.Drawing.Point(347, 120);
            this.slider_videoQuality.Maximum = 100;
            this.slider_videoQuality.Name = "slider_videoQuality";
            this.slider_videoQuality.Size = new System.Drawing.Size(322, 42);
            this.slider_videoQuality.TabIndex = 14;
            this.slider_videoQuality.TickFrequency = 17;
            this.ToolTip.SetToolTip(this.slider_videoQuality, "Set the quality level of the video. (Around 70% is fine for most)");
            this.slider_videoQuality.ValueChanged += new System.EventHandler(this.slider_videoQuality_Scroll);
            // 
            // text_filesize
            // 
            this.text_filesize.Enabled = false;
            this.text_filesize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filesize.Location = new System.Drawing.Point(482, 36);
            this.text_filesize.Name = "text_filesize";
            this.text_filesize.Size = new System.Drawing.Size(81, 21);
            this.text_filesize.TabIndex = 12;
            this.ToolTip.SetToolTip(this.text_filesize, "Set the file size you wish the encoded file to be.");
            // 
            // text_bitrate
            // 
            this.text_bitrate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_bitrate.Location = new System.Drawing.Point(482, 63);
            this.text_bitrate.Name = "text_bitrate";
            this.text_bitrate.Size = new System.Drawing.Size(81, 21);
            this.text_bitrate.TabIndex = 10;
            this.ToolTip.SetToolTip(this.text_bitrate, "Set the bitrate of the video");
            // 
            // drp_subtitle
            // 
            this.drp_subtitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_subtitle.FormattingEnabled = true;
            this.drp_subtitle.Items.AddRange(new object[] {
            "None",
            "Autoselect"});
            this.drp_subtitle.Location = new System.Drawing.Point(79, 285);
            this.drp_subtitle.Name = "drp_subtitle";
            this.drp_subtitle.Size = new System.Drawing.Size(138, 21);
            this.drp_subtitle.TabIndex = 43;
            this.drp_subtitle.Text = "None";
            this.ToolTip.SetToolTip(this.drp_subtitle, resources.GetString("drp_subtitle.ToolTip"));
            this.drp_subtitle.SelectedIndexChanged += new System.EventHandler(this.drp_subtitle_SelectedIndexChanged);
            // 
            // btn_setDefault
            // 
            this.btn_setDefault.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_setDefault.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_setDefault.Location = new System.Drawing.Point(135, 8);
            this.btn_setDefault.Name = "btn_setDefault";
            this.btn_setDefault.Size = new System.Drawing.Size(101, 22);
            this.btn_setDefault.TabIndex = 1;
            this.btn_setDefault.TabStop = false;
            this.btn_setDefault.Text = "Set Default";
            this.ToolTip.SetToolTip(this.btn_setDefault, "Set current settings as program defaults.\r\nRequires option to be enabled in Tools" +
                    " > Options");
            this.btn_setDefault.UseVisualStyleBackColor = true;
            this.btn_setDefault.Click += new System.EventHandler(this.btn_setDefault_Click);
            // 
            // drp_audmix_1
            // 
            this.drp_audmix_1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_audmix_1.FormattingEnabled = true;
            this.drp_audmix_1.Items.AddRange(new object[] {
            "Automatic",
            "Mono",
            "Stereo",
            "Dolby Surround",
            "Dolby Pro Logic II",
            "6 Channel Discrete"});
            this.drp_audmix_1.Location = new System.Drawing.Point(333, 47);
            this.drp_audmix_1.Name = "drp_audmix_1";
            this.drp_audmix_1.Size = new System.Drawing.Size(129, 20);
            this.drp_audmix_1.TabIndex = 7;
            this.drp_audmix_1.Text = "Automatic";
            this.ToolTip.SetToolTip(this.drp_audmix_1, "Please note: Some options require a 5.1 audio channel to be selected");
            this.drp_audmix_1.SelectedIndexChanged += new System.EventHandler(this.drp_audmix_1_SelectedIndexChanged);
            // 
            // text_height
            // 
            this.text_height.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_height.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_height.Location = new System.Drawing.Point(498, 81);
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(64, 21);
            this.text_height.TabIndex = 19;
            this.ToolTip.SetToolTip(this.text_height, "Video Resolution (Height)\r\nCan only be altered when Anamorphic is set to \"None\"");
            this.text_height.TextChanged += new System.EventHandler(this.text_height_TextChanged);
            // 
            // text_width
            // 
            this.text_width.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_width.Location = new System.Drawing.Point(407, 81);
            this.text_width.Name = "text_width";
            this.text_width.Size = new System.Drawing.Size(64, 21);
            this.text_width.TabIndex = 17;
            this.ToolTip.SetToolTip(this.text_width, "Video Resolution (Width)\r\nCan only be altered when Anamorphic is set to \"None\" or" +
                    " \"Loose\"");
            this.text_width.TextChanged += new System.EventHandler(this.text_width_TextChanged);
            // 
            // check_optimiseMP4
            // 
            this.check_optimiseMP4.AutoSize = true;
            this.check_optimiseMP4.BackColor = System.Drawing.Color.Transparent;
            this.check_optimiseMP4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_optimiseMP4.Location = new System.Drawing.Point(304, 22);
            this.check_optimiseMP4.Name = "check_optimiseMP4";
            this.check_optimiseMP4.Size = new System.Drawing.Size(110, 17);
            this.check_optimiseMP4.TabIndex = 25;
            this.check_optimiseMP4.Text = "Web optimized";
            this.ToolTip.SetToolTip(this.check_optimiseMP4, "MP4 files can be optimized for progressive downloads over the Web,\r\nbut note that" +
                    " QuickTime can only read the files as long as the file extension is .mp4\r\nCan on" +
                    "ly be used with H.264 ");
            this.check_optimiseMP4.UseVisualStyleBackColor = false;
            // 
            // check_iPodAtom
            // 
            this.check_iPodAtom.AutoSize = true;
            this.check_iPodAtom.BackColor = System.Drawing.Color.Transparent;
            this.check_iPodAtom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_iPodAtom.Location = new System.Drawing.Point(420, 22);
            this.check_iPodAtom.Name = "check_iPodAtom";
            this.check_iPodAtom.Size = new System.Drawing.Size(117, 17);
            this.check_iPodAtom.TabIndex = 26;
            this.check_iPodAtom.Text = "iPod 5G support";
            this.ToolTip.SetToolTip(this.check_iPodAtom, "Support for legacy 5th Generation iPods.\r\nEncodes will not sync if this option is" +
                    " not enabled for H.264 encodes.");
            this.check_iPodAtom.UseVisualStyleBackColor = false;
            // 
            // data_chpt
            // 
            this.data_chpt.AllowUserToAddRows = false;
            this.data_chpt.AllowUserToDeleteRows = false;
            this.data_chpt.AllowUserToResizeRows = false;
            this.data_chpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_chpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name});
            this.data_chpt.Location = new System.Drawing.Point(16, 55);
            this.data_chpt.MultiSelect = false;
            this.data_chpt.Name = "data_chpt";
            this.data_chpt.RowHeadersVisible = false;
            this.data_chpt.Size = new System.Drawing.Size(684, 234);
            this.data_chpt.TabIndex = 3;
            this.ToolTip.SetToolTip(this.data_chpt, resources.GetString("data_chpt.ToolTip"));
            // 
            // number
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.number.DefaultCellStyle = dataGridViewCellStyle2;
            this.number.HeaderText = "Chapter Number";
            this.number.MaxInputLength = 3;
            this.number.Name = "number";
            this.number.Width = 165;
            // 
            // name
            // 
            this.name.HeaderText = "Chapter Name";
            this.name.Name = "name";
            this.name.Width = 460;
            // 
            // btn_addPreset
            // 
            this.btn_addPreset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addPreset.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addPreset.Location = new System.Drawing.Point(3, 8);
            this.btn_addPreset.Name = "btn_addPreset";
            this.btn_addPreset.Size = new System.Drawing.Size(49, 22);
            this.btn_addPreset.TabIndex = 3;
            this.btn_addPreset.TabStop = false;
            this.btn_addPreset.Text = "Add";
            this.ToolTip.SetToolTip(this.btn_addPreset, "Add a preset to the preset panel");
            this.btn_addPreset.UseVisualStyleBackColor = true;
            this.btn_addPreset.Click += new System.EventHandler(this.btn_addPreset_Click);
            // 
            // btn_removePreset
            // 
            this.btn_removePreset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_removePreset.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removePreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_removePreset.Location = new System.Drawing.Point(58, 8);
            this.btn_removePreset.Name = "btn_removePreset";
            this.btn_removePreset.Size = new System.Drawing.Size(71, 22);
            this.btn_removePreset.TabIndex = 4;
            this.btn_removePreset.TabStop = false;
            this.btn_removePreset.Text = "Remove";
            this.ToolTip.SetToolTip(this.btn_removePreset, "Remove a preset from the panel above.");
            this.btn_removePreset.UseVisualStyleBackColor = true;
            this.btn_removePreset.Click += new System.EventHandler(this.btn_removePreset_Click);
            // 
            // drp_audenc_1
            // 
            this.drp_audenc_1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_audenc_1.FormattingEnabled = true;
            this.drp_audenc_1.Items.AddRange(new object[] {
            "AAC",
            "MP3",
            "Vorbis",
            "AC3"});
            this.drp_audenc_1.Location = new System.Drawing.Point(216, 47);
            this.drp_audenc_1.Name = "drp_audenc_1";
            this.drp_audenc_1.Size = new System.Drawing.Size(111, 20);
            this.drp_audenc_1.TabIndex = 5;
            this.drp_audenc_1.Text = "AAC";
            this.ToolTip.SetToolTip(this.drp_audenc_1, "Select an audio encoder.");
            this.drp_audenc_1.SelectedIndexChanged += new System.EventHandler(this.drp_audenc_1_SelectedIndexChanged);
            // 
            // drop_format
            // 
            this.drop_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_format.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_format.FormattingEnabled = true;
            this.drop_format.Items.AddRange(new object[] {
            "MP4 File",
            "M4V File",
            "MKV File",
            "AVI File",
            "OGM File"});
            this.drop_format.Location = new System.Drawing.Point(75, 19);
            this.drop_format.Name = "drop_format";
            this.drop_format.Size = new System.Drawing.Size(106, 21);
            this.drop_format.TabIndex = 28;
            this.ToolTip.SetToolTip(this.drop_format, "Select the file container format.");
            this.drop_format.SelectedIndexChanged += new System.EventHandler(this.drop_format_SelectedIndexChanged);
            // 
            // check_customCrop
            // 
            this.check_customCrop.AutoSize = true;
            this.check_customCrop.Location = new System.Drawing.Point(16, 58);
            this.check_customCrop.Name = "check_customCrop";
            this.check_customCrop.Size = new System.Drawing.Size(74, 17);
            this.check_customCrop.TabIndex = 34;
            this.check_customCrop.Text = "Custom:";
            this.ToolTip.SetToolTip(this.check_customCrop, "Set some custom cropping values.");
            this.check_customCrop.UseVisualStyleBackColor = true;
            this.check_customCrop.CheckedChanged += new System.EventHandler(this.check_customCrop_CheckedChanged);
            // 
            // check_autoCrop
            // 
            this.check_autoCrop.AutoSize = true;
            this.check_autoCrop.Checked = true;
            this.check_autoCrop.Location = new System.Drawing.Point(16, 34);
            this.check_autoCrop.Name = "check_autoCrop";
            this.check_autoCrop.Size = new System.Drawing.Size(82, 17);
            this.check_autoCrop.TabIndex = 33;
            this.check_autoCrop.TabStop = true;
            this.check_autoCrop.Text = "Automatic";
            this.ToolTip.SetToolTip(this.check_autoCrop, "Automatically set cropping values.");
            this.check_autoCrop.UseVisualStyleBackColor = true;
            this.check_autoCrop.CheckedChanged += new System.EventHandler(this.check_autoCrop_CheckedChanged);
            // 
            // lbl_src_res
            // 
            this.lbl_src_res.AutoSize = true;
            this.lbl_src_res.BackColor = System.Drawing.Color.Transparent;
            this.lbl_src_res.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_src_res.Location = new System.Drawing.Point(405, 34);
            this.lbl_src_res.Name = "lbl_src_res";
            this.lbl_src_res.Size = new System.Drawing.Size(72, 12);
            this.lbl_src_res.TabIndex = 13;
            this.lbl_src_res.Text = "Select a Title";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_duration.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(569, 56);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(72, 12);
            this.lbl_duration.TabIndex = 43;
            this.lbl_duration.Text = "Select a Title";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.BackColor = System.Drawing.Color.Transparent;
            this.label_duration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration.Location = new System.Drawing.Point(502, 55);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(61, 13);
            this.label_duration.TabIndex = 42;
            this.label_duration.Text = "Duration:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(311, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Source:";
            // 
            // DVD_Open
            // 
            this.DVD_Open.Description = "Select the \"VIDEO_TS\" folder from your DVD Drive.";
            // 
            // File_Open
            // 
            this.File_Open.DefaultExt = "hb";
            this.File_Open.Filter = "hb|*.hb";
            // 
            // ISO_Open
            // 
            this.ISO_Open.DefaultExt = "ISO";
            this.ISO_Open.Filter = "All Files|*.*";
            this.ISO_Open.RestoreDirectory = true;
            this.ISO_Open.SupportMultiDottedExtensions = true;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_killCLI,
            this.mnu_exit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // mnu_killCLI
            // 
            this.mnu_killCLI.Name = "mnu_killCLI";
            this.mnu_killCLI.Size = new System.Drawing.Size(156, 22);
            this.mnu_killCLI.Text = "Cancel Scan";
            this.mnu_killCLI.Visible = false;
            this.mnu_killCLI.Click += new System.EventHandler(this.mnu_killCLI_Click);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(156, 22);
            this.mnu_exit.Text = "E&xit";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // mnu_open3
            // 
            this.mnu_open3.Name = "mnu_open3";
            this.mnu_open3.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_encode,
            this.mnu_encodeLog,
            this.ToolStripSeparator5,
            this.mnu_options});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // mnu_encode
            // 
            this.mnu_encode.Image = global::Handbrake.Properties.Resources.Queue_Small;
            this.mnu_encode.Name = "mnu_encode";
            this.mnu_encode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnu_encode.Size = new System.Drawing.Size(203, 22);
            this.mnu_encode.Text = "Show Queue";
            this.mnu_encode.Click += new System.EventHandler(this.mnu_encode_Click);
            // 
            // mnu_encodeLog
            // 
            this.mnu_encodeLog.Image = global::Handbrake.Properties.Resources.ActivityWindow_small;
            this.mnu_encodeLog.Name = "mnu_encodeLog";
            this.mnu_encodeLog.Size = new System.Drawing.Size(203, 22);
            this.mnu_encodeLog.Text = "Activity Window";
            this.mnu_encodeLog.Click += new System.EventHandler(this.mnu_encodeLog_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // mnu_options
            // 
            this.mnu_options.Image = global::Handbrake.Properties.Resources.Pref_Small;
            this.mnu_options.Name = "mnu_options";
            this.mnu_options.Size = new System.Drawing.Size(203, 22);
            this.mnu_options.Text = "Options";
            this.mnu_options.Click += new System.EventHandler(this.mnu_options_Click);
            // 
            // PresetsToolStripMenuItem
            // 
            this.PresetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_presetReset,
            this.mnu_delete_preset,
            this.toolStripSeparator7,
            this.btn_new_preset,
            this.mnu_SelectDefault});
            this.PresetsToolStripMenuItem.Name = "PresetsToolStripMenuItem";
            this.PresetsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.PresetsToolStripMenuItem.Text = "&Presets";
            // 
            // mnu_presetReset
            // 
            this.mnu_presetReset.Name = "mnu_presetReset";
            this.mnu_presetReset.Size = new System.Drawing.Size(215, 22);
            this.mnu_presetReset.Text = "Update Built-in Presets";
            this.mnu_presetReset.ToolTipText = "Resets all presets.";
            this.mnu_presetReset.Click += new System.EventHandler(this.mnu_presetReset_Click);
            // 
            // mnu_delete_preset
            // 
            this.mnu_delete_preset.Name = "mnu_delete_preset";
            this.mnu_delete_preset.Size = new System.Drawing.Size(215, 22);
            this.mnu_delete_preset.Text = "Delete Built-in Presets";
            this.mnu_delete_preset.Click += new System.EventHandler(this.mnu_delete_preset_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(212, 6);
            // 
            // btn_new_preset
            // 
            this.btn_new_preset.Name = "btn_new_preset";
            this.btn_new_preset.Size = new System.Drawing.Size(215, 22);
            this.btn_new_preset.Text = "New Preset";
            this.btn_new_preset.Click += new System.EventHandler(this.btn_new_preset_Click);
            // 
            // mnu_SelectDefault
            // 
            this.mnu_SelectDefault.Name = "mnu_SelectDefault";
            this.mnu_SelectDefault.Size = new System.Drawing.Size(215, 22);
            this.mnu_SelectDefault.Text = "Select Default Preset";
            this.mnu_SelectDefault.ToolTipText = "Select HandBrake\'s default preset";
            this.mnu_SelectDefault.Click += new System.EventHandler(this.mnu_SelectDefault_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_user_guide,
            this.mnu_handbrake_home,
            this.mnu_handbrake_forums,
            this.ToolStripSeparator3,
            this.mnu_UpdateCheck,
            this.toolStripSeparator6,
            this.mnu_about});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // mnu_user_guide
            // 
            this.mnu_user_guide.Image = global::Handbrake.Properties.Resources.Help16;
            this.mnu_user_guide.Name = "mnu_user_guide";
            this.mnu_user_guide.Size = new System.Drawing.Size(215, 22);
            this.mnu_user_guide.Text = "HandBrake User Guide";
            this.mnu_user_guide.Click += new System.EventHandler(this.mnu_user_guide_Click);
            // 
            // mnu_handbrake_home
            // 
            this.mnu_handbrake_home.Image = global::Handbrake.Properties.Resources.info16;
            this.mnu_handbrake_home.Name = "mnu_handbrake_home";
            this.mnu_handbrake_home.Size = new System.Drawing.Size(215, 22);
            this.mnu_handbrake_home.Text = "HandBrake Homepage";
            this.mnu_handbrake_home.Click += new System.EventHandler(this.mnu_handbrake_home_Click);
            // 
            // mnu_handbrake_forums
            // 
            this.mnu_handbrake_forums.Name = "mnu_handbrake_forums";
            this.mnu_handbrake_forums.Size = new System.Drawing.Size(215, 22);
            this.mnu_handbrake_forums.Text = "HandBrake Forums";
            this.mnu_handbrake_forums.Click += new System.EventHandler(this.mnu_handbrake_forums_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // mnu_UpdateCheck
            // 
            this.mnu_UpdateCheck.Name = "mnu_UpdateCheck";
            this.mnu_UpdateCheck.Size = new System.Drawing.Size(215, 22);
            this.mnu_UpdateCheck.Text = "Check for Updates";
            this.mnu_UpdateCheck.Click += new System.EventHandler(this.mnu_UpdateCheck_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(212, 6);
            // 
            // mnu_about
            // 
            this.mnu_about.Image = global::Handbrake.Properties.Resources.hb16;
            this.mnu_about.Name = "mnu_about";
            this.mnu_about.Size = new System.Drawing.Size(215, 22);
            this.mnu_about.Text = "About...";
            this.mnu_about.Click += new System.EventHandler(this.mnu_about_Click);
            // 
            // frmMainMenu
            // 
            this.frmMainMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.frmMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.PresetsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.frmMainMenu.Location = new System.Drawing.Point(0, 0);
            this.frmMainMenu.Name = "frmMainMenu";
            this.frmMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.frmMainMenu.Size = new System.Drawing.Size(1004, 24);
            this.frmMainMenu.TabIndex = 0;
            this.frmMainMenu.Text = "MenuStrip";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_qptest});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // mnu_qptest
            // 
            this.mnu_qptest.Name = "mnu_qptest";
            this.mnu_qptest.Size = new System.Drawing.Size(201, 22);
            this.mnu_qptest.Text = "Query Parser Tester";
            this.mnu_qptest.Click += new System.EventHandler(this.mnu_qptest_Click);
            // 
            // gb_source
            // 
            this.gb_source.Controls.Add(this.lbl_duration);
            this.gb_source.Controls.Add(this.label_duration);
            this.gb_source.Controls.Add(this.Label13);
            this.gb_source.Controls.Add(this.drop_chapterFinish);
            this.gb_source.Controls.Add(this.drop_chapterStart);
            this.gb_source.Controls.Add(this.drp_dvdtitle);
            this.gb_source.Controls.Add(this.Label17);
            this.gb_source.Controls.Add(this.text_source);
            this.gb_source.Controls.Add(this.Label9);
            this.gb_source.Controls.Add(this.Label10);
            this.gb_source.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_source.ForeColor = System.Drawing.Color.Black;
            this.gb_source.Location = new System.Drawing.Point(9, 70);
            this.gb_source.Name = "gb_source";
            this.gb_source.Size = new System.Drawing.Size(732, 87);
            this.gb_source.TabIndex = 2;
            this.gb_source.TabStop = false;
            this.gb_source.Text = "Source";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(370, 55);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(51, 13);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "through";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(17, 22);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(52, 13);
            this.Label17.TabIndex = 0;
            this.Label17.Text = "Source:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(225, 55);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 13);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "Chapters:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(17, 55);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(36, 13);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Title:";
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.drop_format);
            this.groupBox_output.Controls.Add(this.label5);
            this.groupBox_output.Controls.Add(this.check_largeFile);
            this.groupBox_output.Controls.Add(this.check_iPodAtom);
            this.groupBox_output.Controls.Add(this.check_optimiseMP4);
            this.groupBox_output.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_output.ForeColor = System.Drawing.Color.Black;
            this.groupBox_output.Location = new System.Drawing.Point(9, 214);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(732, 50);
            this.groupBox_output.TabIndex = 4;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Output Settings (Preset: None)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Format:";
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.ForeColor = System.Drawing.Color.Black;
            this.Label47.Location = new System.Drawing.Point(13, 39);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(84, 13);
            this.Label47.TabIndex = 0;
            this.Label47.Text = "Video Codec:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(17, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(31, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "File:";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Transparent;
            this.TabPage2.Controls.Add(this.lv_audioList);
            this.TabPage2.Controls.Add(this.btn_RemoveAudioTrack);
            this.TabPage2.Controls.Add(this.btn_addAudioTrack);
            this.TabPage2.Controls.Add(this.lbl_drc);
            this.TabPage2.Controls.Add(this.label16);
            this.TabPage2.Controls.Add(this.tb_drc);
            this.TabPage2.Controls.Add(this.groupBox5);
            this.TabPage2.Controls.Add(this.groupBox3);
            this.TabPage2.Controls.Add(this.label68);
            this.TabPage2.Controls.Add(this.label67);
            this.TabPage2.Controls.Add(this.label66);
            this.TabPage2.Controls.Add(this.label65);
            this.TabPage2.Controls.Add(this.label14);
            this.TabPage2.Controls.Add(this.drp_audenc_1);
            this.TabPage2.Controls.Add(this.check_forced);
            this.TabPage2.Controls.Add(this.label27);
            this.TabPage2.Controls.Add(this.drp_subtitle);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.Controls.Add(this.Label20);
            this.TabPage2.Controls.Add(this.drp_audmix_1);
            this.TabPage2.Controls.Add(this.drp_track1Audio);
            this.TabPage2.Controls.Add(this.drp_audbit_1);
            this.TabPage2.Controls.Add(this.drp_audsr_1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(724, 316);
            this.TabPage2.TabIndex = 3;
            this.TabPage2.Text = "Audio && Subtitles";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // lv_audioList
            // 
            this.lv_audioList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Source,
            this.col_codec,
            this.col_mixdown,
            this.col_samplerate,
            this.col_bitrate,
            this.col_drc});
            this.lv_audioList.ContextMenuStrip = this.audioMenu;
            this.lv_audioList.FullRowSelect = true;
            this.lv_audioList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_audioList.HideSelection = false;
            this.lv_audioList.LabelWrap = false;
            this.lv_audioList.Location = new System.Drawing.Point(16, 74);
            this.lv_audioList.MultiSelect = false;
            this.lv_audioList.Name = "lv_audioList";
            this.lv_audioList.Size = new System.Drawing.Size(668, 147);
            this.lv_audioList.SmallImageList = this.AudioMenuRowHeightHack;
            this.lv_audioList.TabIndex = 48;
            this.lv_audioList.UseCompatibleStateImageBehavior = false;
            this.lv_audioList.View = System.Windows.Forms.View.Details;
            this.lv_audioList.SelectedIndexChanged += new System.EventHandler(this.lv_audioList_SelectedIndexChanged);
            // 
            // col_Source
            // 
            this.col_Source.Text = "Source";
            this.col_Source.Width = 170;
            // 
            // col_codec
            // 
            this.col_codec.Text = "Audio Codec";
            this.col_codec.Width = 88;
            // 
            // col_mixdown
            // 
            this.col_mixdown.Text = "Mixdown";
            this.col_mixdown.Width = 127;
            // 
            // col_samplerate
            // 
            this.col_samplerate.Text = "Samplerate (Kbps)";
            this.col_samplerate.Width = 124;
            // 
            // col_bitrate
            // 
            this.col_bitrate.Text = "Bitrate (Kbps)";
            this.col_bitrate.Width = 95;
            // 
            // col_drc
            // 
            this.col_drc.Text = "DRC";
            // 
            // audioMenu
            // 
            this.audioMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioList_moveup,
            this.audioList_movedown,
            this.toolStripSeparator2,
            this.audioList_remove});
            this.audioMenu.Name = "audioMenu";
            this.audioMenu.Size = new System.Drawing.Size(152, 76);
            // 
            // audioList_moveup
            // 
            this.audioList_moveup.Name = "audioList_moveup";
            this.audioList_moveup.Size = new System.Drawing.Size(151, 22);
            this.audioList_moveup.Text = "Move Up";
            this.audioList_moveup.Click += new System.EventHandler(this.audioList_moveup_Click);
            // 
            // audioList_movedown
            // 
            this.audioList_movedown.Name = "audioList_movedown";
            this.audioList_movedown.Size = new System.Drawing.Size(151, 22);
            this.audioList_movedown.Text = "Move Down";
            this.audioList_movedown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.audioList_movedown.Click += new System.EventHandler(this.audioList_movedown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // audioList_remove
            // 
            this.audioList_remove.Name = "audioList_remove";
            this.audioList_remove.Size = new System.Drawing.Size(151, 22);
            this.audioList_remove.Text = "Remove";
            this.audioList_remove.Click += new System.EventHandler(this.audioList_remove_Click);
            // 
            // AudioMenuRowHeightHack
            // 
            this.AudioMenuRowHeightHack.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.AudioMenuRowHeightHack.ImageSize = new System.Drawing.Size(1, 18);
            this.AudioMenuRowHeightHack.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_RemoveAudioTrack
            // 
            this.btn_RemoveAudioTrack.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RemoveAudioTrack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveAudioTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_RemoveAudioTrack.Location = new System.Drawing.Point(132, 227);
            this.btn_RemoveAudioTrack.Name = "btn_RemoveAudioTrack";
            this.btn_RemoveAudioTrack.Size = new System.Drawing.Size(111, 23);
            this.btn_RemoveAudioTrack.TabIndex = 47;
            this.btn_RemoveAudioTrack.Text = "Remove";
            this.btn_RemoveAudioTrack.UseVisualStyleBackColor = false;
            this.btn_RemoveAudioTrack.Click += new System.EventHandler(this.btn_RemoveAudioTrack_Click);
            // 
            // btn_addAudioTrack
            // 
            this.btn_addAudioTrack.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addAudioTrack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAudioTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addAudioTrack.Location = new System.Drawing.Point(16, 227);
            this.btn_addAudioTrack.Name = "btn_addAudioTrack";
            this.btn_addAudioTrack.Size = new System.Drawing.Size(111, 23);
            this.btn_addAudioTrack.TabIndex = 46;
            this.btn_addAudioTrack.Text = "Add Track";
            this.btn_addAudioTrack.UseVisualStyleBackColor = false;
            this.btn_addAudioTrack.Click += new System.EventHandler(this.btn_addAudioTrack_Click);
            // 
            // lbl_drc
            // 
            this.lbl_drc.AutoSize = true;
            this.lbl_drc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_drc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drc.Location = new System.Drawing.Point(650, 47);
            this.lbl_drc.Name = "lbl_drc";
            this.lbl_drc.Size = new System.Drawing.Size(14, 13);
            this.lbl_drc.TabIndex = 15;
            this.lbl_drc.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(608, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 12);
            this.label16.TabIndex = 14;
            this.label16.Text = "DRC";
            // 
            // tb_drc
            // 
            this.tb_drc.LargeChange = 0;
            this.tb_drc.Location = new System.Drawing.Point(599, 42);
            this.tb_drc.Margin = new System.Windows.Forms.Padding(0);
            this.tb_drc.Maximum = 31;
            this.tb_drc.Name = "tb_drc";
            this.tb_drc.Size = new System.Drawing.Size(50, 42);
            this.tb_drc.TabIndex = 13;
            this.tb_drc.TickFrequency = 10;
            this.tb_drc.ValueChanged += new System.EventHandler(this.tb_drc_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(107, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(577, 10);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(83, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 10);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(13, 13);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(92, 13);
            this.label68.TabIndex = 0;
            this.label68.Text = "Audio Tracks";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(464, 30);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(62, 12);
            this.label67.TabIndex = 10;
            this.label67.Text = "Samplerate";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(539, 30);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(39, 12);
            this.label66.TabIndex = 12;
            this.label66.Text = "Bitrate";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(235, 30);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(69, 12);
            this.label65.TabIndex = 6;
            this.label65.Text = "Audio Codec";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(369, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mixdown";
            // 
            // check_forced
            // 
            this.check_forced.AutoSize = true;
            this.check_forced.BackColor = System.Drawing.Color.Transparent;
            this.check_forced.Enabled = false;
            this.check_forced.Location = new System.Drawing.Point(223, 288);
            this.check_forced.Name = "check_forced";
            this.check_forced.Size = new System.Drawing.Size(147, 17);
            this.check_forced.TabIndex = 44;
            this.check_forced.Text = "Forced Subtitles Only";
            this.check_forced.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(87, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 12);
            this.label27.TabIndex = 4;
            this.label27.Text = "Source";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(13, 260);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(64, 13);
            this.Label19.TabIndex = 40;
            this.Label19.Text = "Subtitles";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(13, 288);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(61, 13);
            this.Label20.TabIndex = 42;
            this.Label20.Text = "Subtitles:";
            // 
            // drp_track1Audio
            // 
            this.drp_track1Audio.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_track1Audio.FormattingEnabled = true;
            this.drp_track1Audio.Items.AddRange(new object[] {
            "Automatic"});
            this.drp_track1Audio.Location = new System.Drawing.Point(16, 48);
            this.drp_track1Audio.Name = "drp_track1Audio";
            this.drp_track1Audio.Size = new System.Drawing.Size(194, 20);
            this.drp_track1Audio.TabIndex = 3;
            this.drp_track1Audio.Text = "Automatic";
            this.drp_track1Audio.SelectedIndexChanged += new System.EventHandler(this.drp_track1Audio_SelectedIndexChanged);
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Transparent;
            this.TabPage3.Controls.Add(this.radio_cq);
            this.TabPage3.Controls.Add(this.radio_avgBitrate);
            this.TabPage3.Controls.Add(this.radio_targetFilesize);
            this.TabPage3.Controls.Add(this.drp_videoEncoder);
            this.TabPage3.Controls.Add(this.Label47);
            this.TabPage3.Controls.Add(this.label25);
            this.TabPage3.Controls.Add(this.check_turbo);
            this.TabPage3.Controls.Add(this.check_2PassEncode);
            this.TabPage3.Controls.Add(this.Label2);
            this.TabPage3.Controls.Add(this.text_filesize);
            this.TabPage3.Controls.Add(this.slider_videoQuality);
            this.TabPage3.Controls.Add(this.text_bitrate);
            this.TabPage3.Controls.Add(this.SliderValue);
            this.TabPage3.Controls.Add(this.Label46);
            this.TabPage3.Controls.Add(this.drp_videoFramerate);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(724, 316);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Video";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // radio_cq
            // 
            this.radio_cq.AutoSize = true;
            this.radio_cq.Location = new System.Drawing.Point(336, 97);
            this.radio_cq.Name = "radio_cq";
            this.radio_cq.Size = new System.Drawing.Size(125, 17);
            this.radio_cq.TabIndex = 18;
            this.radio_cq.Text = "Constant Quality:";
            this.radio_cq.UseVisualStyleBackColor = true;
            this.radio_cq.CheckedChanged += new System.EventHandler(this.radio_cq_CheckedChanged);
            // 
            // radio_avgBitrate
            // 
            this.radio_avgBitrate.AutoSize = true;
            this.radio_avgBitrate.Checked = true;
            this.radio_avgBitrate.Location = new System.Drawing.Point(336, 64);
            this.radio_avgBitrate.Name = "radio_avgBitrate";
            this.radio_avgBitrate.Size = new System.Drawing.Size(135, 17);
            this.radio_avgBitrate.TabIndex = 17;
            this.radio_avgBitrate.TabStop = true;
            this.radio_avgBitrate.Text = "Avg Bitrate (kbps):";
            this.radio_avgBitrate.UseVisualStyleBackColor = true;
            this.radio_avgBitrate.CheckedChanged += new System.EventHandler(this.radio_avgBitrate_CheckedChanged);
            // 
            // radio_targetFilesize
            // 
            this.radio_targetFilesize.AutoSize = true;
            this.radio_targetFilesize.Location = new System.Drawing.Point(336, 37);
            this.radio_targetFilesize.Name = "radio_targetFilesize";
            this.radio_targetFilesize.Size = new System.Drawing.Size(126, 17);
            this.radio_targetFilesize.TabIndex = 16;
            this.radio_targetFilesize.Text = "Target Size (MB):";
            this.radio_targetFilesize.UseVisualStyleBackColor = true;
            this.radio_targetFilesize.CheckedChanged += new System.EventHandler(this.radio_targetFilesize_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(13, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Video";
            // 
            // check_2PassEncode
            // 
            this.check_2PassEncode.AutoSize = true;
            this.check_2PassEncode.BackColor = System.Drawing.Color.Transparent;
            this.check_2PassEncode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_2PassEncode.Location = new System.Drawing.Point(125, 100);
            this.check_2PassEncode.Name = "check_2PassEncode";
            this.check_2PassEncode.Size = new System.Drawing.Size(119, 17);
            this.check_2PassEncode.TabIndex = 6;
            this.check_2PassEncode.Text = "2-Pass Encoding";
            this.check_2PassEncode.UseVisualStyleBackColor = false;
            this.check_2PassEncode.CheckedChanged += new System.EventHandler(this.check_2PassEncode_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(334, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Quality";
            // 
            // SliderValue
            // 
            this.SliderValue.AutoSize = true;
            this.SliderValue.BackColor = System.Drawing.Color.Transparent;
            this.SliderValue.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SliderValue.Location = new System.Drawing.Point(480, 100);
            this.SliderValue.Name = "SliderValue";
            this.SliderValue.Size = new System.Drawing.Size(23, 12);
            this.SliderValue.TabIndex = 15;
            this.SliderValue.Text = "0%";
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.BackColor = System.Drawing.Color.Transparent;
            this.Label46.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(13, 71);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(106, 13);
            this.Label46.TabIndex = 1;
            this.Label46.Text = "Framerate (FPS):";
            // 
            // check_grayscale
            // 
            this.check_grayscale.AutoSize = true;
            this.check_grayscale.BackColor = System.Drawing.Color.Transparent;
            this.check_grayscale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_grayscale.Location = new System.Drawing.Point(25, 210);
            this.check_grayscale.Name = "check_grayscale";
            this.check_grayscale.Size = new System.Drawing.Size(138, 17);
            this.check_grayscale.TabIndex = 5;
            this.check_grayscale.Text = "Grayscale Encoding";
            this.check_grayscale.UseVisualStyleBackColor = false;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.lbl_max);
            this.TabPage1.Controls.Add(this.check_customCrop);
            this.TabPage1.Controls.Add(this.check_autoCrop);
            this.TabPage1.Controls.Add(this.lbl_src_res);
            this.TabPage1.Controls.Add(this.label7);
            this.TabPage1.Controls.Add(this.label6);
            this.TabPage1.Controls.Add(this.drp_anamorphic);
            this.TabPage1.Controls.Add(this.text_bottom);
            this.TabPage1.Controls.Add(this.text_top);
            this.TabPage1.Controls.Add(this.text_left);
            this.TabPage1.Controls.Add(this.text_right);
            this.TabPage1.Controls.Add(this.label26);
            this.TabPage1.Controls.Add(this.Label56);
            this.TabPage1.Controls.Add(this.lbl_Aspect);
            this.TabPage1.Controls.Add(this.Label91);
            this.TabPage1.Controls.Add(this.text_height);
            this.TabPage1.Controls.Add(this.Label55);
            this.TabPage1.Controls.Add(this.text_width);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Label53);
            this.TabPage1.Controls.Add(this.Label52);
            this.TabPage1.Controls.Add(this.Label51);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(724, 316);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Picture Settings";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Anamorphic:";
            // 
            // drp_anamorphic
            // 
            this.drp_anamorphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drp_anamorphic.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_anamorphic.FormattingEnabled = true;
            this.drp_anamorphic.Items.AddRange(new object[] {
            "None",
            "Strict",
            "Loose"});
            this.drp_anamorphic.Location = new System.Drawing.Point(407, 108);
            this.drp_anamorphic.Name = "drp_anamorphic";
            this.drp_anamorphic.Size = new System.Drawing.Size(110, 21);
            this.drp_anamorphic.TabIndex = 21;
            this.drp_anamorphic.SelectedIndexChanged += new System.EventHandler(this.drp_anamorphic_SelectedIndexChanged);
            // 
            // text_bottom
            // 
            this.text_bottom.Enabled = false;
            this.text_bottom.Location = new System.Drawing.Point(96, 147);
            this.text_bottom.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.text_bottom.Name = "text_bottom";
            this.text_bottom.Size = new System.Drawing.Size(44, 21);
            this.text_bottom.TabIndex = 9;
            // 
            // text_top
            // 
            this.text_top.Enabled = false;
            this.text_top.Location = new System.Drawing.Point(96, 101);
            this.text_top.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.text_top.Name = "text_top";
            this.text_top.Size = new System.Drawing.Size(44, 21);
            this.text_top.TabIndex = 6;
            // 
            // text_left
            // 
            this.text_left.Enabled = false;
            this.text_left.Location = new System.Drawing.Point(45, 123);
            this.text_left.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.text_left.Name = "text_left";
            this.text_left.Size = new System.Drawing.Size(44, 21);
            this.text_left.TabIndex = 4;
            // 
            // text_right
            // 
            this.text_right.Enabled = false;
            this.text_right.Location = new System.Drawing.Point(147, 123);
            this.text_right.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.text_right.Name = "text_right";
            this.text_right.Size = new System.Drawing.Size(44, 21);
            this.text_right.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(311, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Size";
            // 
            // Label56
            // 
            this.Label56.AutoSize = true;
            this.Label56.BackColor = System.Drawing.Color.Transparent;
            this.Label56.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.ForeColor = System.Drawing.Color.Black;
            this.Label56.Location = new System.Drawing.Point(477, 85);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(15, 13);
            this.Label56.TabIndex = 18;
            this.Label56.Text = "x";
            // 
            // lbl_Aspect
            // 
            this.lbl_Aspect.AutoSize = true;
            this.lbl_Aspect.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Aspect.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aspect.Location = new System.Drawing.Point(405, 58);
            this.lbl_Aspect.Name = "lbl_Aspect";
            this.lbl_Aspect.Size = new System.Drawing.Size(72, 12);
            this.lbl_Aspect.TabIndex = 15;
            this.lbl_Aspect.Text = "Select a Title";
            // 
            // Label91
            // 
            this.Label91.AutoSize = true;
            this.Label91.BackColor = System.Drawing.Color.Transparent;
            this.Label91.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label91.Location = new System.Drawing.Point(311, 57);
            this.Label91.Name = "Label91";
            this.Label91.Size = new System.Drawing.Size(83, 13);
            this.Label91.TabIndex = 14;
            this.Label91.Text = "Aspect Ratio:";
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.BackColor = System.Drawing.Color.Transparent;
            this.Label55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.ForeColor = System.Drawing.Color.Black;
            this.Label55.Location = new System.Drawing.Point(311, 84);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(85, 13);
            this.Label55.TabIndex = 16;
            this.Label55.Text = "Width/Height:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Crop";
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.BackColor = System.Drawing.Color.Transparent;
            this.Label53.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.Location = new System.Drawing.Point(94, 171);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(48, 13);
            this.Label53.TabIndex = 10;
            this.Label53.Text = "Bottom";
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.BackColor = System.Drawing.Color.Transparent;
            this.Label52.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.Location = new System.Drawing.Point(103, 86);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(28, 13);
            this.Label52.TabIndex = 5;
            this.Label52.Text = "Top";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.BackColor = System.Drawing.Color.Transparent;
            this.Label51.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.Location = new System.Drawing.Point(190, 125);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(36, 13);
            this.Label51.TabIndex = 8;
            this.Label51.Text = "Right";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(13, 125);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(28, 13);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "Left";
            // 
            // slider_deblock
            // 
            this.slider_deblock.Location = new System.Drawing.Point(118, 162);
            this.slider_deblock.Maximum = 15;
            this.slider_deblock.Minimum = 4;
            this.slider_deblock.Name = "slider_deblock";
            this.slider_deblock.Size = new System.Drawing.Size(174, 42);
            this.slider_deblock.TabIndex = 35;
            this.slider_deblock.Value = 4;
            this.slider_deblock.Scroll += new System.EventHandler(this.slider_deblock_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Deblock:";
            // 
            // lbl_deblockVal
            // 
            this.lbl_deblockVal.AutoSize = true;
            this.lbl_deblockVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deblockVal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deblockVal.Location = new System.Drawing.Point(296, 167);
            this.lbl_deblockVal.Name = "lbl_deblockVal";
            this.lbl_deblockVal.Size = new System.Drawing.Size(24, 13);
            this.lbl_deblockVal.TabIndex = 36;
            this.lbl_deblockVal.Text = "Off";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Filters";
            // 
            // Check_ChapterMarkers
            // 
            this.Check_ChapterMarkers.AutoSize = true;
            this.Check_ChapterMarkers.BackColor = System.Drawing.Color.Transparent;
            this.Check_ChapterMarkers.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ChapterMarkers.Location = new System.Drawing.Point(16, 32);
            this.Check_ChapterMarkers.Name = "Check_ChapterMarkers";
            this.Check_ChapterMarkers.Size = new System.Drawing.Size(164, 17);
            this.Check_ChapterMarkers.TabIndex = 1;
            this.Check_ChapterMarkers.Text = "Create chapter markers";
            this.Check_ChapterMarkers.UseVisualStyleBackColor = false;
            this.Check_ChapterMarkers.CheckedChanged += new System.EventHandler(this.Check_ChapterMarkers_CheckedChanged);
            // 
            // tabs_panel
            // 
            this.tabs_panel.Controls.Add(this.TabPage1);
            this.tabs_panel.Controls.Add(this.tab_Filters);
            this.tabs_panel.Controls.Add(this.TabPage3);
            this.tabs_panel.Controls.Add(this.TabPage2);
            this.tabs_panel.Controls.Add(this.tab_chapters);
            this.tabs_panel.Controls.Add(this.h264Tab);
            this.tabs_panel.Controls.Add(this.tab_query);
            this.tabs_panel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs_panel.Location = new System.Drawing.Point(9, 274);
            this.tabs_panel.Name = "tabs_panel";
            this.tabs_panel.SelectedIndex = 0;
            this.tabs_panel.Size = new System.Drawing.Size(732, 342);
            this.tabs_panel.TabIndex = 5;
            this.tabs_panel.TabStop = false;
            // 
            // tab_Filters
            // 
            this.tab_Filters.Controls.Add(this.ctl_deinterlace);
            this.tab_Filters.Controls.Add(this.ctl_denoise);
            this.tab_Filters.Controls.Add(this.ctl_decomb);
            this.tab_Filters.Controls.Add(this.ctl_detelecine);
            this.tab_Filters.Controls.Add(this.slider_deblock);
            this.tab_Filters.Controls.Add(this.label24);
            this.tab_Filters.Controls.Add(this.check_grayscale);
            this.tab_Filters.Controls.Add(this.label8);
            this.tab_Filters.Controls.Add(this.lbl_deblockVal);
            this.tab_Filters.Location = new System.Drawing.Point(4, 22);
            this.tab_Filters.Name = "tab_Filters";
            this.tab_Filters.Size = new System.Drawing.Size(724, 316);
            this.tab_Filters.TabIndex = 9;
            this.tab_Filters.Text = "Video Filters";
            this.tab_Filters.UseVisualStyleBackColor = true;
            // 
            // tab_chapters
            // 
            this.tab_chapters.BackColor = System.Drawing.Color.Transparent;
            this.tab_chapters.Controls.Add(this.label31);
            this.tab_chapters.Controls.Add(this.data_chpt);
            this.tab_chapters.Controls.Add(this.Check_ChapterMarkers);
            this.tab_chapters.Location = new System.Drawing.Point(4, 22);
            this.tab_chapters.Name = "tab_chapters";
            this.tab_chapters.Size = new System.Drawing.Size(724, 316);
            this.tab_chapters.TabIndex = 6;
            this.tab_chapters.Text = "Chapters";
            this.tab_chapters.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(13, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Chapter Markers";
            // 
            // h264Tab
            // 
            this.h264Tab.BackColor = System.Drawing.Color.Transparent;
            this.h264Tab.Controls.Add(this.x264Panel);
            this.h264Tab.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h264Tab.Location = new System.Drawing.Point(4, 22);
            this.h264Tab.Name = "h264Tab";
            this.h264Tab.Padding = new System.Windows.Forms.Padding(3);
            this.h264Tab.Size = new System.Drawing.Size(724, 316);
            this.h264Tab.TabIndex = 8;
            this.h264Tab.Text = "Advanced";
            this.h264Tab.UseVisualStyleBackColor = true;
            // 
            // tab_query
            // 
            this.tab_query.Controls.Add(this.btn_clear);
            this.tab_query.Controls.Add(this.label34);
            this.tab_query.Controls.Add(this.btn_generate_Query);
            this.tab_query.Controls.Add(this.label33);
            this.tab_query.Controls.Add(this.rtf_query);
            this.tab_query.Location = new System.Drawing.Point(4, 22);
            this.tab_query.Name = "tab_query";
            this.tab_query.Size = new System.Drawing.Size(724, 316);
            this.tab_query.TabIndex = 7;
            this.tab_query.Text = "Query Editor";
            this.tab_query.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clear.Location = new System.Drawing.Point(634, 75);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 22);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(13, 36);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(434, 26);
            this.label34.TabIndex = 1;
            this.label34.Text = "Here you can alter the query generated by this program.\r\nDon\'t forget to re-gener" +
                "ate this query should you change any GUI options.";
            // 
            // btn_generate_Query
            // 
            this.btn_generate_Query.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_generate_Query.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_Query.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_generate_Query.Location = new System.Drawing.Point(16, 75);
            this.btn_generate_Query.Name = "btn_generate_Query";
            this.btn_generate_Query.Size = new System.Drawing.Size(126, 22);
            this.btn_generate_Query.TabIndex = 2;
            this.btn_generate_Query.Text = "Generate Query";
            this.btn_generate_Query.UseVisualStyleBackColor = true;
            this.btn_generate_Query.Click += new System.EventHandler(this.btn_generate_Query_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(13, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Query Editor";
            // 
            // rtf_query
            // 
            this.rtf_query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtf_query.Location = new System.Drawing.Point(16, 103);
            this.rtf_query.Name = "rtf_query";
            this.rtf_query.Size = new System.Drawing.Size(693, 194);
            this.rtf_query.TabIndex = 5;
            this.rtf_query.Text = "";
            // 
            // groupBox_dest
            // 
            this.groupBox_dest.Controls.Add(this.btn_destBrowse);
            this.groupBox_dest.Controls.Add(this.Label3);
            this.groupBox_dest.Controls.Add(this.text_destination);
            this.groupBox_dest.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_dest.ForeColor = System.Drawing.Color.Black;
            this.groupBox_dest.Location = new System.Drawing.Point(9, 160);
            this.groupBox_dest.Name = "groupBox_dest";
            this.groupBox_dest.Size = new System.Drawing.Size(732, 50);
            this.groupBox_dest.TabIndex = 3;
            this.groupBox_dest.TabStop = false;
            this.groupBox_dest.Text = "Destination";
            // 
            // btn_destBrowse
            // 
            this.btn_destBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_destBrowse.Location = new System.Drawing.Point(608, 17);
            this.btn_destBrowse.Name = "btn_destBrowse";
            this.btn_destBrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_destBrowse.TabIndex = 13;
            this.btn_destBrowse.Text = "Browse";
            this.btn_destBrowse.UseVisualStyleBackColor = true;
            this.btn_destBrowse.Click += new System.EventHandler(this.btn_destBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(751, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 546);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Presets";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_presets);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_addPreset);
            this.splitContainer1.Panel2.Controls.Add(this.btn_removePreset);
            this.splitContainer1.Panel2.Controls.Add(this.btn_setDefault);
            this.splitContainer1.Size = new System.Drawing.Size(239, 526);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView_presets
            // 
            this.treeView_presets.ContextMenuStrip = this.presets_menu;
            this.treeView_presets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_presets.ForeColor = System.Drawing.Color.DarkBlue;
            this.treeView_presets.FullRowSelect = true;
            this.treeView_presets.HideSelection = false;
            this.treeView_presets.ItemHeight = 21;
            this.treeView_presets.Location = new System.Drawing.Point(0, 0);
            this.treeView_presets.Name = "treeView_presets";
            this.treeView_presets.ShowLines = false;
            this.treeView_presets.Size = new System.Drawing.Size(239, 485);
            this.treeView_presets.TabIndex = 0;
            this.treeView_presets.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeview_presets_mouseUp);
            this.treeView_presets.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_presets_AfterSelect);
            this.treeView_presets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeView_presets_deleteKey);
            // 
            // presets_menu
            // 
            this.presets_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnu_expandAll,
            this.pmnu_collapse,
            this.sep1,
            this.pmnu_saveChanges,
            this.pmnu_delete});
            this.presets_menu.Name = "presets_menu";
            this.presets_menu.Size = new System.Drawing.Size(163, 98);
            this.presets_menu.Text = ";";
            this.presets_menu.Opening += new System.ComponentModel.CancelEventHandler(this.presets_menu_Opening);
            // 
            // pmnu_expandAll
            // 
            this.pmnu_expandAll.Name = "pmnu_expandAll";
            this.pmnu_expandAll.Size = new System.Drawing.Size(162, 22);
            this.pmnu_expandAll.Text = "Expand All";
            this.pmnu_expandAll.Click += new System.EventHandler(this.pmnu_expandAll_Click);
            // 
            // pmnu_collapse
            // 
            this.pmnu_collapse.Name = "pmnu_collapse";
            this.pmnu_collapse.Size = new System.Drawing.Size(162, 22);
            this.pmnu_collapse.Text = "Collapse All";
            this.pmnu_collapse.Click += new System.EventHandler(this.pmnu_collapse_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(159, 6);
            // 
            // pmnu_saveChanges
            // 
            this.pmnu_saveChanges.Name = "pmnu_saveChanges";
            this.pmnu_saveChanges.Size = new System.Drawing.Size(162, 22);
            this.pmnu_saveChanges.Text = "Save Changes";
            this.pmnu_saveChanges.Click += new System.EventHandler(this.pmnu_saveChanges_Click);
            // 
            // pmnu_delete
            // 
            this.pmnu_delete.Name = "pmnu_delete";
            this.pmnu_delete.Size = new System.Drawing.Size(162, 22);
            this.pmnu_delete.Text = "Delete";
            this.pmnu_delete.Click += new System.EventHandler(this.pmnu_delete_click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_source,
            this.toolStripSeparator10,
            this.btn_start,
            this.btn_add2Queue,
            this.btn_showQueue,
            this.toolStripSeparator4,
            this.tb_preview,
            this.btn_ActivityWindow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1004, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_source
            // 
            this.btn_source.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_file_source,
            this.btn_dvd_source,
            this.toolStripSeparator1,
            this.mnu_dvd_drive});
            this.btn_source.Image = global::Handbrake.Properties.Resources.Movies;
            this.btn_source.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_source.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(90, 36);
            this.btn_source.Text = "Source";
            this.btn_source.ToolTipText = "Open a new source file or folder.";
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // btn_file_source
            // 
            this.btn_file_source.Image = global::Handbrake.Properties.Resources.Movies_Small;
            this.btn_file_source.Name = "btn_file_source";
            this.btn_file_source.Size = new System.Drawing.Size(214, 22);
            this.btn_file_source.Text = "Video File";
            this.btn_file_source.Click += new System.EventHandler(this.btn_file_source_Click);
            // 
            // btn_dvd_source
            // 
            this.btn_dvd_source.Image = ((System.Drawing.Image)(resources.GetObject("btn_dvd_source.Image")));
            this.btn_dvd_source.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_dvd_source.Name = "btn_dvd_source";
            this.btn_dvd_source.Size = new System.Drawing.Size(214, 22);
            this.btn_dvd_source.Text = "DVD/ VIDEO_TS Folder";
            this.btn_dvd_source.Click += new System.EventHandler(this.btn_dvd_source_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // mnu_dvd_drive
            // 
            this.mnu_dvd_drive.Image = global::Handbrake.Properties.Resources.disc_small;
            this.mnu_dvd_drive.Name = "mnu_dvd_drive";
            this.mnu_dvd_drive.Size = new System.Drawing.Size(214, 22);
            this.mnu_dvd_drive.Text = "[No DVD Drive Ready]";
            this.mnu_dvd_drive.Visible = false;
            this.mnu_dvd_drive.Click += new System.EventHandler(this.mnu_dvd_drive_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::Handbrake.Properties.Resources.Play;
            this.btn_start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(70, 36);
            this.btn_start.Text = "Start";
            this.btn_start.ToolTipText = "Start the encoding process";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_add2Queue
            // 
            this.btn_add2Queue.Image = global::Handbrake.Properties.Resources.AddToQueue;
            this.btn_add2Queue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_add2Queue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add2Queue.Name = "btn_add2Queue";
            this.btn_add2Queue.Size = new System.Drawing.Size(122, 36);
            this.btn_add2Queue.Text = "Add to Queue";
            this.btn_add2Queue.ToolTipText = "Add a new item to the Queue";
            this.btn_add2Queue.Click += new System.EventHandler(this.btn_add2Queue_Click);
            // 
            // btn_showQueue
            // 
            this.btn_showQueue.Image = global::Handbrake.Properties.Resources.Queue;
            this.btn_showQueue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_showQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_showQueue.Name = "btn_showQueue";
            this.btn_showQueue.Size = new System.Drawing.Size(115, 36);
            this.btn_showQueue.Tag = "";
            this.btn_showQueue.Text = "Show Queue";
            this.btn_showQueue.Click += new System.EventHandler(this.btn_showQueue_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tb_preview
            // 
            this.tb_preview.Image = global::Handbrake.Properties.Resources.picture;
            this.tb_preview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tb_preview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_preview.Name = "tb_preview";
            this.tb_preview.Size = new System.Drawing.Size(86, 36);
            this.tb_preview.Text = "Preview";
            this.tb_preview.Click += new System.EventHandler(this.tb_preview_Click);
            // 
            // btn_ActivityWindow
            // 
            this.btn_ActivityWindow.Image = global::Handbrake.Properties.Resources.ActivityWindow;
            this.btn_ActivityWindow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ActivityWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ActivityWindow.Name = "btn_ActivityWindow";
            this.btn_ActivityWindow.Size = new System.Drawing.Size(132, 36);
            this.btn_ActivityWindow.Text = "Activity Window";
            this.btn_ActivityWindow.ToolTipText = "Displays the activity window which displays the log of the last completed or curr" +
                "ently running encode.";
            this.btn_ActivityWindow.Click += new System.EventHandler(this.btn_ActivityWindow_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "HandBrake Status Here";
            this.notifyIcon.BalloonTipTitle = "HandBrake";
            this.notifyIcon.ContextMenuStrip = notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "HandBrake";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_encode});
            this.StatusStrip.Location = new System.Drawing.Point(0, 627);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1004, 22);
            this.StatusStrip.TabIndex = 7;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // lbl_encode
            // 
            this.lbl_encode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encode.Name = "lbl_encode";
            this.lbl_encode.Size = new System.Drawing.Size(31, 17);
            this.lbl_encode.Text = "{0}";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(568, 86);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(46, 13);
            this.lbl_max.TabIndex = 35;
            this.lbl_max.Text = "{max}";
            // 
            // ctl_deinterlace
            // 
            this.ctl_deinterlace.AutoSize = true;
            this.ctl_deinterlace.Location = new System.Drawing.Point(19, 95);
            this.ctl_deinterlace.Margin = new System.Windows.Forms.Padding(0);
            this.ctl_deinterlace.MaximumSize = new System.Drawing.Size(400, 30);
            this.ctl_deinterlace.Name = "ctl_deinterlace";
            this.ctl_deinterlace.Size = new System.Drawing.Size(275, 28);
            this.ctl_deinterlace.TabIndex = 41;
            this.ctl_deinterlace.onChange += new System.EventHandler(this.ctl_deinterlace_changed);
            // 
            // ctl_denoise
            // 
            this.ctl_denoise.AutoSize = true;
            this.ctl_denoise.Location = new System.Drawing.Point(19, 123);
            this.ctl_denoise.Margin = new System.Windows.Forms.Padding(0);
            this.ctl_denoise.MaximumSize = new System.Drawing.Size(400, 30);
            this.ctl_denoise.Name = "ctl_denoise";
            this.ctl_denoise.Size = new System.Drawing.Size(275, 28);
            this.ctl_denoise.TabIndex = 40;
            // 
            // ctl_decomb
            // 
            this.ctl_decomb.AutoSize = true;
            this.ctl_decomb.Location = new System.Drawing.Point(19, 66);
            this.ctl_decomb.Margin = new System.Windows.Forms.Padding(0);
            this.ctl_decomb.MaximumSize = new System.Drawing.Size(400, 30);
            this.ctl_decomb.Name = "ctl_decomb";
            this.ctl_decomb.Size = new System.Drawing.Size(275, 28);
            this.ctl_decomb.TabIndex = 39;
            this.ctl_decomb.onChange += new System.EventHandler(this.ctl_decomb_changed);
            // 
            // ctl_detelecine
            // 
            this.ctl_detelecine.AutoSize = true;
            this.ctl_detelecine.Location = new System.Drawing.Point(19, 38);
            this.ctl_detelecine.Margin = new System.Windows.Forms.Padding(0);
            this.ctl_detelecine.MaximumSize = new System.Drawing.Size(400, 30);
            this.ctl_detelecine.Name = "ctl_detelecine";
            this.ctl_detelecine.Size = new System.Drawing.Size(275, 28);
            this.ctl_detelecine.TabIndex = 38;
            // 
            // x264Panel
            // 
            this.x264Panel.Location = new System.Drawing.Point(0, 0);
            this.x264Panel.Name = "x264Panel";
            this.x264Panel.Size = new System.Drawing.Size(720, 306);
            this.x264Panel.TabIndex = 0;
            this.x264Panel.x264Query = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 649);
            this.Controls.Add(this.gb_source);
            this.Controls.Add(this.groupBox_dest);
            this.Controls.Add(this.groupBox_output);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabs_panel);
            this.Controls.Add(this.frmMainMenu);
            this.Controls.Add(this.StatusStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HandBrake";
            notifyIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider_videoQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chpt)).EndInit();
            this.frmMainMenu.ResumeLayout(false);
            this.frmMainMenu.PerformLayout();
            this.gb_source.ResumeLayout(false);
            this.gb_source.PerformLayout();
            this.groupBox_output.ResumeLayout(false);
            this.groupBox_output.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.audioMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_drc)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_deblock)).EndInit();
            this.tabs_panel.ResumeLayout(false);
            this.tab_Filters.ResumeLayout(false);
            this.tab_Filters.PerformLayout();
            this.tab_chapters.ResumeLayout(false);
            this.tab_chapters.PerformLayout();
            this.h264Tab.ResumeLayout(false);
            this.tab_query.ResumeLayout(false);
            this.tab_query.PerformLayout();
            this.groupBox_dest.ResumeLayout(false);
            this.groupBox_dest.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.presets_menu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SaveFileDialog File_Save;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnu_open3;
        internal System.Windows.Forms.ToolStripMenuItem mnu_exit;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnu_encode;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripMenuItem mnu_options;
        internal System.Windows.Forms.ToolStripMenuItem PresetsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnu_presetReset;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem mnu_about;
        internal System.Windows.Forms.MenuStrip frmMainMenu;
        internal System.Windows.Forms.GroupBox gb_source;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ComboBox drop_chapterFinish;
        internal System.Windows.Forms.ComboBox drop_chapterStart;
        internal System.Windows.Forms.ComboBox drp_dvdtitle;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox text_source;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox groupBox_output;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox drp_videoEncoder;
        internal System.Windows.Forms.Label Label47;
        internal System.Windows.Forms.TextBox text_destination;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.ComboBox drp_audmix_1;
        internal System.Windows.Forms.ComboBox drp_track1Audio;
        internal System.Windows.Forms.ComboBox drp_audbit_1;
        internal System.Windows.Forms.ComboBox drp_audsr_1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.CheckBox check_largeFile;
        internal System.Windows.Forms.CheckBox check_turbo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label SliderValue;
        internal System.Windows.Forms.ComboBox drp_videoFramerate;
        internal System.Windows.Forms.CheckBox check_2PassEncode;
        internal System.Windows.Forms.TrackBar slider_videoQuality;
        internal System.Windows.Forms.TextBox text_filesize;
        internal System.Windows.Forms.TextBox text_bitrate;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.CheckBox Check_ChapterMarkers;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label53;
        internal System.Windows.Forms.Label Label52;
        internal System.Windows.Forms.Label Label51;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TabControl tabs_panel;
        internal System.Windows.Forms.Label Label46;
        private System.Windows.Forms.GroupBox groupBox_dest;
        internal System.Windows.Forms.ComboBox drp_subtitle;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.CheckBox check_grayscale;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btn_setDefault;
        private System.Windows.Forms.ToolStripMenuItem mnu_SelectDefault;
        private System.Windows.Forms.ToolStripMenuItem mnu_UpdateCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SaveFileDialog DVD_Save;
        private System.Windows.Forms.OpenFileDialog File_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        internal System.Windows.Forms.CheckBox check_iPodAtom;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label Label56;
        internal System.Windows.Forms.Label lbl_Aspect;
        internal System.Windows.Forms.Label Label91;
        internal System.Windows.Forms.TextBox text_height;
        internal System.Windows.Forms.Label Label55;
        internal System.Windows.Forms.TextBox text_width;
        internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tab_chapters;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.NumericUpDown text_right;
        internal System.Windows.Forms.NumericUpDown text_bottom;
        internal System.Windows.Forms.NumericUpDown text_top;
        internal System.Windows.Forms.NumericUpDown text_left;
        internal System.Windows.Forms.CheckBox check_optimiseMP4;
        internal System.Windows.Forms.CheckBox check_forced;
        internal System.Windows.Forms.DataGridView data_chpt;
        private System.Windows.Forms.TabPage tab_query;
        private System.Windows.Forms.Label label34;
        internal System.Windows.Forms.Button btn_generate_Query;
        internal System.Windows.Forms.Label label33;
        internal System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_start;
        private System.Windows.Forms.ToolStripButton btn_add2Queue;
        private System.Windows.Forms.ToolStripButton btn_showQueue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_ActivityWindow;
        private System.Windows.Forms.ToolStripMenuItem mnu_handbrake_home;
        internal System.Windows.Forms.Button btn_removePreset;
        internal System.Windows.Forms.Button btn_addPreset;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox drp_anamorphic;
        internal System.Windows.Forms.TabPage h264Tab;
        internal System.Windows.Forms.Label label65;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.ComboBox drp_audenc_1;
        internal System.Windows.Forms.Label label66;
        internal System.Windows.Forms.Label label67;
        internal System.Windows.Forms.Label label68;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_destBrowse;
        internal System.Windows.Forms.TrackBar tb_drc;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label lbl_drc;
        internal System.Windows.Forms.TreeView treeView_presets;
        internal System.Windows.Forms.RichTextBox rtf_query;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem btn_restore;
        internal System.Windows.Forms.Label lbl_src_res;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lbl_duration;
        internal System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem btn_file_source;
        private System.Windows.Forms.ToolStripMenuItem mnu_delete_preset;
        private System.Windows.Forms.ToolStripMenuItem btn_new_preset;
        private System.Windows.Forms.ToolStripMenuItem mnu_handbrake_forums;
        private System.Windows.Forms.ToolStripMenuItem mnu_user_guide;
        private System.Windows.Forms.ToolStripDropDownButton btn_source;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_dvd_source;
        internal System.Windows.Forms.ComboBox drop_format;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ToolStripMenuItem mnu_encodeLog;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_encode;
        internal System.Windows.Forms.RadioButton check_customCrop;
        internal System.Windows.Forms.RadioButton check_autoCrop;
        internal System.Windows.Forms.Label lbl_deblockVal;
        internal System.Windows.Forms.TrackBar slider_deblock;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.OpenFileDialog ISO_Open;
        internal System.Windows.Forms.FolderBrowserDialog DVD_Open;
        internal System.Windows.Forms.ToolStripMenuItem mnu_dvd_drive;
        private System.Windows.Forms.ContextMenuStrip presets_menu;
        private System.Windows.Forms.ToolStripMenuItem pmnu_expandAll;
        private System.Windows.Forms.ToolStripMenuItem pmnu_collapse;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripMenuItem pmnu_delete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_RemoveAudioTrack;
        private System.Windows.Forms.Button btn_addAudioTrack;
        private System.Windows.Forms.ColumnHeader col_Source;
        private System.Windows.Forms.ColumnHeader col_codec;
        private System.Windows.Forms.ColumnHeader col_mixdown;
        private System.Windows.Forms.ColumnHeader col_samplerate;
        private System.Windows.Forms.ColumnHeader col_bitrate;
        private System.Windows.Forms.ColumnHeader col_drc;
        internal System.Windows.Forms.ListView lv_audioList;
        private System.Windows.Forms.ContextMenuStrip audioMenu;
        private System.Windows.Forms.ToolStripMenuItem audioList_movedown;
        private System.Windows.Forms.ToolStripMenuItem audioList_moveup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem audioList_remove;
        private System.Windows.Forms.ImageList AudioMenuRowHeightHack;
        private System.Windows.Forms.ToolStripMenuItem pmnu_saveChanges;
        private System.Windows.Forms.ToolStripMenuItem mnu_killCLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_qptest;
        private System.Windows.Forms.TabPage tab_Filters;
        internal Deinterlace ctl_deinterlace;
        internal Denoise ctl_denoise;
        internal Decomb ctl_decomb;
        internal Detelecine ctl_detelecine;
        internal System.Windows.Forms.RadioButton radio_cq;
        internal System.Windows.Forms.RadioButton radio_avgBitrate;
        internal System.Windows.Forms.RadioButton radio_targetFilesize;
        internal Handbrake.Controls.x264Panel x264Panel;
        private System.Windows.Forms.ToolStripButton tb_preview;
        private System.Windows.Forms.Label lbl_max;

    }
}