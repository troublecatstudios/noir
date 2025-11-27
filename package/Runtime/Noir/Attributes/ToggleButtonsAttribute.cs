using System;

namespace Noir.Attributes {
    /// <summary>
    /// Displays a group of toggle buttons in the Unity Inspector for the annotated field or property.
    /// </summary>
    /// <remarks>
    /// This attribute is typically used to improve the visual layout of boolean or enum fields,
    /// allowing selection through button-style toggles instead of standard checkboxes or dropdowns.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ToggleButtonsAttribute : Attribute
    {
        /// <summary>
        /// Text for true button. Can be resolved string
        /// </summary>
        public string TrueText;

        /// <summary>
        /// Text for false button. Can be resolved string
        /// </summary>
        public string FalseText;

        /// <summary>
        /// Tooltip for true button. Can be resolved string
        /// </summary>
        public string TrueTooltip;

        /// <summary>
        /// Tooltip for false button. Can be resolved string
        /// </summary>
        public string FalseTooltip;

        /// <summary>
        /// Icon for true button
        /// </summary>
        public string TrueIcon;

        /// <summary>
        /// Icon for false button
        /// </summary>
        public string FalseIcon;

        /// <summary>
        /// Color of true button
        /// </summary>
        public string TrueColor;

        /// <summary>
        /// Color of false button
        /// </summary>
        public string FalseColor;

        /// <summary>
        /// Amount by which smaller button size is lerped to match bigger button.
        /// 0 - original size of smaller button (takes the least space).
        /// 1 - matches size of bigger button.
        /// </summary>
        public float SizeCompensation;

        /// <summary>
        /// If set to true, only one button matching bool value will be shown
        /// </summary>
        public bool IsSingleButton;

        /// <summary>
        /// Attribute to draw boolean as buttons
        /// </summary>
        /// <param name="trueText">Text for true button. Can be resolved string</param>
        /// <param name="falseText">Text for false button. Can be resolved string</param>
        /// <param name="singleButton">If set to true, only one button matching bool value will be shown</param>
        /// <param name="sizeCompensation">Amount by which smaller button size is lerped to match bigger button.
        /// 0 - original size of smaller button (takes the least space).
        /// 1 - matches size of bigger button.</param>
        /// <param name="trueTooltip">Tooltip for true button. Can be resolved string</param>
        /// <param name="falseTooltip">Tooltip for false button. Can be resolved string</param>
        /// <param name="trueColor">Color of true button</param>
        /// <param name="falseColor">Color of false button</param>
        /// <param name="trueIcon">Icon for true button</param>
        /// <param name="falseIcon">Icon for false button</param>
        public ToggleButtonsAttribute(string trueText = "Yes", string falseText = "No", bool singleButton = false,
            float sizeCompensation = 1f, string trueTooltip = "", string falseTooltip = "",
            string trueColor = "", string falseColor = "", string trueIcon = "", string falseIcon = "")
        {
            TrueText = trueText;
            FalseText = falseText;

            IsSingleButton = singleButton;
            SizeCompensation = sizeCompensation;

            TrueTooltip = trueTooltip;
            FalseTooltip = falseTooltip;

            TrueIcon = trueIcon;
            FalseIcon = falseIcon;

            TrueColor = trueColor;
            FalseColor = falseColor;
        }
    }
}