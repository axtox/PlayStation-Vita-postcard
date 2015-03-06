// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace dayofbirth1
{
    partial class ZeroStep
    {
        Panel sceneBackgroundPanel;
        ImageBox ImageBox_1;
        Label Label_1;
        Button YES;
        Button NO;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            sceneBackgroundPanel = new Panel();
            sceneBackgroundPanel.Name = "sceneBackgroundPanel";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            YES = new Button();
            YES.Name = "YES";
            NO = new Button();
            NO.Name = "NO";

            // sceneBackgroundPanel
            sceneBackgroundPanel.BackgroundColor = new UIColor(209f / 255f, 245f / 255f, 255f / 255f, 255f / 255f);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/AxW670QPAOA.jpg");
            ImageBox_1.ImageScaleType = ImageScaleType.AspectOutside;

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 56, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Word;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 76f / 255f),
                HorizontalOffset = 3f,
                VerticalOffset = 3f,
            };

            // YES
            YES.IconImage = new ImageAsset("/Application/assets/yes2.png");
            YES.Style = ButtonStyle.Custom;
            YES.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = null,
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };
            YES.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // NO
            NO.IconImage = new ImageAsset("/Application/assets/no2.png");
            NO.Style = ButtonStyle.Custom;
            NO.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = null,
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // ZeroStep
            this.RootWidget.AddChildLast(sceneBackgroundPanel);
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(YES);
            this.RootWidget.AddChildLast(NO);
            this.Transition = new PushTransition();
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

                    sceneBackgroundPanel.SetPosition(0, 0);
                    sceneBackgroundPanel.SetSize(544, 960);
                    sceneBackgroundPanel.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Left | Anchors.Right;
                    sceneBackgroundPanel.Visible = true;

                    ImageBox_1.SetPosition(305, 173);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Label_1.SetPosition(199, 143);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    YES.SetPosition(41, 335);
                    YES.SetSize(214, 56);
                    YES.Anchors = Anchors.None;
                    YES.Visible = true;

                    NO.SetPosition(589, 325);
                    NO.SetSize(214, 56);
                    NO.Anchors = Anchors.None;
                    NO.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    sceneBackgroundPanel.SetPosition(0, 0);
                    sceneBackgroundPanel.SetSize(960, 544);
                    sceneBackgroundPanel.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Left | Anchors.Right;
                    sceneBackgroundPanel.Visible = true;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Label_1.SetPosition(581, 0);
                    Label_1.SetSize(385, 382);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    YES.SetPosition(140, 396);
                    YES.SetSize(243, 132);
                    YES.Anchors = Anchors.None;
                    YES.Visible = true;

                    NO.SetPosition(640, 405);
                    NO.SetSize(153, 115);
                    NO.Anchors = Anchors.None;
                    NO.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "Это у тебя день рождения сегодня?";

            this.Title = "ZeroStep";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    Label_1.Visible = false;
                    break;

                default:
                    Label_1.Visible = false;
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
                        Widget = Label_1,
                        MoveDirection = FourWayDirection.Down,
                    }.Start();
                    break;

                default:
                    new SlideInEffect()
                    {
                        Widget = Label_1,
                        MoveDirection = FourWayDirection.Down,
                    }.Start();
                    break;
            }
        }

    }
}
