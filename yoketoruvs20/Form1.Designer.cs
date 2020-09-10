namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.StartButtom = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.leftlabel = new System.Windows.Forms.Label();
            this.highscorelabel = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlebottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(175, 121);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(450, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる V２０２０";
            // 
            // StartButtom
            // 
            this.StartButtom.Font = new System.Drawing.Font("HGPｺﾞｼｯｸE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButtom.Location = new System.Drawing.Point(295, 355);
            this.StartButtom.Name = "StartButtom";
            this.StartButtom.Size = new System.Drawing.Size(211, 56);
            this.StartButtom.TabIndex = 1;
            this.StartButtom.Text = "START";
            this.StartButtom.UseVisualStyleBackColor = true;
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightlabel.Location = new System.Drawing.Point(491, 414);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(297, 27);
            this.copyrightlabel.TabIndex = 2;
            this.copyrightlabel.Text = "Copyright © 鈴木　智也";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timelabel.Location = new System.Drawing.Point(12, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(219, 48);
            this.timelabel.TabIndex = 3;
            this.timelabel.Text = "TIME：100";
            // 
            // leftlabel
            // 
            this.leftlabel.AutoSize = true;
            this.leftlabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.leftlabel.Location = new System.Drawing.Point(665, 9);
            this.leftlabel.Name = "leftlabel";
            this.leftlabel.Size = new System.Drawing.Size(123, 37);
            this.leftlabel.TabIndex = 4;
            this.leftlabel.Text = "★：１０";
            // 
            // highscorelabel
            // 
            this.highscorelabel.AutoSize = true;
            this.highscorelabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.highscorelabel.Location = new System.Drawing.Point(276, 221);
            this.highscorelabel.Name = "highscorelabel";
            this.highscorelabel.Size = new System.Drawing.Size(248, 35);
            this.highscorelabel.TabIndex = 5;
            this.highscorelabel.Text = "HighScore 1000";
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameoverlabel.Location = new System.Drawing.Point(259, 201);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(282, 48);
            this.gameoverlabel.TabIndex = 6;
            this.gameoverlabel.Text = "GAME OVER";
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearlabel.Location = new System.Drawing.Point(328, 201);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(165, 48);
            this.clearlabel.TabIndex = 8;
            this.clearlabel.Text = "CLEAR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlebottom
            // 
            this.titlebottom.Location = new System.Drawing.Point(378, 350);
            this.titlebottom.Name = "titlebottom";
            this.titlebottom.Size = new System.Drawing.Size(75, 23);
            this.titlebottom.TabIndex = 9;
            this.titlebottom.Text = "button1";
            this.titlebottom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlebottom);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.highscorelabel);
            this.Controls.Add(this.leftlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.StartButtom);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button StartButtom;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label leftlabel;
        private System.Windows.Forms.Label highscorelabel;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label clearlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button titlebottom;
    }
}

