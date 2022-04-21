// *********************************
// Message from Original Author:
//
// 2008 Jose Menendez Poo
// Please give me credit if you use this code. It's all I ask.
// Contact me for more info: menendezpoo@gmail.com
// *********************************
//
// Original project from http://ribbon.codeplex.com/
// Continue to support and maintain by http://officeribbon.codeplex.com/

using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonProfesionalRendererColorTableWinForms
         : RibbonProfesionalRendererColorTable
    {
        public RibbonProfesionalRendererColorTableWinForms()
        {
            #region Fields

            ThemeName = "WinForms";
            ThemeAuthor = "Jose Menendez Poo, Josh Davidson";
            ThemeAuthorWebsite = "";
            ThemeAuthorEmail = "";
            ThemeDateCreated = "25 Mar 22";

            OrbDropDownDarkBorder = FromHex("#919191");
            OrbDropDownLightBorder = FromHex("#FFFFFF");
            OrbDropDownBack = FromHex("#E1E1E1");
            OrbDropDownNorthA = FromHex("#E1E1E1");
            OrbDropDownNorthB = FromHex("#E1E1E1");
            OrbDropDownNorthC = FromHex("#E1E1E1");
            OrbDropDownNorthD = FromHex("#E1E1E1");
            OrbDropDownSouthC = FromHex("#E1E1E1");
            OrbDropDownSouthD = FromHex("#E1E1E1");
            OrbDropDownContentbg = FromHex("#EAECEE");
            OrbDropDownContentbglight = FromHex("#EAECEE");
            OrbDropDownSeparatorlight = FromHex("#F5F5F5");
            OrbDropDownSeparatordark = FromHex("#C5C5C5");
            Caption1 = FromHex("#E3EBF6");
            Caption2 = FromHex("#DAE9FD");
            Caption3 = FromHex("#D5E5FA");
            Caption4 = FromHex("#D9E7F9");
            Caption5 = FromHex("#CADEF7");
            Caption6 = FromHex("#E4EFFD");
            Caption7 = FromHex("#B0CFF7");
            QuickAccessBorderDark = FromHex("#B6CAE2");
            QuickAccessBorderLight = FromHex("#F2F6FB");
            QuickAccessUpper = FromHex("#E0EBF9");
            QuickAccessLower = FromHex("#C9D9EE");
            OrbOptionBorder = FromHex("#7793B9");
            OrbOptionBackground = FromHex("#E8F1FC");
            OrbOptionShine = FromHex("#D2E1F4");

            Arrow = FromHex("#717171");
            ArrowLight = Color.FromArgb(200, FromHex("#FFFFFF"));
            ArrowDisabled = FromHex("#B7B7B7");

            Text = FromHex("#1E1E1E");
            RibbonBackground = FromHex("#EAECEE");
            TabBorder = FromHex("#CCCCCC");
            TabSelectedBorder = FromHex("#B1B1B1");
            TabNorth = FromHex("#EAECEE");
            TabSouth = FromHex("#EAECEE");
            TabGlow = FromHex("#EAECEE");
            TabText = FromHex("#1E1E1E");
            TabActiveText = FromHex("#1E1E1E");
            TabContentNorth = FromHex("#EAECEE");
            TabContentSouth = FromHex("#EAECEE");
            TabSelectedGlow = FromHex("#EAECEE");
            PanelDarkBorder = FromHex("#919191");
            PanelLightBorder = FromHex("#EAECEE");
            PanelTextBackground = FromHex("#E1E1E1");
            PanelTextBackgroundSelected = FromHex("#D3E6F8");
            PanelText = FromHex("#1E1E1E");
            PanelBackgroundSelected = FromHex("#EAECEE");
            PanelOverflowBackground = FromHex("#EAECEE");
            PanelOverflowBackgroundPressed = FromHex("#EAECEE");
            PanelOverflowBackgroundSelectedNorth = FromHex("#EAECEE");
            PanelOverflowBackgroundSelectedSouth = FromHex("#EAECEE");
            ButtonBgOut = FromHex("#ECECEC");
            ButtonBgCenter = FromHex("#ECECEC");
            ButtonBorderOut = FromHex("#CCCCCC");
            ButtonBorderIn = FromHex("#CCCCCC");
            ButtonGlossyNorth = FromHex("#ECECEC");
            ButtonGlossySouth = FromHex("#ECECEC");
            ButtonDisabledBgOut = FromHex("#F5F5F5");
            ButtonDisabledBgCenter = FromHex("#F5F5F5");
            ButtonDisabledBorderOut = FromHex("#CCCCCC");
            ButtonDisabledBorderIn = FromHex("#CCCCCC");
            ButtonDisabledGlossyNorth = FromHex("#F5F5F5");
            ButtonDisabledGlossySouth = FromHex("#F5F5F5");
            ButtonSelectedBgOut = FromHex("#C9DEF5");
            ButtonSelectedBgCenter = FromHex("#C9DEF5");
            ButtonSelectedBorderOut = FromHex("#CCCCCC");
            ButtonSelectedBorderIn = FromHex("#CCCCCC");
            ButtonSelectedGlossyNorth = FromHex("#C9DEF5");
            ButtonSelectedGlossySouth = FromHex("#C9DEF5");
            ButtonPressedBgOut = FromHex("#A5D0EC");
            ButtonPressedBgCenter = FromHex("#A5D0EC");
            ButtonPressedBorderOut = FromHex("#A5D0EC");
            ButtonPressedBorderIn = FromHex("#A5D0EC");
            ButtonPressedGlossyNorth = FromHex("#A5D0EC");
            ButtonPressedGlossySouth = FromHex("#A5D0EC");
            ButtonCheckedBgOut = FromHex("#F5F5F5");
            ButtonCheckedBgCenter = FromHex("#F5F5F5");
            ButtonCheckedBorderOut = FromHex("#CCCCCC");
            ButtonCheckedBorderIn = FromHex("#CCCCCC");
            ButtonCheckedGlossyNorth = FromHex("#F5F5F5");
            ButtonCheckedGlossySouth = FromHex("#F5F5F5");
            ButtonCheckedSelectedBgOut = FromHex("#F5F5F5");
            ButtonCheckedSelectedBgCenter = FromHex("#F5F5F5");
            ButtonCheckedSelectedBorderOut = FromHex("#A5D0EC");
            ButtonCheckedSelectedBorderIn = FromHex("#A5D0EC");
            ButtonCheckedSelectedGlossyNorth = FromHex("#F5F5F5");
            ButtonCheckedSelectedGlossySouth = FromHex("#F5F5F5");
            ItemGroupOuterBorder = FromHex("#CCCCCC");
            ItemGroupInnerBorder = FromHex("#CCCCCC");
            ItemGroupSeparatorLight = Color.FromArgb(64, FromHex("#FFFFFF"));
            ItemGroupSeparatorDark = Color.FromArgb(38, FromHex("#9EBAE1"));
            ItemGroupBgNorth = FromHex("#EAECEE");
            ItemGroupBgSouth = FromHex("#EAECEE");
            ItemGroupBgGlossy = FromHex("#EAECEE");
            ButtonListBorder = FromHex("#CCCCCC");
            ButtonListBg = FromHex("#F6F6F6");
            ButtonListBgSelected = FromHex("#F5F5F5");
            DropDownBg = FromHex("#F6F6F6");
            DropDownImageBg = FromHex("#F6F6F6");
            DropDownImageSeparator = FromHex("#434346");
            DropDownBorder = FromHex("#CCCCCC");
            DropDownGripNorth = FromHex("#CCCCCC");
            DropDownGripSouth = FromHex("#CCCCCC");
            DropDownGripBorder = FromHex("#CCCCCC");
            DropDownGripDark = FromHex("#1B1B1C");
            DropDownGripLight = FromHex("#FFFFFF");
            DropDownCheckedButtonGlyphBg = FromHex("#FCF1C2");
            DropDownCheckedButtonGlyphBorder = FromHex("#F29536");
            SeparatorLight = FromHex("#F5F5F5");
            SeparatorDark = FromHex("#CCCCCC");
            QATSeparatorLight = Color.FromArgb(95, FromHex("#FFFFFF"));
            QATSeparatorDark = FromHex("#999B9E");
            SeparatorBg = FromHex("#DAE6EE");
            SeparatorLine = FromHex("#434346");

            TextBoxUnselectedBg = FromHex("#FFFFFF");
            TextBoxBorder = FromHex("#CCCCCC");
            TextBoxSelectedBg = FromHex("#FFFFFF");
            TextBoxSelectedBorder = FromHex("#A5D0EC");
            TextBoxDisabledBg = FromHex("#EAECEE");
            TextBoxDisabledBorder = FromHex("#CCCCCC");

            ToolTipContentNorth = FromHex("#ECECEC");
            ToolTipContentSouth = FromHex("#ECECEC");
            ToolTipDarkBorder = FromHex("#CCCCCC");
            ToolTipLightBorder = FromHex("#CCCCCC");

            ToolStripItemTextPressed = FromHex("#FFFFFF");
            ToolStripItemTextSelected = FromHex("#1E1E1E");
            ToolStripItemText = FromHex("#1E1E1E");
            ToolStripitemTextDisabled = FromHex("#A2A4A5");

            clrVerBG_Shadow = FromHex("#FFFFFF");

            ButtonChecked_2013 = FromHex("#FFFFFF");
            ButtonPressed_2013 = FromHex("#92C0E0");
            ButtonSelected_2013 = FromHex("#CDE6F7");
            OrbButton_2013 = FromHex("#0072C6");
            OrbButtonSelected_2013 = FromHex("#2A8AD4");
            OrbButtonPressed_2013 = FromHex("#2A8AD4");
            TabText_2013 = FromHex("#0072C6");
            TabTextSelected_2013 = FromHex("#444444");
            PanelBorder_2013 = FromHex("#15428B");
            RibbonBackground_2013 = FromHex("#FFFFFF");
            TabCompleteBackground_2013 = FromHex("#FFFFFF");
            TabNormalBackground_2013 = FromHex("#FFFFFF");
            TabActiveBackbround_2013 = FromHex("#FFFFFF");
            TabBorder_2013 = FromHex("#D4D4D4");
            TabCompleteBorder_2013 = FromHex("#D4D4D4");
            TabActiveBorder_2013 = FromHex("#D4D4D4");
            OrbButtonText_2013 = FromHex("#FFFFFF");
            PanelText_2013 = FromHex("#666666");
            RibbonItemText_2013 = FromHex("#444444");
            ToolTipText_2013 = FromHex("#1E1E1E");
            ToolStripItemTextPressed_2013 = FromHex("#FFFFFF");
            ToolStripItemTextSelected_2013 = FromHex("#1E1E1E");
            ToolStripItemText_2013 = FromHex("#1E1E1E");

            #endregion
        }
    }
}