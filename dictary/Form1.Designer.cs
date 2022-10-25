namespace dictary
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
            this.group = new System.Windows.Forms.GroupBox();
            this.get = new System.Windows.Forms.Button();
            this.cursor = new System.Windows.Forms.TextBox();
            this.lcursor = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.LID = new System.Windows.Forms.Label();
            this.parentclass = new System.Windows.Forms.TextBox();
            this.lparentclass = new System.Windows.Forms.Label();
            this.parenttext = new System.Windows.Forms.TextBox();
            this.lparenttext = new System.Windows.Forms.Label();
            this.parent = new System.Windows.Forms.TextBox();
            this.lparent = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.TextBox();
            this.ClassL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.ltitle = new System.Windows.Forms.Label();
            this.handle = new System.Windows.Forms.TextBox();
            this.lhandle = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.get);
            this.group.Controls.Add(this.cursor);
            this.group.Controls.Add(this.lcursor);
            this.group.Controls.Add(this.ID);
            this.group.Controls.Add(this.LID);
            this.group.Controls.Add(this.parentclass);
            this.group.Controls.Add(this.lparentclass);
            this.group.Controls.Add(this.parenttext);
            this.group.Controls.Add(this.lparenttext);
            this.group.Controls.Add(this.parent);
            this.group.Controls.Add(this.lparent);
            this.group.Controls.Add(this.Class);
            this.group.Controls.Add(this.ClassL);
            this.group.Controls.Add(this.title);
            this.group.Controls.Add(this.ltitle);
            this.group.Controls.Add(this.handle);
            this.group.Controls.Add(this.lhandle);
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(247, 344);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "窗口信息";
            // 
            // get
            // 
            this.get.Image = global::dictary.Properties.Resources.button;
            this.get.Location = new System.Drawing.Point(199, 296);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(42, 38);
            this.get.TabIndex = 18;
            this.get.UseVisualStyleBackColor = true;
            this.get.MouseDown += new System.Windows.Forms.MouseEventHandler(this.get_MouseDown);
            this.get.MouseLeave += new System.EventHandler(this.get_MouseLeave);
            this.get.MouseHover += new System.EventHandler(this.get_MouseHover);
            this.get.MouseMove += new System.Windows.Forms.MouseEventHandler(this.get_MouseMove);
            this.get.MouseUp += new System.Windows.Forms.MouseEventHandler(this.get_MouseUp);
            // 
            // cursor
            // 
            this.cursor.Location = new System.Drawing.Point(98, 267);
            this.cursor.Name = "cursor";
            this.cursor.ReadOnly = true;
            this.cursor.Size = new System.Drawing.Size(111, 23);
            this.cursor.TabIndex = 15;
            // 
            // lcursor
            // 
            this.lcursor.AutoSize = true;
            this.lcursor.Location = new System.Drawing.Point(36, 273);
            this.lcursor.Name = "lcursor";
            this.lcursor.Size = new System.Drawing.Size(56, 17);
            this.lcursor.TabIndex = 14;
            this.lcursor.Text = "鼠标坐标";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(98, 228);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(111, 23);
            this.ID.TabIndex = 13;
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Location = new System.Drawing.Point(36, 231);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(56, 17);
            this.LID.TabIndex = 12;
            this.LID.Text = "线程进程";
            // 
            // parentclass
            // 
            this.parentclass.Location = new System.Drawing.Point(98, 156);
            this.parentclass.Name = "parentclass";
            this.parentclass.ReadOnly = true;
            this.parentclass.Size = new System.Drawing.Size(111, 23);
            this.parentclass.TabIndex = 11;
            // 
            // lparentclass
            // 
            this.lparentclass.AutoSize = true;
            this.lparentclass.Location = new System.Drawing.Point(36, 159);
            this.lparentclass.Name = "lparentclass";
            this.lparentclass.Size = new System.Drawing.Size(56, 17);
            this.lparentclass.TabIndex = 10;
            this.lparentclass.Text = "父窗类名";
            // 
            // parenttext
            // 
            this.parenttext.Location = new System.Drawing.Point(98, 191);
            this.parenttext.Name = "parenttext";
            this.parenttext.ReadOnly = true;
            this.parenttext.Size = new System.Drawing.Size(111, 23);
            this.parenttext.TabIndex = 9;
            // 
            // lparenttext
            // 
            this.lparenttext.AutoSize = true;
            this.lparenttext.Location = new System.Drawing.Point(36, 194);
            this.lparenttext.Name = "lparenttext";
            this.lparenttext.Size = new System.Drawing.Size(56, 17);
            this.lparenttext.TabIndex = 8;
            this.lparenttext.Text = "父窗标题";
            // 
            // parent
            // 
            this.parent.Location = new System.Drawing.Point(98, 123);
            this.parent.Name = "parent";
            this.parent.ReadOnly = true;
            this.parent.Size = new System.Drawing.Size(111, 23);
            this.parent.TabIndex = 7;
            // 
            // lparent
            // 
            this.lparent.AutoSize = true;
            this.lparent.Location = new System.Drawing.Point(36, 126);
            this.lparent.Name = "lparent";
            this.lparent.Size = new System.Drawing.Size(56, 17);
            this.lparent.TabIndex = 6;
            this.lparent.Text = "父窗句柄";
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(98, 90);
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Size = new System.Drawing.Size(111, 23);
            this.Class.TabIndex = 5;
            // 
            // ClassL
            // 
            this.ClassL.AutoSize = true;
            this.ClassL.Location = new System.Drawing.Point(36, 93);
            this.ClassL.Name = "ClassL";
            this.ClassL.Size = new System.Drawing.Size(56, 17);
            this.ClassL.TabIndex = 4;
            this.ClassL.Text = "窗口类名";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(98, 59);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(111, 23);
            this.title.TabIndex = 3;
            // 
            // ltitle
            // 
            this.ltitle.AutoSize = true;
            this.ltitle.Location = new System.Drawing.Point(36, 62);
            this.ltitle.Name = "ltitle";
            this.ltitle.Size = new System.Drawing.Size(56, 17);
            this.ltitle.TabIndex = 2;
            this.ltitle.Text = "窗口标题";
            // 
            // handle
            // 
            this.handle.Location = new System.Drawing.Point(98, 29);
            this.handle.Name = "handle";
            this.handle.ReadOnly = true;
            this.handle.Size = new System.Drawing.Size(111, 23);
            this.handle.TabIndex = 1;
            // 
            // lhandle
            // 
            this.lhandle.AutoSize = true;
            this.lhandle.Location = new System.Drawing.Point(36, 32);
            this.lhandle.Name = "lhandle";
            this.lhandle.Size = new System.Drawing.Size(56, 17);
            this.lhandle.TabIndex = 0;
            this.lhandle.Text = "窗口句柄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 368);
            this.Controls.Add(this.group);
            this.Name = "Form1";
            this.Text = "dictary";
            this.TopMost = true;
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox group;
        private Label lhandle;
        private TextBox handle;
        private TextBox title;
        private Label ltitle;
        private TextBox Class;
        private Label ClassL;
        private TextBox parent;
        private Label lparent;
        private TextBox parenttext;
        private Label lparenttext;
        private TextBox parentclass;
        private Label lparentclass;
        private TextBox ID;
        private Label LID;
        private TextBox cursor;
        private Label lcursor;
        private Button get;
    }
}