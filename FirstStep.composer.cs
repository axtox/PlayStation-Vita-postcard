// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace dayofbirth1
{
    partial class FirstStep
    {
        ImageBox ImageBox_1;
        Label HappyBirth;
        ImageBox ImageBox_2;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            HappyBirth = new Label();
            HappyBirth.Name = "HappyBirth";
            ImageBox_2 = new ImageBox();
            ImageBox_2.Name = "ImageBox_2";

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/tumblr_luah9i2o9y1qcri28o1_50011.jpg");
            ImageBox_1.ImageScaleType = ImageScaleType.AspectOutside;

            // HappyBirth
            HappyBirth.TextColor = new UIColor(252f / 255f, 129f / 255f, 131f / 255f, 255f / 255f);
            HappyBirth.Font = new UIFont(FontAlias.System, 60, FontStyle.Bold);
            HappyBirth.LineBreak = LineBreak.Word;
            HappyBirth.HorizontalAlignment = HorizontalAlignment.Center;
            HappyBirth.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(247f / 255f, 247f / 255f, 247f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // ImageBox_2
            ImageBox_2.Image = new ImageAsset("/Application/assets/fire1.png");
            ImageBox_2.ImageScaleType = ImageScaleType.Center;

            // FirstStep
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(HappyBirth);
            this.RootWidget.AddChildLast(ImageBox_2);
            this.Showing += new EventHandler(onShowing);
            this.Shown += new EventHandler(onShown);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    HappyBirth.SetPosition(352, 100);
                    HappyBirth.SetSize(214, 36);
                    HappyBirth.Anchors = Anchors.None;
                    HappyBirth.Visible = true;

                    ImageBox_2.SetPosition(554, 105);
                    ImageBox_2.SetSize(200, 200);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    HappyBirth.SetPosition(0, 0);
                    HappyBirth.SetSize(384, 286);
                    HappyBirth.Anchors = Anchors.None;
                    HappyBirth.Visible = true;

                    ImageBox_2.SetPosition(464, 51);
                    ImageBox_2.SetSize(31, 69);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            HappyBirth.Text = "С ДНЕМ РОЖДЕНИЯ, МАМА :D";

            this.Title = "FirstStep";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    HappyBirth.Visible = false;
                    break;

                default:
                    HappyBirth.Visible = false;
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    new SlideInEffect()
                    {
                        Widget = HappyBirth,
                        MoveDirection = FourWayDirection.Down,
                    }.Start();
                    break;

                default:
                    new SlideInEffect()
                    {
                        Widget = HappyBirth,
                        MoveDirection = FourWayDirection.Down,
                    }.Start();
                    break;
            }
        }

    }
}
