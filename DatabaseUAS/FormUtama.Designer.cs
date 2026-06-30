namespace DatabaseUAS
{
    partial class FormUtama
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browsePostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challengesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookingChallangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gambarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.postsToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.challengesToolStripMenuItem,
            this.userToolStripMenuItem,
            this.daftarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // postsToolStripMenuItem
            // 
            this.postsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPostsToolStripMenuItem,
            this.browsePostToolStripMenuItem});
            this.postsToolStripMenuItem.Name = "postsToolStripMenuItem";
            this.postsToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.postsToolStripMenuItem.Text = "Posts";
            // 
            // createPostsToolStripMenuItem
            // 
            this.createPostsToolStripMenuItem.Name = "createPostsToolStripMenuItem";
            this.createPostsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.createPostsToolStripMenuItem.Text = "Create Posts";
            // 
            // browsePostToolStripMenuItem
            // 
            this.browsePostToolStripMenuItem.Name = "browsePostToolStripMenuItem";
            this.browsePostToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.browsePostToolStripMenuItem.Text = "Browse Post";
            this.browsePostToolStripMenuItem.Click += new System.EventHandler(this.browsePostToolStripMenuItem_Click);
            // 
            // recipesToolStripMenuItem
            // 
            this.recipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.ingredientsToolStripMenuItem,
            this.allRecipesToolStripMenuItem,
            this.reviewsToolStripMenuItem});
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.recipesToolStripMenuItem.Text = "Recipes";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriToolStripMenuItem.Text = "Category";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // ingredientsToolStripMenuItem
            // 
            this.ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            this.ingredientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingredientsToolStripMenuItem.Text = "Ingredients";
            this.ingredientsToolStripMenuItem.Click += new System.EventHandler(this.ingredientsToolStripMenuItem_Click);
            // 
            // allRecipesToolStripMenuItem
            // 
            this.allRecipesToolStripMenuItem.Name = "allRecipesToolStripMenuItem";
            this.allRecipesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allRecipesToolStripMenuItem.Text = "All Recipes";
            this.allRecipesToolStripMenuItem.Click += new System.EventHandler(this.allRecipesToolStripMenuItem_Click);
            // 
            // challengesToolStripMenuItem
            // 
            this.challengesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardToolStripMenuItem,
            this.cookingChallangeToolStripMenuItem});
            this.challengesToolStripMenuItem.Name = "challengesToolStripMenuItem";
            this.challengesToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.challengesToolStripMenuItem.Text = "Challenges";
            // 
            // leaderboardToolStripMenuItem
            // 
            this.leaderboardToolStripMenuItem.Name = "leaderboardToolStripMenuItem";
            this.leaderboardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.leaderboardToolStripMenuItem.Text = "Leaderboard";
            // 
            // cookingChallangeToolStripMenuItem
            // 
            this.cookingChallangeToolStripMenuItem.Name = "cookingChallangeToolStripMenuItem";
            this.cookingChallangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cookingChallangeToolStripMenuItem.Text = "Cooking Challange";
            this.cookingChallangeToolStripMenuItem.Click += new System.EventHandler(this.cookingChallangeToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourPostsToolStripMenuItem,
            this.readingListToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // yourPostsToolStripMenuItem
            // 
            this.yourPostsToolStripMenuItem.Name = "yourPostsToolStripMenuItem";
            this.yourPostsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.yourPostsToolStripMenuItem.Text = "Your Posts";
            // 
            // readingListToolStripMenuItem
            // 
            this.readingListToolStripMenuItem.Name = "readingListToolStripMenuItem";
            this.readingListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.readingListToolStripMenuItem.Text = "Reading List";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // daftarToolStripMenuItem
            // 
            this.daftarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gambarToolStripMenuItem,
            this.interaksiToolStripMenuItem,
            this.pencarianToolStripMenuItem,
            this.userToolStripMenuItem1});
            this.daftarToolStripMenuItem.Name = "daftarToolStripMenuItem";
            this.daftarToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.daftarToolStripMenuItem.Text = "Daftar";
            // 
            // gambarToolStripMenuItem
            // 
            this.gambarToolStripMenuItem.Name = "gambarToolStripMenuItem";
            this.gambarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gambarToolStripMenuItem.Text = "Gambar";
            this.gambarToolStripMenuItem.Click += new System.EventHandler(this.gambarToolStripMenuItem_Click);
            // 
            // interaksiToolStripMenuItem
            // 
            this.interaksiToolStripMenuItem.Name = "interaksiToolStripMenuItem";
            this.interaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interaksiToolStripMenuItem.Text = "Interaksi";
            this.interaksiToolStripMenuItem.Click += new System.EventHandler(this.interaksiToolStripMenuItem_Click);
            // 
            // pencarianToolStripMenuItem
            // 
            this.pencarianToolStripMenuItem.Name = "pencarianToolStripMenuItem";
            this.pencarianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pencarianToolStripMenuItem.Text = "Pencarian";
            this.pencarianToolStripMenuItem.Click += new System.EventHandler(this.pencarianToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            this.reviewsToolStripMenuItem.Click += new System.EventHandler(this.reviewsToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormUtama";
            this.Text = "CookShare";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookingChallangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browsePostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gambarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
    }
}

