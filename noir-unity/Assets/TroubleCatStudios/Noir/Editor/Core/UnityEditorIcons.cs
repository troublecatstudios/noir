namespace NoirUnityEditor {
    using System;
    using UnityEditor;
    using UnityEngine;

    // This class is auto-generated do not modify.
    // Last Generated: 3/6/2022 9:51:36 AM
    public static class UnityEditorIcons {
        private static Func<string, UnityEditorIcon> _iconBuilder;

        public class UnityEditorIcon {
            public static void Initialize() {
                _iconBuilder = (iconName) => new UnityEditorIcon(iconName);
            }
            private readonly string _iconName;
            private UnityEditorIcon(string iconName) {
                _iconName = iconName;
            }
            public GUIContent IconContent => EditorGUIUtility.IconContent(_iconName);
            public Texture Image => IconContent.image;
            public string Name => _iconName;
            public override string ToString() => _iconName;
        }

        private static UnityEditorIcon BuildIcon(string iconName) {
            UnityEditorIcon.Initialize();
            return _iconBuilder(iconName);
        }


        private static readonly UnityEditorIcon _Help = BuildIcon("_Help");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Help" icon.</summary>
        public static UnityEditorIcon Help => _Help;


        private static readonly UnityEditorIcon _Help2x = BuildIcon("_Help@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Help@2x" icon.</summary>
        public static UnityEditorIcon Help2x => _Help2x;


        private static readonly UnityEditorIcon _Menu = BuildIcon("_Menu");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Menu" icon.</summary>
        public static UnityEditorIcon Menu => _Menu;


        private static readonly UnityEditorIcon _Menu2x = BuildIcon("_Menu@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Menu@2x" icon.</summary>
        public static UnityEditorIcon Menu2x => _Menu2x;


        private static readonly UnityEditorIcon _Popup = BuildIcon("_Popup");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Popup" icon.</summary>
        public static UnityEditorIcon Popup => _Popup;


        private static readonly UnityEditorIcon _Popup2x = BuildIcon("_Popup@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "_Popup@2x" icon.</summary>
        public static UnityEditorIcon Popup2x => _Popup2x;


        private static readonly UnityEditorIcon _aboutwindow_mainheader = BuildIcon("aboutwindow.mainheader");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "aboutwindow.mainheader" icon.</summary>
        public static UnityEditorIcon aboutwindow_mainheader => _aboutwindow_mainheader;


        private static readonly UnityEditorIcon _ageialogo = BuildIcon("ageialogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ageialogo" icon.</summary>
        public static UnityEditorIcon ageialogo => _ageialogo;


        private static readonly UnityEditorIcon _AlphabeticalSorting = BuildIcon("AlphabeticalSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AlphabeticalSorting" icon.</summary>
        public static UnityEditorIcon AlphabeticalSorting => _AlphabeticalSorting;


        private static readonly UnityEditorIcon _AlphabeticalSorting2x = BuildIcon("AlphabeticalSorting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AlphabeticalSorting@2x" icon.</summary>
        public static UnityEditorIcon AlphabeticalSorting2x => _AlphabeticalSorting2x;


        private static readonly UnityEditorIcon _Animation_AddEvent = BuildIcon("Animation.AddEvent");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.AddEvent" icon.</summary>
        public static UnityEditorIcon Animation_AddEvent => _Animation_AddEvent;


        private static readonly UnityEditorIcon _Animation_AddEvent2x = BuildIcon("Animation.AddEvent@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.AddEvent@2x" icon.</summary>
        public static UnityEditorIcon Animation_AddEvent2x => _Animation_AddEvent2x;


        private static readonly UnityEditorIcon _Animation_AddKeyframe = BuildIcon("Animation.AddKeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.AddKeyframe" icon.</summary>
        public static UnityEditorIcon Animation_AddKeyframe => _Animation_AddKeyframe;


        private static readonly UnityEditorIcon _Animation_AddKeyframe2x = BuildIcon("Animation.AddKeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.AddKeyframe@2x" icon.</summary>
        public static UnityEditorIcon Animation_AddKeyframe2x => _Animation_AddKeyframe2x;


        private static readonly UnityEditorIcon _Animation_EventMarker = BuildIcon("Animation.EventMarker");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.EventMarker" icon.</summary>
        public static UnityEditorIcon Animation_EventMarker => _Animation_EventMarker;


        private static readonly UnityEditorIcon _Animation_EventMarker2x = BuildIcon("Animation.EventMarker@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.EventMarker@2x" icon.</summary>
        public static UnityEditorIcon Animation_EventMarker2x => _Animation_EventMarker2x;


        private static readonly UnityEditorIcon _Animation_FilterBySelection = BuildIcon("Animation.FilterBySelection");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.FilterBySelection" icon.</summary>
        public static UnityEditorIcon Animation_FilterBySelection => _Animation_FilterBySelection;


        private static readonly UnityEditorIcon _Animation_FilterBySelection2x = BuildIcon("Animation.FilterBySelection@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.FilterBySelection@2x" icon.</summary>
        public static UnityEditorIcon Animation_FilterBySelection2x => _Animation_FilterBySelection2x;


        private static readonly UnityEditorIcon _Animation_FirstKey = BuildIcon("Animation.FirstKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.FirstKey" icon.</summary>
        public static UnityEditorIcon Animation_FirstKey => _Animation_FirstKey;


        private static readonly UnityEditorIcon _Animation_FirstKey2x = BuildIcon("Animation.FirstKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.FirstKey@2x" icon.</summary>
        public static UnityEditorIcon Animation_FirstKey2x => _Animation_FirstKey2x;


        private static readonly UnityEditorIcon _Animation_LastKey = BuildIcon("Animation.LastKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.LastKey" icon.</summary>
        public static UnityEditorIcon Animation_LastKey => _Animation_LastKey;


        private static readonly UnityEditorIcon _Animation_LastKey2x = BuildIcon("Animation.LastKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.LastKey@2x" icon.</summary>
        public static UnityEditorIcon Animation_LastKey2x => _Animation_LastKey2x;


        private static readonly UnityEditorIcon _Animation_NextKey = BuildIcon("Animation.NextKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.NextKey" icon.</summary>
        public static UnityEditorIcon Animation_NextKey => _Animation_NextKey;


        private static readonly UnityEditorIcon _Animation_NextKey2x = BuildIcon("Animation.NextKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.NextKey@2x" icon.</summary>
        public static UnityEditorIcon Animation_NextKey2x => _Animation_NextKey2x;


        private static readonly UnityEditorIcon _Animation_Play = BuildIcon("Animation.Play");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.Play" icon.</summary>
        public static UnityEditorIcon Animation_Play => _Animation_Play;


        private static readonly UnityEditorIcon _Animation_Play2x = BuildIcon("Animation.Play@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.Play@2x" icon.</summary>
        public static UnityEditorIcon Animation_Play2x => _Animation_Play2x;


        private static readonly UnityEditorIcon _Animation_PrevKey = BuildIcon("Animation.PrevKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.PrevKey" icon.</summary>
        public static UnityEditorIcon Animation_PrevKey => _Animation_PrevKey;


        private static readonly UnityEditorIcon _Animation_PrevKey2x = BuildIcon("Animation.PrevKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.PrevKey@2x" icon.</summary>
        public static UnityEditorIcon Animation_PrevKey2x => _Animation_PrevKey2x;


        private static readonly UnityEditorIcon _Animation_Record = BuildIcon("Animation.Record");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.Record" icon.</summary>
        public static UnityEditorIcon Animation_Record => _Animation_Record;


        private static readonly UnityEditorIcon _Animation_Record2x = BuildIcon("Animation.Record@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.Record@2x" icon.</summary>
        public static UnityEditorIcon Animation_Record2x => _Animation_Record2x;


        private static readonly UnityEditorIcon _Animation_SequencerLink = BuildIcon("Animation.SequencerLink");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation.SequencerLink" icon.</summary>
        public static UnityEditorIcon Animation_SequencerLink => _Animation_SequencerLink;


        private static readonly UnityEditorIcon _animationanimated = BuildIcon("animationanimated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationanimated" icon.</summary>
        public static UnityEditorIcon animationanimated => _animationanimated;


        private static readonly UnityEditorIcon _animationanimated2x = BuildIcon("animationanimated@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationanimated@2x" icon.</summary>
        public static UnityEditorIcon animationanimated2x => _animationanimated2x;


        private static readonly UnityEditorIcon _animationdopesheetkeyframe = BuildIcon("animationdopesheetkeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationdopesheetkeyframe" icon.</summary>
        public static UnityEditorIcon animationdopesheetkeyframe => _animationdopesheetkeyframe;


        private static readonly UnityEditorIcon _animationkeyframe = BuildIcon("animationkeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationkeyframe" icon.</summary>
        public static UnityEditorIcon animationkeyframe => _animationkeyframe;


        private static readonly UnityEditorIcon _animationkeyframe2x = BuildIcon("animationkeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationkeyframe@2x" icon.</summary>
        public static UnityEditorIcon animationkeyframe2x => _animationkeyframe2x;


        private static readonly UnityEditorIcon _animationnocurve = BuildIcon("animationnocurve");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationnocurve" icon.</summary>
        public static UnityEditorIcon animationnocurve => _animationnocurve;


        private static readonly UnityEditorIcon _animationvisibilitytoggleoff = BuildIcon("animationvisibilitytoggleoff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationvisibilitytoggleoff" icon.</summary>
        public static UnityEditorIcon animationvisibilitytoggleoff => _animationvisibilitytoggleoff;


        private static readonly UnityEditorIcon _animationvisibilitytoggleoff2x = BuildIcon("animationvisibilitytoggleoff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationvisibilitytoggleoff@2x" icon.</summary>
        public static UnityEditorIcon animationvisibilitytoggleoff2x => _animationvisibilitytoggleoff2x;


        private static readonly UnityEditorIcon _animationvisibilitytoggleon = BuildIcon("animationvisibilitytoggleon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationvisibilitytoggleon" icon.</summary>
        public static UnityEditorIcon animationvisibilitytoggleon => _animationvisibilitytoggleon;


        private static readonly UnityEditorIcon _animationvisibilitytoggleon2x = BuildIcon("animationvisibilitytoggleon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "animationvisibilitytoggleon@2x" icon.</summary>
        public static UnityEditorIcon animationvisibilitytoggleon2x => _animationvisibilitytoggleon2x;


        private static readonly UnityEditorIcon _AnimationWrapModeMenu = BuildIcon("AnimationWrapModeMenu");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimationWrapModeMenu" icon.</summary>
        public static UnityEditorIcon AnimationWrapModeMenu => _AnimationWrapModeMenu;


        private static readonly UnityEditorIcon _AssemblyLock = BuildIcon("AssemblyLock");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AssemblyLock" icon.</summary>
        public static UnityEditorIcon AssemblyLock => _AssemblyLock;


        private static readonly UnityEditorIcon _Asset_Store = BuildIcon("Asset Store");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Asset Store" icon.</summary>
        public static UnityEditorIcon Asset_Store => _Asset_Store;


        private static readonly UnityEditorIcon _Asset_Store2x = BuildIcon("Asset Store@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Asset Store@2x" icon.</summary>
        public static UnityEditorIcon Asset_Store2x => _Asset_Store2x;


        private static readonly UnityEditorIcon _Unity_AssetStore_Originals_Logo_White = BuildIcon("Unity-AssetStore-Originals-Logo-White");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Unity-AssetStore-Originals-Logo-White" icon.</summary>
        public static UnityEditorIcon Unity_AssetStore_Originals_Logo_White => _Unity_AssetStore_Originals_Logo_White;


        private static readonly UnityEditorIcon _Unity_AssetStore_Originals_Logo_White2x = BuildIcon("Unity-AssetStore-Originals-Logo-White@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Unity-AssetStore-Originals-Logo-White@2x" icon.</summary>
        public static UnityEditorIcon Unity_AssetStore_Originals_Logo_White2x => _Unity_AssetStore_Originals_Logo_White2x;


        private static readonly UnityEditorIcon _Audio_Mixer = BuildIcon("Audio Mixer");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Audio Mixer" icon.</summary>
        public static UnityEditorIcon Audio_Mixer => _Audio_Mixer;


        private static readonly UnityEditorIcon _Audio_Mixer2x = BuildIcon("Audio Mixer@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Audio Mixer@2x" icon.</summary>
        public static UnityEditorIcon Audio_Mixer2x => _Audio_Mixer2x;


        private static readonly UnityEditorIcon _AutoLightbakingOff = BuildIcon("AutoLightbakingOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AutoLightbakingOff" icon.</summary>
        public static UnityEditorIcon AutoLightbakingOff => _AutoLightbakingOff;


        private static readonly UnityEditorIcon _AutoLightbakingOff2x = BuildIcon("AutoLightbakingOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AutoLightbakingOff@2x" icon.</summary>
        public static UnityEditorIcon AutoLightbakingOff2x => _AutoLightbakingOff2x;


        private static readonly UnityEditorIcon _AutoLightbakingOn = BuildIcon("AutoLightbakingOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AutoLightbakingOn" icon.</summary>
        public static UnityEditorIcon AutoLightbakingOn => _AutoLightbakingOn;


        private static readonly UnityEditorIcon _AutoLightbakingOn2x = BuildIcon("AutoLightbakingOn@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AutoLightbakingOn@2x" icon.</summary>
        public static UnityEditorIcon AutoLightbakingOn2x => _AutoLightbakingOn2x;


        private static readonly UnityEditorIcon _AvatarCompass = BuildIcon("AvatarCompass");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarCompass" icon.</summary>
        public static UnityEditorIcon AvatarCompass => _AvatarCompass;


        private static readonly UnityEditorIcon _AvatarController_Layer = BuildIcon("AvatarController.Layer");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarController.Layer" icon.</summary>
        public static UnityEditorIcon AvatarController_Layer => _AvatarController_Layer;


        private static readonly UnityEditorIcon _AvatarController_LayerHover = BuildIcon("AvatarController.LayerHover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarController.LayerHover" icon.</summary>
        public static UnityEditorIcon AvatarController_LayerHover => _AvatarController_LayerHover;


        private static readonly UnityEditorIcon _AvatarController_LayerSelected = BuildIcon("AvatarController.LayerSelected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarController.LayerSelected" icon.</summary>
        public static UnityEditorIcon AvatarController_LayerSelected => _AvatarController_LayerSelected;


        private static readonly UnityEditorIcon _BodyPartPicker = BuildIcon("BodyPartPicker");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BodyPartPicker" icon.</summary>
        public static UnityEditorIcon BodyPartPicker => _BodyPartPicker;


        private static readonly UnityEditorIcon _BodySilhouette = BuildIcon("BodySilhouette");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BodySilhouette" icon.</summary>
        public static UnityEditorIcon BodySilhouette => _BodySilhouette;


        private static readonly UnityEditorIcon _DotFill = BuildIcon("DotFill");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DotFill" icon.</summary>
        public static UnityEditorIcon DotFill => _DotFill;


        private static readonly UnityEditorIcon _DotFrame = BuildIcon("DotFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DotFrame" icon.</summary>
        public static UnityEditorIcon DotFrame => _DotFrame;


        private static readonly UnityEditorIcon _DotFrameDotted = BuildIcon("DotFrameDotted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DotFrameDotted" icon.</summary>
        public static UnityEditorIcon DotFrameDotted => _DotFrameDotted;


        private static readonly UnityEditorIcon _DotSelection = BuildIcon("DotSelection");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DotSelection" icon.</summary>
        public static UnityEditorIcon DotSelection => _DotSelection;


        private static readonly UnityEditorIcon _Head = BuildIcon("Head");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Head" icon.</summary>
        public static UnityEditorIcon Head => _Head;


        private static readonly UnityEditorIcon _HeadIk = BuildIcon("HeadIk");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HeadIk" icon.</summary>
        public static UnityEditorIcon HeadIk => _HeadIk;


        private static readonly UnityEditorIcon _HeadZoom = BuildIcon("HeadZoom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HeadZoom" icon.</summary>
        public static UnityEditorIcon HeadZoom => _HeadZoom;


        private static readonly UnityEditorIcon _HeadZoomSilhouette = BuildIcon("HeadZoomSilhouette");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HeadZoomSilhouette" icon.</summary>
        public static UnityEditorIcon HeadZoomSilhouette => _HeadZoomSilhouette;


        private static readonly UnityEditorIcon _LeftArm = BuildIcon("LeftArm");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftArm" icon.</summary>
        public static UnityEditorIcon LeftArm => _LeftArm;


        private static readonly UnityEditorIcon _LeftFeetIk = BuildIcon("LeftFeetIk");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftFeetIk" icon.</summary>
        public static UnityEditorIcon LeftFeetIk => _LeftFeetIk;


        private static readonly UnityEditorIcon _LeftFingers = BuildIcon("LeftFingers");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftFingers" icon.</summary>
        public static UnityEditorIcon LeftFingers => _LeftFingers;


        private static readonly UnityEditorIcon _LeftFingersIk = BuildIcon("LeftFingersIk");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftFingersIk" icon.</summary>
        public static UnityEditorIcon LeftFingersIk => _LeftFingersIk;


        private static readonly UnityEditorIcon _LeftHandZoom = BuildIcon("LeftHandZoom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftHandZoom" icon.</summary>
        public static UnityEditorIcon LeftHandZoom => _LeftHandZoom;


        private static readonly UnityEditorIcon _LeftHandZoomSilhouette = BuildIcon("LeftHandZoomSilhouette");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftHandZoomSilhouette" icon.</summary>
        public static UnityEditorIcon LeftHandZoomSilhouette => _LeftHandZoomSilhouette;


        private static readonly UnityEditorIcon _LeftLeg = BuildIcon("LeftLeg");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LeftLeg" icon.</summary>
        public static UnityEditorIcon LeftLeg => _LeftLeg;


        private static readonly UnityEditorIcon _MaskEditor_Root = BuildIcon("MaskEditor_Root");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MaskEditor_Root" icon.</summary>
        public static UnityEditorIcon MaskEditor_Root => _MaskEditor_Root;


        private static readonly UnityEditorIcon _RightArm = BuildIcon("RightArm");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightArm" icon.</summary>
        public static UnityEditorIcon RightArm => _RightArm;


        private static readonly UnityEditorIcon _RightFeetIk = BuildIcon("RightFeetIk");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightFeetIk" icon.</summary>
        public static UnityEditorIcon RightFeetIk => _RightFeetIk;


        private static readonly UnityEditorIcon _RightFingers = BuildIcon("RightFingers");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightFingers" icon.</summary>
        public static UnityEditorIcon RightFingers => _RightFingers;


        private static readonly UnityEditorIcon _RightFingersIk = BuildIcon("RightFingersIk");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightFingersIk" icon.</summary>
        public static UnityEditorIcon RightFingersIk => _RightFingersIk;


        private static readonly UnityEditorIcon _RightHandZoom = BuildIcon("RightHandZoom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightHandZoom" icon.</summary>
        public static UnityEditorIcon RightHandZoom => _RightHandZoom;


        private static readonly UnityEditorIcon _RightHandZoomSilhouette = BuildIcon("RightHandZoomSilhouette");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightHandZoomSilhouette" icon.</summary>
        public static UnityEditorIcon RightHandZoomSilhouette => _RightHandZoomSilhouette;


        private static readonly UnityEditorIcon _RightLeg = BuildIcon("RightLeg");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RightLeg" icon.</summary>
        public static UnityEditorIcon RightLeg => _RightLeg;


        private static readonly UnityEditorIcon _Torso = BuildIcon("Torso");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Torso" icon.</summary>
        public static UnityEditorIcon Torso => _Torso;


        private static readonly UnityEditorIcon _AvatarPivot = BuildIcon("AvatarPivot");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarPivot" icon.</summary>
        public static UnityEditorIcon AvatarPivot => _AvatarPivot;


        private static readonly UnityEditorIcon _AvatarPivot2x = BuildIcon("AvatarPivot@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarPivot@2x" icon.</summary>
        public static UnityEditorIcon AvatarPivot2x => _AvatarPivot2x;


        private static readonly UnityEditorIcon _AvatarSelector = BuildIcon("AvatarSelector");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarSelector" icon.</summary>
        public static UnityEditorIcon AvatarSelector => _AvatarSelector;


        private static readonly UnityEditorIcon _AvatarSelector2x = BuildIcon("AvatarSelector@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarSelector@2x" icon.</summary>
        public static UnityEditorIcon AvatarSelector2x => _AvatarSelector2x;


        private static readonly UnityEditorIcon _back = BuildIcon("back");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "back" icon.</summary>
        public static UnityEditorIcon back => _back;


        private static readonly UnityEditorIcon _back2x = BuildIcon("back@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "back@2x" icon.</summary>
        public static UnityEditorIcon back2x => _back2x;


        private static readonly UnityEditorIcon _beginButton_On = BuildIcon("beginButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "beginButton-On" icon.</summary>
        public static UnityEditorIcon beginButton_On => _beginButton_On;


        private static readonly UnityEditorIcon _beginButton = BuildIcon("beginButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "beginButton" icon.</summary>
        public static UnityEditorIcon beginButton => _beginButton;


        private static readonly UnityEditorIcon _blendKey = BuildIcon("blendKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKey" icon.</summary>
        public static UnityEditorIcon blendKey => _blendKey;


        private static readonly UnityEditorIcon _blendKey2x = BuildIcon("blendKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKey@2x" icon.</summary>
        public static UnityEditorIcon blendKey2x => _blendKey2x;


        private static readonly UnityEditorIcon _blendKeyOverlay = BuildIcon("blendKeyOverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKeyOverlay" icon.</summary>
        public static UnityEditorIcon blendKeyOverlay => _blendKeyOverlay;


        private static readonly UnityEditorIcon _blendKeyOverlay2x = BuildIcon("blendKeyOverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKeyOverlay@2x" icon.</summary>
        public static UnityEditorIcon blendKeyOverlay2x => _blendKeyOverlay2x;


        private static readonly UnityEditorIcon _blendKeySelected = BuildIcon("blendKeySelected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKeySelected" icon.</summary>
        public static UnityEditorIcon blendKeySelected => _blendKeySelected;


        private static readonly UnityEditorIcon _blendKeySelected2x = BuildIcon("blendKeySelected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendKeySelected@2x" icon.</summary>
        public static UnityEditorIcon blendKeySelected2x => _blendKeySelected2x;


        private static readonly UnityEditorIcon _blendSampler = BuildIcon("blendSampler");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blendSampler" icon.</summary>
        public static UnityEditorIcon blendSampler => _blendSampler;


        private static readonly UnityEditorIcon _blueGroove = BuildIcon("blueGroove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "blueGroove" icon.</summary>
        public static UnityEditorIcon blueGroove => _blueGroove;


        private static readonly UnityEditorIcon _BuildSettings_Android_On = BuildIcon("BuildSettings.Android On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android_On => _BuildSettings_Android_On;


        private static readonly UnityEditorIcon _BuildSettings_Android_On2x = BuildIcon("BuildSettings.Android On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android_On2x => _BuildSettings_Android_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Android = BuildIcon("BuildSettings.Android");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android => _BuildSettings_Android;


        private static readonly UnityEditorIcon _BuildSettings_Android_Small = BuildIcon("BuildSettings.Android.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android_Small => _BuildSettings_Android_Small;


        private static readonly UnityEditorIcon _BuildSettings_Android_Small2x = BuildIcon("BuildSettings.Android.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android_Small2x => _BuildSettings_Android_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Android2x = BuildIcon("BuildSettings.Android@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Android@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Android2x => _BuildSettings_Android2x;


        private static readonly UnityEditorIcon _BuildSettings_Broadcom = BuildIcon("BuildSettings.Broadcom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Broadcom" icon.</summary>
        public static UnityEditorIcon BuildSettings_Broadcom => _BuildSettings_Broadcom;


        private static readonly UnityEditorIcon _BuildSettings_Editor = BuildIcon("BuildSettings.Editor");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Editor" icon.</summary>
        public static UnityEditorIcon BuildSettings_Editor => _BuildSettings_Editor;


        private static readonly UnityEditorIcon _BuildSettings_Editor_Small = BuildIcon("BuildSettings.Editor.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Editor.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Editor_Small => _BuildSettings_Editor_Small;


        private static readonly UnityEditorIcon _BuildSettings_Facebook_On = BuildIcon("BuildSettings.Facebook On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook_On => _BuildSettings_Facebook_On;


        private static readonly UnityEditorIcon _BuildSettings_Facebook_On2x = BuildIcon("BuildSettings.Facebook On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook_On2x => _BuildSettings_Facebook_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Facebook = BuildIcon("BuildSettings.Facebook");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook => _BuildSettings_Facebook;


        private static readonly UnityEditorIcon _BuildSettings_Facebook_Small = BuildIcon("BuildSettings.Facebook.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook_Small => _BuildSettings_Facebook_Small;


        private static readonly UnityEditorIcon _BuildSettings_Facebook_Small2x = BuildIcon("BuildSettings.Facebook.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook_Small2x => _BuildSettings_Facebook_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Facebook2x = BuildIcon("BuildSettings.Facebook@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Facebook@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Facebook2x => _BuildSettings_Facebook2x;


        private static readonly UnityEditorIcon _BuildSettings_FlashPlayer = BuildIcon("BuildSettings.FlashPlayer");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.FlashPlayer" icon.</summary>
        public static UnityEditorIcon BuildSettings_FlashPlayer => _BuildSettings_FlashPlayer;


        private static readonly UnityEditorIcon _BuildSettings_FlashPlayer_Small = BuildIcon("BuildSettings.FlashPlayer.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.FlashPlayer.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_FlashPlayer_Small => _BuildSettings_FlashPlayer_Small;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett_On = BuildIcon("BuildSettings.GameCoreScarlett On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett On" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett_On => _BuildSettings_GameCoreScarlett_On;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett_On2x = BuildIcon("BuildSettings.GameCoreScarlett On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett_On2x => _BuildSettings_GameCoreScarlett_On2x;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett = BuildIcon("BuildSettings.GameCoreScarlett");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett => _BuildSettings_GameCoreScarlett;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett_Small = BuildIcon("BuildSettings.GameCoreScarlett.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett_Small => _BuildSettings_GameCoreScarlett_Small;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett_Small2x = BuildIcon("BuildSettings.GameCoreScarlett.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett_Small2x => _BuildSettings_GameCoreScarlett_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreScarlett2x = BuildIcon("BuildSettings.GameCoreScarlett@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreScarlett@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreScarlett2x => _BuildSettings_GameCoreScarlett2x;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne_On = BuildIcon("BuildSettings.GameCoreXboxOne On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne On" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne_On => _BuildSettings_GameCoreXboxOne_On;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne_On2x = BuildIcon("BuildSettings.GameCoreXboxOne On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne_On2x => _BuildSettings_GameCoreXboxOne_On2x;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne = BuildIcon("BuildSettings.GameCoreXboxOne");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne => _BuildSettings_GameCoreXboxOne;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne_Small = BuildIcon("BuildSettings.GameCoreXboxOne.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne_Small => _BuildSettings_GameCoreXboxOne_Small;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne_Small2x = BuildIcon("BuildSettings.GameCoreXboxOne.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne_Small2x => _BuildSettings_GameCoreXboxOne_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_GameCoreXboxOne2x = BuildIcon("BuildSettings.GameCoreXboxOne@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.GameCoreXboxOne@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_GameCoreXboxOne2x => _BuildSettings_GameCoreXboxOne2x;


        private static readonly UnityEditorIcon _BuildSettings_iPhone_On = BuildIcon("BuildSettings.iPhone On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone On" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone_On => _BuildSettings_iPhone_On;


        private static readonly UnityEditorIcon _BuildSettings_iPhone_On2x = BuildIcon("BuildSettings.iPhone On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone_On2x => _BuildSettings_iPhone_On2x;


        private static readonly UnityEditorIcon _BuildSettings_iPhone = BuildIcon("BuildSettings.iPhone");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone => _BuildSettings_iPhone;


        private static readonly UnityEditorIcon _BuildSettings_iPhone_Small = BuildIcon("BuildSettings.iPhone.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone_Small => _BuildSettings_iPhone_Small;


        private static readonly UnityEditorIcon _BuildSettings_iPhone_Small2x = BuildIcon("BuildSettings.iPhone.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone_Small2x => _BuildSettings_iPhone_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_iPhone2x = BuildIcon("BuildSettings.iPhone@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.iPhone@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_iPhone2x => _BuildSettings_iPhone2x;


        private static readonly UnityEditorIcon _BuildSettings_Lumin_On = BuildIcon("BuildSettings.Lumin On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin_On => _BuildSettings_Lumin_On;


        private static readonly UnityEditorIcon _BuildSettings_Lumin_On2x = BuildIcon("BuildSettings.Lumin On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin_On2x => _BuildSettings_Lumin_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Lumin = BuildIcon("BuildSettings.Lumin");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin => _BuildSettings_Lumin;


        private static readonly UnityEditorIcon _BuildSettings_Lumin_small = BuildIcon("BuildSettings.Lumin.small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin.small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin_small => _BuildSettings_Lumin_small;


        private static readonly UnityEditorIcon _BuildSettings_Lumin_small2x = BuildIcon("BuildSettings.Lumin.small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin.small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin_small2x => _BuildSettings_Lumin_small2x;


        private static readonly UnityEditorIcon _BuildSettings_Lumin2x = BuildIcon("BuildSettings.Lumin@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Lumin@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Lumin2x => _BuildSettings_Lumin2x;


        private static readonly UnityEditorIcon _BuildSettings_Metro_On = BuildIcon("BuildSettings.Metro On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro_On => _BuildSettings_Metro_On;


        private static readonly UnityEditorIcon _BuildSettings_Metro_On2x = BuildIcon("BuildSettings.Metro On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro_On2x => _BuildSettings_Metro_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Metro = BuildIcon("BuildSettings.Metro");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro => _BuildSettings_Metro;


        private static readonly UnityEditorIcon _BuildSettings_Metro_Small = BuildIcon("BuildSettings.Metro.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro_Small => _BuildSettings_Metro_Small;


        private static readonly UnityEditorIcon _BuildSettings_Metro_Small2x = BuildIcon("BuildSettings.Metro.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro_Small2x => _BuildSettings_Metro_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Metro2x = BuildIcon("BuildSettings.Metro@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Metro@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Metro2x => _BuildSettings_Metro2x;


        private static readonly UnityEditorIcon _BuildSettings_N3DS_On = BuildIcon("BuildSettings.N3DS On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS On" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS_On => _BuildSettings_N3DS_On;


        private static readonly UnityEditorIcon _BuildSettings_N3DS_On2x = BuildIcon("BuildSettings.N3DS On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS_On2x => _BuildSettings_N3DS_On2x;


        private static readonly UnityEditorIcon _BuildSettings_N3DS = BuildIcon("BuildSettings.N3DS");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS => _BuildSettings_N3DS;


        private static readonly UnityEditorIcon _BuildSettings_N3DS_Small = BuildIcon("BuildSettings.N3DS.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS_Small => _BuildSettings_N3DS_Small;


        private static readonly UnityEditorIcon _BuildSettings_N3DS_Small2x = BuildIcon("BuildSettings.N3DS.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS_Small2x => _BuildSettings_N3DS_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_N3DS2x = BuildIcon("BuildSettings.N3DS@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.N3DS@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_N3DS2x => _BuildSettings_N3DS2x;


        private static readonly UnityEditorIcon _BuildSettings_PS4_On = BuildIcon("BuildSettings.PS4 On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4 On" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS4_On => _BuildSettings_PS4_On;


        private static readonly UnityEditorIcon _BuildSettings_PS4_On2x = BuildIcon("BuildSettings.PS4 On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4 On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS4_On2x => _BuildSettings_PS4_On2x;


        private static readonly UnityEditorIcon _BuildSettings_PS4 = BuildIcon("BuildSettings.PS4");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS4 => _BuildSettings_PS4;


        private static readonly UnityEditorIcon _BuildSettings_PS4_Small = BuildIcon("BuildSettings.PS4.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS4_Small => _BuildSettings_PS4_Small;


        private static readonly UnityEditorIcon _BuildSettings_PS4_Small2x = BuildIcon("BuildSettings.PS4.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS4_Small2x => _BuildSettings_PS4_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_PS42x = BuildIcon("BuildSettings.PS4@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS4@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS42x => _BuildSettings_PS42x;


        private static readonly UnityEditorIcon _BuildSettings_PS5_On = BuildIcon("BuildSettings.PS5 On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5 On" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS5_On => _BuildSettings_PS5_On;


        private static readonly UnityEditorIcon _BuildSettings_PS5_On2x = BuildIcon("BuildSettings.PS5 On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5 On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS5_On2x => _BuildSettings_PS5_On2x;


        private static readonly UnityEditorIcon _BuildSettings_PS5 = BuildIcon("BuildSettings.PS5");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS5 => _BuildSettings_PS5;


        private static readonly UnityEditorIcon _BuildSettings_PS5_Small = BuildIcon("BuildSettings.PS5.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS5_Small => _BuildSettings_PS5_Small;


        private static readonly UnityEditorIcon _BuildSettings_PS5_Small2x = BuildIcon("BuildSettings.PS5.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS5_Small2x => _BuildSettings_PS5_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_PS52x = BuildIcon("BuildSettings.PS5@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PS5@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_PS52x => _BuildSettings_PS52x;


        private static readonly UnityEditorIcon _BuildSettings_PSM = BuildIcon("BuildSettings.PSM");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PSM" icon.</summary>
        public static UnityEditorIcon BuildSettings_PSM => _BuildSettings_PSM;


        private static readonly UnityEditorIcon _BuildSettings_PSM_Small = BuildIcon("BuildSettings.PSM.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PSM.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_PSM_Small => _BuildSettings_PSM_Small;


        private static readonly UnityEditorIcon _BuildSettings_PSP2 = BuildIcon("BuildSettings.PSP2");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PSP2" icon.</summary>
        public static UnityEditorIcon BuildSettings_PSP2 => _BuildSettings_PSP2;


        private static readonly UnityEditorIcon _BuildSettings_PSP2_Small = BuildIcon("BuildSettings.PSP2.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.PSP2.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_PSP2_Small => _BuildSettings_PSP2_Small;


        private static readonly UnityEditorIcon _BuildSettings_SelectedIcon = BuildIcon("BuildSettings.SelectedIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.SelectedIcon" icon.</summary>
        public static UnityEditorIcon BuildSettings_SelectedIcon => _BuildSettings_SelectedIcon;


        private static readonly UnityEditorIcon _BuildSettings_Stadia_On = BuildIcon("BuildSettings.Stadia On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia_On => _BuildSettings_Stadia_On;


        private static readonly UnityEditorIcon _BuildSettings_Stadia_On2x = BuildIcon("BuildSettings.Stadia On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia_On2x => _BuildSettings_Stadia_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Stadia = BuildIcon("BuildSettings.Stadia");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia => _BuildSettings_Stadia;


        private static readonly UnityEditorIcon _BuildSettings_Stadia_small = BuildIcon("BuildSettings.Stadia.small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia.small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia_small => _BuildSettings_Stadia_small;


        private static readonly UnityEditorIcon _BuildSettings_Stadia_Small2x = BuildIcon("BuildSettings.Stadia.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia_Small2x => _BuildSettings_Stadia_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Stadia2x = BuildIcon("BuildSettings.Stadia@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Stadia@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Stadia2x => _BuildSettings_Stadia2x;


        private static readonly UnityEditorIcon _BuildSettings_Standalone_On = BuildIcon("BuildSettings.Standalone On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone_On => _BuildSettings_Standalone_On;


        private static readonly UnityEditorIcon _BuildSettings_Standalone_On2x = BuildIcon("BuildSettings.Standalone On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone_On2x => _BuildSettings_Standalone_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Standalone = BuildIcon("BuildSettings.Standalone");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone => _BuildSettings_Standalone;


        private static readonly UnityEditorIcon _BuildSettings_Standalone_Small = BuildIcon("BuildSettings.Standalone.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone_Small => _BuildSettings_Standalone_Small;


        private static readonly UnityEditorIcon _BuildSettings_Standalone_Small2x = BuildIcon("BuildSettings.Standalone.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone_Small2x => _BuildSettings_Standalone_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Standalone2x = BuildIcon("BuildSettings.Standalone@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Standalone@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Standalone2x => _BuildSettings_Standalone2x;


        private static readonly UnityEditorIcon _BuildSettings_StandaloneBroadcom_Small = BuildIcon("BuildSettings.StandaloneBroadcom.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.StandaloneBroadcom.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_StandaloneBroadcom_Small => _BuildSettings_StandaloneBroadcom_Small;


        private static readonly UnityEditorIcon _BuildSettings_StandaloneGLES20Emu_Small = BuildIcon("BuildSettings.StandaloneGLES20Emu.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.StandaloneGLES20Emu.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_StandaloneGLES20Emu_Small => _BuildSettings_StandaloneGLES20Emu_Small;


        private static readonly UnityEditorIcon _BuildSettings_StandaloneGLESEmu = BuildIcon("BuildSettings.StandaloneGLESEmu");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.StandaloneGLESEmu" icon.</summary>
        public static UnityEditorIcon BuildSettings_StandaloneGLESEmu => _BuildSettings_StandaloneGLESEmu;


        private static readonly UnityEditorIcon _BuildSettings_StandaloneGLESEmu_Small = BuildIcon("BuildSettings.StandaloneGLESEmu.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.StandaloneGLESEmu.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_StandaloneGLESEmu_Small => _BuildSettings_StandaloneGLESEmu_Small;


        private static readonly UnityEditorIcon _BuildSettings_Switch_On = BuildIcon("BuildSettings.Switch On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch On" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch_On => _BuildSettings_Switch_On;


        private static readonly UnityEditorIcon _BuildSettings_Switch_On2x = BuildIcon("BuildSettings.Switch On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch_On2x => _BuildSettings_Switch_On2x;


        private static readonly UnityEditorIcon _BuildSettings_Switch = BuildIcon("BuildSettings.Switch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch => _BuildSettings_Switch;


        private static readonly UnityEditorIcon _BuildSettings_Switch_Small = BuildIcon("BuildSettings.Switch.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch_Small => _BuildSettings_Switch_Small;


        private static readonly UnityEditorIcon _BuildSettings_Switch_Small2x = BuildIcon("BuildSettings.Switch.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch_Small2x => _BuildSettings_Switch_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_Switch2x = BuildIcon("BuildSettings.Switch@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Switch@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_Switch2x => _BuildSettings_Switch2x;


        private static readonly UnityEditorIcon _BuildSettings_tvOS_On = BuildIcon("BuildSettings.tvOS On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS On" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS_On => _BuildSettings_tvOS_On;


        private static readonly UnityEditorIcon _BuildSettings_tvOS_On2x = BuildIcon("BuildSettings.tvOS On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS_On2x => _BuildSettings_tvOS_On2x;


        private static readonly UnityEditorIcon _BuildSettings_tvOS = BuildIcon("BuildSettings.tvOS");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS => _BuildSettings_tvOS;


        private static readonly UnityEditorIcon _BuildSettings_tvOS_Small = BuildIcon("BuildSettings.tvOS.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS_Small => _BuildSettings_tvOS_Small;


        private static readonly UnityEditorIcon _BuildSettings_tvOS_Small2x = BuildIcon("BuildSettings.tvOS.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS_Small2x => _BuildSettings_tvOS_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_tvOS2x = BuildIcon("BuildSettings.tvOS@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.tvOS@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_tvOS2x => _BuildSettings_tvOS2x;


        private static readonly UnityEditorIcon _BuildSettings_Web = BuildIcon("BuildSettings.Web");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Web" icon.</summary>
        public static UnityEditorIcon BuildSettings_Web => _BuildSettings_Web;


        private static readonly UnityEditorIcon _BuildSettings_Web_Small = BuildIcon("BuildSettings.Web.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Web.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Web_Small => _BuildSettings_Web_Small;


        private static readonly UnityEditorIcon _BuildSettings_WebGL_On = BuildIcon("BuildSettings.WebGL On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL On" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL_On => _BuildSettings_WebGL_On;


        private static readonly UnityEditorIcon _BuildSettings_WebGL_On2x = BuildIcon("BuildSettings.WebGL On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL_On2x => _BuildSettings_WebGL_On2x;


        private static readonly UnityEditorIcon _BuildSettings_WebGL = BuildIcon("BuildSettings.WebGL");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL => _BuildSettings_WebGL;


        private static readonly UnityEditorIcon _BuildSettings_WebGL_Small = BuildIcon("BuildSettings.WebGL.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL_Small => _BuildSettings_WebGL_Small;


        private static readonly UnityEditorIcon _BuildSettings_WebGL_Small2x = BuildIcon("BuildSettings.WebGL.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL_Small2x => _BuildSettings_WebGL_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_WebGL2x = BuildIcon("BuildSettings.WebGL@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WebGL@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_WebGL2x => _BuildSettings_WebGL2x;


        private static readonly UnityEditorIcon _BuildSettings_WP8 = BuildIcon("BuildSettings.WP8");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WP8" icon.</summary>
        public static UnityEditorIcon BuildSettings_WP8 => _BuildSettings_WP8;


        private static readonly UnityEditorIcon _BuildSettings_WP8_Small = BuildIcon("BuildSettings.WP8.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.WP8.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_WP8_Small => _BuildSettings_WP8_Small;


        private static readonly UnityEditorIcon _BuildSettings_Xbox360 = BuildIcon("BuildSettings.Xbox360");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Xbox360" icon.</summary>
        public static UnityEditorIcon BuildSettings_Xbox360 => _BuildSettings_Xbox360;


        private static readonly UnityEditorIcon _BuildSettings_Xbox360_Small = BuildIcon("BuildSettings.Xbox360.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.Xbox360.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_Xbox360_Small => _BuildSettings_Xbox360_Small;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne_On = BuildIcon("BuildSettings.XboxOne On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne On" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne_On => _BuildSettings_XboxOne_On;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne_On2x = BuildIcon("BuildSettings.XboxOne On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne On@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne_On2x => _BuildSettings_XboxOne_On2x;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne = BuildIcon("BuildSettings.XboxOne");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne => _BuildSettings_XboxOne;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne_Small = BuildIcon("BuildSettings.XboxOne.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne.Small" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne_Small => _BuildSettings_XboxOne_Small;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne_Small2x = BuildIcon("BuildSettings.XboxOne.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne.Small@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne_Small2x => _BuildSettings_XboxOne_Small2x;


        private static readonly UnityEditorIcon _BuildSettings_XboxOne2x = BuildIcon("BuildSettings.XboxOne@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuildSettings.XboxOne@2x" icon.</summary>
        public static UnityEditorIcon BuildSettings_XboxOne2x => _BuildSettings_XboxOne2x;


        private static readonly UnityEditorIcon _CacheServerConnected = BuildIcon("CacheServerConnected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerConnected" icon.</summary>
        public static UnityEditorIcon CacheServerConnected => _CacheServerConnected;


        private static readonly UnityEditorIcon _CacheServerConnected2x = BuildIcon("CacheServerConnected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerConnected@2x" icon.</summary>
        public static UnityEditorIcon CacheServerConnected2x => _CacheServerConnected2x;


        private static readonly UnityEditorIcon _CacheServerDisabled = BuildIcon("CacheServerDisabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerDisabled" icon.</summary>
        public static UnityEditorIcon CacheServerDisabled => _CacheServerDisabled;


        private static readonly UnityEditorIcon _CacheServerDisabled2x = BuildIcon("CacheServerDisabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerDisabled@2x" icon.</summary>
        public static UnityEditorIcon CacheServerDisabled2x => _CacheServerDisabled2x;


        private static readonly UnityEditorIcon _CacheServerDisconnected = BuildIcon("CacheServerDisconnected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerDisconnected" icon.</summary>
        public static UnityEditorIcon CacheServerDisconnected => _CacheServerDisconnected;


        private static readonly UnityEditorIcon _CacheServerDisconnected2x = BuildIcon("CacheServerDisconnected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CacheServerDisconnected@2x" icon.</summary>
        public static UnityEditorIcon CacheServerDisconnected2x => _CacheServerDisconnected2x;


        private static readonly UnityEditorIcon _CheckerFloor = BuildIcon("CheckerFloor");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CheckerFloor" icon.</summary>
        public static UnityEditorIcon CheckerFloor => _CheckerFloor;


        private static readonly UnityEditorIcon _Clipboard = BuildIcon("Clipboard");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Clipboard" icon.</summary>
        public static UnityEditorIcon Clipboard => _Clipboard;


        private static readonly UnityEditorIcon _ClothInspector_PaintTool = BuildIcon("ClothInspector.PaintTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ClothInspector.PaintTool" icon.</summary>
        public static UnityEditorIcon ClothInspector_PaintTool => _ClothInspector_PaintTool;


        private static readonly UnityEditorIcon _ClothInspector_PaintValue = BuildIcon("ClothInspector.PaintValue");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ClothInspector.PaintValue" icon.</summary>
        public static UnityEditorIcon ClothInspector_PaintValue => _ClothInspector_PaintValue;


        private static readonly UnityEditorIcon _ClothInspector_SelectTool = BuildIcon("ClothInspector.SelectTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ClothInspector.SelectTool" icon.</summary>
        public static UnityEditorIcon ClothInspector_SelectTool => _ClothInspector_SelectTool;


        private static readonly UnityEditorIcon _ClothInspector_SettingsTool = BuildIcon("ClothInspector.SettingsTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ClothInspector.SettingsTool" icon.</summary>
        public static UnityEditorIcon ClothInspector_SettingsTool => _ClothInspector_SettingsTool;


        private static readonly UnityEditorIcon _ClothInspector_ViewValue = BuildIcon("ClothInspector.ViewValue");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ClothInspector.ViewValue" icon.</summary>
        public static UnityEditorIcon ClothInspector_ViewValue => _ClothInspector_ViewValue;


        private static readonly UnityEditorIcon _CloudConnect = BuildIcon("CloudConnect");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CloudConnect" icon.</summary>
        public static UnityEditorIcon CloudConnect => _CloudConnect;


        private static readonly UnityEditorIcon _CloudConnect2x = BuildIcon("CloudConnect@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CloudConnect@2x" icon.</summary>
        public static UnityEditorIcon CloudConnect2x => _CloudConnect2x;


        private static readonly UnityEditorIcon _Collab_Build = BuildIcon("Collab.Build");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.Build" icon.</summary>
        public static UnityEditorIcon Collab_Build => _Collab_Build;


        private static readonly UnityEditorIcon _Collab_BuildFailed = BuildIcon("Collab.BuildFailed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.BuildFailed" icon.</summary>
        public static UnityEditorIcon Collab_BuildFailed => _Collab_BuildFailed;


        private static readonly UnityEditorIcon _Collab_BuildSucceeded = BuildIcon("Collab.BuildSucceeded");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.BuildSucceeded" icon.</summary>
        public static UnityEditorIcon Collab_BuildSucceeded => _Collab_BuildSucceeded;


        private static readonly UnityEditorIcon _Collab_FileAdded = BuildIcon("Collab.FileAdded");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileAdded" icon.</summary>
        public static UnityEditorIcon Collab_FileAdded => _Collab_FileAdded;


        private static readonly UnityEditorIcon _Collab_FileConflict = BuildIcon("Collab.FileConflict");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileConflict" icon.</summary>
        public static UnityEditorIcon Collab_FileConflict => _Collab_FileConflict;


        private static readonly UnityEditorIcon _Collab_FileDeleted = BuildIcon("Collab.FileDeleted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileDeleted" icon.</summary>
        public static UnityEditorIcon Collab_FileDeleted => _Collab_FileDeleted;


        private static readonly UnityEditorIcon _Collab_FileIgnored = BuildIcon("Collab.FileIgnored");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileIgnored" icon.</summary>
        public static UnityEditorIcon Collab_FileIgnored => _Collab_FileIgnored;


        private static readonly UnityEditorIcon _Collab_FileMoved = BuildIcon("Collab.FileMoved");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileMoved" icon.</summary>
        public static UnityEditorIcon Collab_FileMoved => _Collab_FileMoved;


        private static readonly UnityEditorIcon _Collab_FileUpdated = BuildIcon("Collab.FileUpdated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FileUpdated" icon.</summary>
        public static UnityEditorIcon Collab_FileUpdated => _Collab_FileUpdated;


        private static readonly UnityEditorIcon _Collab_FolderAdded = BuildIcon("Collab.FolderAdded");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderAdded" icon.</summary>
        public static UnityEditorIcon Collab_FolderAdded => _Collab_FolderAdded;


        private static readonly UnityEditorIcon _Collab_FolderConflict = BuildIcon("Collab.FolderConflict");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderConflict" icon.</summary>
        public static UnityEditorIcon Collab_FolderConflict => _Collab_FolderConflict;


        private static readonly UnityEditorIcon _Collab_FolderDeleted = BuildIcon("Collab.FolderDeleted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderDeleted" icon.</summary>
        public static UnityEditorIcon Collab_FolderDeleted => _Collab_FolderDeleted;


        private static readonly UnityEditorIcon _Collab_FolderIgnored = BuildIcon("Collab.FolderIgnored");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderIgnored" icon.</summary>
        public static UnityEditorIcon Collab_FolderIgnored => _Collab_FolderIgnored;


        private static readonly UnityEditorIcon _Collab_FolderMoved = BuildIcon("Collab.FolderMoved");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderMoved" icon.</summary>
        public static UnityEditorIcon Collab_FolderMoved => _Collab_FolderMoved;


        private static readonly UnityEditorIcon _Collab_FolderUpdated = BuildIcon("Collab.FolderUpdated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.FolderUpdated" icon.</summary>
        public static UnityEditorIcon Collab_FolderUpdated => _Collab_FolderUpdated;


        private static readonly UnityEditorIcon _Collab_NoInternet = BuildIcon("Collab.NoInternet");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.NoInternet" icon.</summary>
        public static UnityEditorIcon Collab_NoInternet => _Collab_NoInternet;


        private static readonly UnityEditorIcon _Collab = BuildIcon("Collab");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab" icon.</summary>
        public static UnityEditorIcon Collab => _Collab;


        private static readonly UnityEditorIcon _Collab_Warning = BuildIcon("Collab.Warning");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab.Warning" icon.</summary>
        public static UnityEditorIcon Collab_Warning => _Collab_Warning;


        private static readonly UnityEditorIcon _Collab2x = BuildIcon("Collab@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Collab@2x" icon.</summary>
        public static UnityEditorIcon Collab2x => _Collab2x;


        private static readonly UnityEditorIcon _CollabConflict = BuildIcon("CollabConflict");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabConflict" icon.</summary>
        public static UnityEditorIcon CollabConflict => _CollabConflict;


        private static readonly UnityEditorIcon _CollabError = BuildIcon("CollabError");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabError" icon.</summary>
        public static UnityEditorIcon CollabError => _CollabError;


        private static readonly UnityEditorIcon _CollabNew = BuildIcon("CollabNew");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabNew" icon.</summary>
        public static UnityEditorIcon CollabNew => _CollabNew;


        private static readonly UnityEditorIcon _CollabOffline = BuildIcon("CollabOffline");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabOffline" icon.</summary>
        public static UnityEditorIcon CollabOffline => _CollabOffline;


        private static readonly UnityEditorIcon _CollabProgress = BuildIcon("CollabProgress");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabProgress" icon.</summary>
        public static UnityEditorIcon CollabProgress => _CollabProgress;


        private static readonly UnityEditorIcon _CollabPull = BuildIcon("CollabPull");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabPull" icon.</summary>
        public static UnityEditorIcon CollabPull => _CollabPull;


        private static readonly UnityEditorIcon _CollabPush = BuildIcon("CollabPush");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabPush" icon.</summary>
        public static UnityEditorIcon CollabPush => _CollabPush;


        private static readonly UnityEditorIcon _ColorPicker_ColorCycle = BuildIcon("ColorPicker.ColorCycle");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ColorPicker.ColorCycle" icon.</summary>
        public static UnityEditorIcon ColorPicker_ColorCycle => _ColorPicker_ColorCycle;


        private static readonly UnityEditorIcon _ColorPicker_CycleColor = BuildIcon("ColorPicker.CycleColor");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ColorPicker.CycleColor" icon.</summary>
        public static UnityEditorIcon ColorPicker_CycleColor => _ColorPicker_CycleColor;


        private static readonly UnityEditorIcon _ColorPicker_CycleSlider = BuildIcon("ColorPicker.CycleSlider");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ColorPicker.CycleSlider" icon.</summary>
        public static UnityEditorIcon ColorPicker_CycleSlider => _ColorPicker_CycleSlider;


        private static readonly UnityEditorIcon _ColorPicker_SliderCycle = BuildIcon("ColorPicker.SliderCycle");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ColorPicker.SliderCycle" icon.</summary>
        public static UnityEditorIcon ColorPicker_SliderCycle => _ColorPicker_SliderCycle;


        private static readonly UnityEditorIcon _console_erroricon_inactive_sml = BuildIcon("console.erroricon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon.inactive.sml" icon.</summary>
        public static UnityEditorIcon console_erroricon_inactive_sml => _console_erroricon_inactive_sml;


        private static readonly UnityEditorIcon _console_erroricon_inactive_sml2x = BuildIcon("console.erroricon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon console_erroricon_inactive_sml2x => _console_erroricon_inactive_sml2x;


        private static readonly UnityEditorIcon _console_erroricon = BuildIcon("console.erroricon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon" icon.</summary>
        public static UnityEditorIcon console_erroricon => _console_erroricon;


        private static readonly UnityEditorIcon _console_erroricon_sml = BuildIcon("console.erroricon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon.sml" icon.</summary>
        public static UnityEditorIcon console_erroricon_sml => _console_erroricon_sml;


        private static readonly UnityEditorIcon _console_erroricon_sml2x = BuildIcon("console.erroricon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon.sml@2x" icon.</summary>
        public static UnityEditorIcon console_erroricon_sml2x => _console_erroricon_sml2x;


        private static readonly UnityEditorIcon _console_erroricon2x = BuildIcon("console.erroricon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.erroricon@2x" icon.</summary>
        public static UnityEditorIcon console_erroricon2x => _console_erroricon2x;


        private static readonly UnityEditorIcon _console_infoicon_inactive_sml = BuildIcon("console.infoicon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon.inactive.sml" icon.</summary>
        public static UnityEditorIcon console_infoicon_inactive_sml => _console_infoicon_inactive_sml;


        private static readonly UnityEditorIcon _console_infoicon_inactive_sml2x = BuildIcon("console.infoicon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon console_infoicon_inactive_sml2x => _console_infoicon_inactive_sml2x;


        private static readonly UnityEditorIcon _console_infoicon = BuildIcon("console.infoicon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon" icon.</summary>
        public static UnityEditorIcon console_infoicon => _console_infoicon;


        private static readonly UnityEditorIcon _console_infoicon_sml = BuildIcon("console.infoicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon.sml" icon.</summary>
        public static UnityEditorIcon console_infoicon_sml => _console_infoicon_sml;


        private static readonly UnityEditorIcon _console_infoicon_sml2x = BuildIcon("console.infoicon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon.sml@2x" icon.</summary>
        public static UnityEditorIcon console_infoicon_sml2x => _console_infoicon_sml2x;


        private static readonly UnityEditorIcon _console_infoicon2x = BuildIcon("console.infoicon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.infoicon@2x" icon.</summary>
        public static UnityEditorIcon console_infoicon2x => _console_infoicon2x;


        private static readonly UnityEditorIcon _console_warnicon_inactive_sml = BuildIcon("console.warnicon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon.inactive.sml" icon.</summary>
        public static UnityEditorIcon console_warnicon_inactive_sml => _console_warnicon_inactive_sml;


        private static readonly UnityEditorIcon _console_warnicon_inactive_sml2x = BuildIcon("console.warnicon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon console_warnicon_inactive_sml2x => _console_warnicon_inactive_sml2x;


        private static readonly UnityEditorIcon _console_warnicon = BuildIcon("console.warnicon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon" icon.</summary>
        public static UnityEditorIcon console_warnicon => _console_warnicon;


        private static readonly UnityEditorIcon _console_warnicon_sml = BuildIcon("console.warnicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon.sml" icon.</summary>
        public static UnityEditorIcon console_warnicon_sml => _console_warnicon_sml;


        private static readonly UnityEditorIcon _console_warnicon_sml2x = BuildIcon("console.warnicon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon.sml@2x" icon.</summary>
        public static UnityEditorIcon console_warnicon_sml2x => _console_warnicon_sml2x;


        private static readonly UnityEditorIcon _console_warnicon2x = BuildIcon("console.warnicon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "console.warnicon@2x" icon.</summary>
        public static UnityEditorIcon console_warnicon2x => _console_warnicon2x;


        private static readonly UnityEditorIcon _CreateAddNew = BuildIcon("CreateAddNew");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CreateAddNew" icon.</summary>
        public static UnityEditorIcon CreateAddNew => _CreateAddNew;


        private static readonly UnityEditorIcon _CreateAddNew2x = BuildIcon("CreateAddNew@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CreateAddNew@2x" icon.</summary>
        public static UnityEditorIcon CreateAddNew2x => _CreateAddNew2x;


        private static readonly UnityEditorIcon _CrossIcon = BuildIcon("CrossIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CrossIcon" icon.</summary>
        public static UnityEditorIcon CrossIcon => _CrossIcon;


        private static readonly UnityEditorIcon _curvekeyframe = BuildIcon("curvekeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframe" icon.</summary>
        public static UnityEditorIcon curvekeyframe => _curvekeyframe;


        private static readonly UnityEditorIcon _curvekeyframe2x = BuildIcon("curvekeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframe@2x" icon.</summary>
        public static UnityEditorIcon curvekeyframe2x => _curvekeyframe2x;


        private static readonly UnityEditorIcon _curvekeyframeselected = BuildIcon("curvekeyframeselected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeselected" icon.</summary>
        public static UnityEditorIcon curvekeyframeselected => _curvekeyframeselected;


        private static readonly UnityEditorIcon _curvekeyframeselected2x = BuildIcon("curvekeyframeselected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeselected@2x" icon.</summary>
        public static UnityEditorIcon curvekeyframeselected2x => _curvekeyframeselected2x;


        private static readonly UnityEditorIcon _curvekeyframeselectedoverlay = BuildIcon("curvekeyframeselectedoverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeselectedoverlay" icon.</summary>
        public static UnityEditorIcon curvekeyframeselectedoverlay => _curvekeyframeselectedoverlay;


        private static readonly UnityEditorIcon _curvekeyframeselectedoverlay2x = BuildIcon("curvekeyframeselectedoverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeselectedoverlay@2x" icon.</summary>
        public static UnityEditorIcon curvekeyframeselectedoverlay2x => _curvekeyframeselectedoverlay2x;


        private static readonly UnityEditorIcon _curvekeyframesemiselectedoverlay = BuildIcon("curvekeyframesemiselectedoverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframesemiselectedoverlay" icon.</summary>
        public static UnityEditorIcon curvekeyframesemiselectedoverlay => _curvekeyframesemiselectedoverlay;


        private static readonly UnityEditorIcon _curvekeyframesemiselectedoverlay2x = BuildIcon("curvekeyframesemiselectedoverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframesemiselectedoverlay@2x" icon.</summary>
        public static UnityEditorIcon curvekeyframesemiselectedoverlay2x => _curvekeyframesemiselectedoverlay2x;


        private static readonly UnityEditorIcon _curvekeyframeweighted = BuildIcon("curvekeyframeweighted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeweighted" icon.</summary>
        public static UnityEditorIcon curvekeyframeweighted => _curvekeyframeweighted;


        private static readonly UnityEditorIcon _curvekeyframeweighted2x = BuildIcon("curvekeyframeweighted@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "curvekeyframeweighted@2x" icon.</summary>
        public static UnityEditorIcon curvekeyframeweighted2x => _curvekeyframeweighted2x;


        private static readonly UnityEditorIcon _CustomSorting = BuildIcon("CustomSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CustomSorting" icon.</summary>
        public static UnityEditorIcon CustomSorting => _CustomSorting;


        private static readonly UnityEditorIcon _CustomTool = BuildIcon("CustomTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CustomTool" icon.</summary>
        public static UnityEditorIcon CustomTool => _CustomTool;


        private static readonly UnityEditorIcon _CustomTool2x = BuildIcon("CustomTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CustomTool@2x" icon.</summary>
        public static UnityEditorIcon CustomTool2x => _CustomTool2x;


        private static readonly UnityEditorIcon _d__Help = BuildIcon("d__Help");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Help" icon.</summary>
        public static UnityEditorIcon d__Help => _d__Help;


        private static readonly UnityEditorIcon _d__Help2x = BuildIcon("d__Help@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Help@2x" icon.</summary>
        public static UnityEditorIcon d__Help2x => _d__Help2x;


        private static readonly UnityEditorIcon _d__Menu = BuildIcon("d__Menu");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Menu" icon.</summary>
        public static UnityEditorIcon d__Menu => _d__Menu;


        private static readonly UnityEditorIcon _d__Menu2x = BuildIcon("d__Menu@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Menu@2x" icon.</summary>
        public static UnityEditorIcon d__Menu2x => _d__Menu2x;


        private static readonly UnityEditorIcon _d__Popup = BuildIcon("d__Popup");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Popup" icon.</summary>
        public static UnityEditorIcon d__Popup => _d__Popup;


        private static readonly UnityEditorIcon _d__Popup2x = BuildIcon("d__Popup@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d__Popup@2x" icon.</summary>
        public static UnityEditorIcon d__Popup2x => _d__Popup2x;


        private static readonly UnityEditorIcon _d_aboutwindow_mainheader = BuildIcon("d_aboutwindow.mainheader");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_aboutwindow.mainheader" icon.</summary>
        public static UnityEditorIcon d_aboutwindow_mainheader => _d_aboutwindow_mainheader;


        private static readonly UnityEditorIcon _d_ageialogo = BuildIcon("d_ageialogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ageialogo" icon.</summary>
        public static UnityEditorIcon d_ageialogo => _d_ageialogo;


        private static readonly UnityEditorIcon _d_AlphabeticalSorting = BuildIcon("d_AlphabeticalSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AlphabeticalSorting" icon.</summary>
        public static UnityEditorIcon d_AlphabeticalSorting => _d_AlphabeticalSorting;


        private static readonly UnityEditorIcon _d_AlphabeticalSorting2x = BuildIcon("d_AlphabeticalSorting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AlphabeticalSorting@2x" icon.</summary>
        public static UnityEditorIcon d_AlphabeticalSorting2x => _d_AlphabeticalSorting2x;


        private static readonly UnityEditorIcon _d_Animation_AddEvent = BuildIcon("d_Animation.AddEvent");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.AddEvent" icon.</summary>
        public static UnityEditorIcon d_Animation_AddEvent => _d_Animation_AddEvent;


        private static readonly UnityEditorIcon _d_Animation_AddEvent2x = BuildIcon("d_Animation.AddEvent@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.AddEvent@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_AddEvent2x => _d_Animation_AddEvent2x;


        private static readonly UnityEditorIcon _d_Animation_AddKeyframe = BuildIcon("d_Animation.AddKeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.AddKeyframe" icon.</summary>
        public static UnityEditorIcon d_Animation_AddKeyframe => _d_Animation_AddKeyframe;


        private static readonly UnityEditorIcon _d_Animation_AddKeyframe2x = BuildIcon("d_Animation.AddKeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.AddKeyframe@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_AddKeyframe2x => _d_Animation_AddKeyframe2x;


        private static readonly UnityEditorIcon _d_Animation_EventMarker = BuildIcon("d_Animation.EventMarker");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.EventMarker" icon.</summary>
        public static UnityEditorIcon d_Animation_EventMarker => _d_Animation_EventMarker;


        private static readonly UnityEditorIcon _d_Animation_EventMarker2x = BuildIcon("d_Animation.EventMarker@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.EventMarker@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_EventMarker2x => _d_Animation_EventMarker2x;


        private static readonly UnityEditorIcon _d_Animation_FilterBySelection = BuildIcon("d_Animation.FilterBySelection");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.FilterBySelection" icon.</summary>
        public static UnityEditorIcon d_Animation_FilterBySelection => _d_Animation_FilterBySelection;


        private static readonly UnityEditorIcon _d_Animation_FilterBySelection2x = BuildIcon("d_Animation.FilterBySelection@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.FilterBySelection@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_FilterBySelection2x => _d_Animation_FilterBySelection2x;


        private static readonly UnityEditorIcon _d_Animation_FirstKey = BuildIcon("d_Animation.FirstKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.FirstKey" icon.</summary>
        public static UnityEditorIcon d_Animation_FirstKey => _d_Animation_FirstKey;


        private static readonly UnityEditorIcon _d_Animation_FirstKey2x = BuildIcon("d_Animation.FirstKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.FirstKey@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_FirstKey2x => _d_Animation_FirstKey2x;


        private static readonly UnityEditorIcon _d_Animation_LastKey = BuildIcon("d_Animation.LastKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.LastKey" icon.</summary>
        public static UnityEditorIcon d_Animation_LastKey => _d_Animation_LastKey;


        private static readonly UnityEditorIcon _d_Animation_LastKey2x = BuildIcon("d_Animation.LastKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.LastKey@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_LastKey2x => _d_Animation_LastKey2x;


        private static readonly UnityEditorIcon _d_Animation_NextKey = BuildIcon("d_Animation.NextKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.NextKey" icon.</summary>
        public static UnityEditorIcon d_Animation_NextKey => _d_Animation_NextKey;


        private static readonly UnityEditorIcon _d_Animation_NextKey2x = BuildIcon("d_Animation.NextKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.NextKey@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_NextKey2x => _d_Animation_NextKey2x;


        private static readonly UnityEditorIcon _d_Animation_Play = BuildIcon("d_Animation.Play");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.Play" icon.</summary>
        public static UnityEditorIcon d_Animation_Play => _d_Animation_Play;


        private static readonly UnityEditorIcon _d_Animation_Play2x = BuildIcon("d_Animation.Play@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.Play@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_Play2x => _d_Animation_Play2x;


        private static readonly UnityEditorIcon _d_Animation_PrevKey = BuildIcon("d_Animation.PrevKey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.PrevKey" icon.</summary>
        public static UnityEditorIcon d_Animation_PrevKey => _d_Animation_PrevKey;


        private static readonly UnityEditorIcon _d_Animation_PrevKey2x = BuildIcon("d_Animation.PrevKey@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.PrevKey@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_PrevKey2x => _d_Animation_PrevKey2x;


        private static readonly UnityEditorIcon _d_Animation_Record = BuildIcon("d_Animation.Record");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.Record" icon.</summary>
        public static UnityEditorIcon d_Animation_Record => _d_Animation_Record;


        private static readonly UnityEditorIcon _d_Animation_Record2x = BuildIcon("d_Animation.Record@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.Record@2x" icon.</summary>
        public static UnityEditorIcon d_Animation_Record2x => _d_Animation_Record2x;


        private static readonly UnityEditorIcon _d_Animation_SequencerLink = BuildIcon("d_Animation.SequencerLink");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation.SequencerLink" icon.</summary>
        public static UnityEditorIcon d_Animation_SequencerLink => _d_Animation_SequencerLink;


        private static readonly UnityEditorIcon _d_animationanimated = BuildIcon("d_animationanimated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationanimated" icon.</summary>
        public static UnityEditorIcon d_animationanimated => _d_animationanimated;


        private static readonly UnityEditorIcon _d_animationanimated2x = BuildIcon("d_animationanimated@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationanimated@2x" icon.</summary>
        public static UnityEditorIcon d_animationanimated2x => _d_animationanimated2x;


        private static readonly UnityEditorIcon _d_animationkeyframe = BuildIcon("d_animationkeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationkeyframe" icon.</summary>
        public static UnityEditorIcon d_animationkeyframe => _d_animationkeyframe;


        private static readonly UnityEditorIcon _d_animationkeyframe2x = BuildIcon("d_animationkeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationkeyframe@2x" icon.</summary>
        public static UnityEditorIcon d_animationkeyframe2x => _d_animationkeyframe2x;


        private static readonly UnityEditorIcon _d_animationnocurve = BuildIcon("d_animationnocurve");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationnocurve" icon.</summary>
        public static UnityEditorIcon d_animationnocurve => _d_animationnocurve;


        private static readonly UnityEditorIcon _d_animationvisibilitytoggleoff = BuildIcon("d_animationvisibilitytoggleoff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationvisibilitytoggleoff" icon.</summary>
        public static UnityEditorIcon d_animationvisibilitytoggleoff => _d_animationvisibilitytoggleoff;


        private static readonly UnityEditorIcon _d_animationvisibilitytoggleoff2x = BuildIcon("d_animationvisibilitytoggleoff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationvisibilitytoggleoff@2x" icon.</summary>
        public static UnityEditorIcon d_animationvisibilitytoggleoff2x => _d_animationvisibilitytoggleoff2x;


        private static readonly UnityEditorIcon _d_animationvisibilitytoggleon = BuildIcon("d_animationvisibilitytoggleon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationvisibilitytoggleon" icon.</summary>
        public static UnityEditorIcon d_animationvisibilitytoggleon => _d_animationvisibilitytoggleon;


        private static readonly UnityEditorIcon _d_animationvisibilitytoggleon2x = BuildIcon("d_animationvisibilitytoggleon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_animationvisibilitytoggleon@2x" icon.</summary>
        public static UnityEditorIcon d_animationvisibilitytoggleon2x => _d_animationvisibilitytoggleon2x;


        private static readonly UnityEditorIcon _d_AnimationWrapModeMenu = BuildIcon("d_AnimationWrapModeMenu");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimationWrapModeMenu" icon.</summary>
        public static UnityEditorIcon d_AnimationWrapModeMenu => _d_AnimationWrapModeMenu;


        private static readonly UnityEditorIcon _d_AS_Badge_Delete = BuildIcon("d_AS Badge Delete");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AS Badge Delete" icon.</summary>
        public static UnityEditorIcon d_AS_Badge_Delete => _d_AS_Badge_Delete;


        private static readonly UnityEditorIcon _d_AS_Badge_New = BuildIcon("d_AS Badge New");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AS Badge New" icon.</summary>
        public static UnityEditorIcon d_AS_Badge_New => _d_AS_Badge_New;


        private static readonly UnityEditorIcon _d_AssemblyLock = BuildIcon("d_AssemblyLock");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AssemblyLock" icon.</summary>
        public static UnityEditorIcon d_AssemblyLock => _d_AssemblyLock;


        private static readonly UnityEditorIcon _d_Asset_Store = BuildIcon("d_Asset Store");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Asset Store" icon.</summary>
        public static UnityEditorIcon d_Asset_Store => _d_Asset_Store;


        private static readonly UnityEditorIcon _d_Asset_Store2x = BuildIcon("d_Asset Store@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Asset Store@2x" icon.</summary>
        public static UnityEditorIcon d_Asset_Store2x => _d_Asset_Store2x;


        private static readonly UnityEditorIcon _d_Audio_Mixer = BuildIcon("d_Audio Mixer");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Audio Mixer" icon.</summary>
        public static UnityEditorIcon d_Audio_Mixer => _d_Audio_Mixer;


        private static readonly UnityEditorIcon _d_Audio_Mixer2x = BuildIcon("d_Audio Mixer@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Audio Mixer@2x" icon.</summary>
        public static UnityEditorIcon d_Audio_Mixer2x => _d_Audio_Mixer2x;


        private static readonly UnityEditorIcon _d_AutoLightbakingOff = BuildIcon("d_AutoLightbakingOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AutoLightbakingOff" icon.</summary>
        public static UnityEditorIcon d_AutoLightbakingOff => _d_AutoLightbakingOff;


        private static readonly UnityEditorIcon _d_AutoLightbakingOff2x = BuildIcon("d_AutoLightbakingOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AutoLightbakingOff@2x" icon.</summary>
        public static UnityEditorIcon d_AutoLightbakingOff2x => _d_AutoLightbakingOff2x;


        private static readonly UnityEditorIcon _d_AutoLightbakingOn = BuildIcon("d_AutoLightbakingOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AutoLightbakingOn" icon.</summary>
        public static UnityEditorIcon d_AutoLightbakingOn => _d_AutoLightbakingOn;


        private static readonly UnityEditorIcon _d_AutoLightbakingOn2x = BuildIcon("d_AutoLightbakingOn@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AutoLightbakingOn@2x" icon.</summary>
        public static UnityEditorIcon d_AutoLightbakingOn2x => _d_AutoLightbakingOn2x;


        private static readonly UnityEditorIcon _d_AvatarBlendBackground = BuildIcon("d_AvatarBlendBackground");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarBlendBackground" icon.</summary>
        public static UnityEditorIcon d_AvatarBlendBackground => _d_AvatarBlendBackground;


        private static readonly UnityEditorIcon _d_AvatarBlendLeft = BuildIcon("d_AvatarBlendLeft");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarBlendLeft" icon.</summary>
        public static UnityEditorIcon d_AvatarBlendLeft => _d_AvatarBlendLeft;


        private static readonly UnityEditorIcon _d_AvatarBlendLeftA = BuildIcon("d_AvatarBlendLeftA");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarBlendLeftA" icon.</summary>
        public static UnityEditorIcon d_AvatarBlendLeftA => _d_AvatarBlendLeftA;


        private static readonly UnityEditorIcon _d_AvatarBlendRight = BuildIcon("d_AvatarBlendRight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarBlendRight" icon.</summary>
        public static UnityEditorIcon d_AvatarBlendRight => _d_AvatarBlendRight;


        private static readonly UnityEditorIcon _d_AvatarBlendRightA = BuildIcon("d_AvatarBlendRightA");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarBlendRightA" icon.</summary>
        public static UnityEditorIcon d_AvatarBlendRightA => _d_AvatarBlendRightA;


        private static readonly UnityEditorIcon _d_AvatarCompass = BuildIcon("d_AvatarCompass");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarCompass" icon.</summary>
        public static UnityEditorIcon d_AvatarCompass => _d_AvatarCompass;


        private static readonly UnityEditorIcon _d_AvatarPivot = BuildIcon("d_AvatarPivot");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarPivot" icon.</summary>
        public static UnityEditorIcon d_AvatarPivot => _d_AvatarPivot;


        private static readonly UnityEditorIcon _d_AvatarPivot2x = BuildIcon("d_AvatarPivot@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarPivot@2x" icon.</summary>
        public static UnityEditorIcon d_AvatarPivot2x => _d_AvatarPivot2x;


        private static readonly UnityEditorIcon _d_AvatarSelector = BuildIcon("d_AvatarSelector");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarSelector" icon.</summary>
        public static UnityEditorIcon d_AvatarSelector => _d_AvatarSelector;


        private static readonly UnityEditorIcon _d_AvatarSelector2x = BuildIcon("d_AvatarSelector@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarSelector@2x" icon.</summary>
        public static UnityEditorIcon d_AvatarSelector2x => _d_AvatarSelector2x;


        private static readonly UnityEditorIcon _d_back = BuildIcon("d_back");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_back" icon.</summary>
        public static UnityEditorIcon d_back => _d_back;


        private static readonly UnityEditorIcon _d_back2x = BuildIcon("d_back@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_back@2x" icon.</summary>
        public static UnityEditorIcon d_back2x => _d_back2x;


        private static readonly UnityEditorIcon _d_beginButton_On = BuildIcon("d_beginButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_beginButton-On" icon.</summary>
        public static UnityEditorIcon d_beginButton_On => _d_beginButton_On;


        private static readonly UnityEditorIcon _d_beginButton = BuildIcon("d_beginButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_beginButton" icon.</summary>
        public static UnityEditorIcon d_beginButton => _d_beginButton;


        private static readonly UnityEditorIcon _d_blueGroove = BuildIcon("d_blueGroove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_blueGroove" icon.</summary>
        public static UnityEditorIcon d_blueGroove => _d_blueGroove;


        private static readonly UnityEditorIcon _d_BuildSettings_Android = BuildIcon("d_BuildSettings.Android");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Android" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Android => _d_BuildSettings_Android;


        private static readonly UnityEditorIcon _d_BuildSettings_Android_Small = BuildIcon("d_BuildSettings.Android.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Android.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Android_Small => _d_BuildSettings_Android_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Android_Small2x = BuildIcon("d_BuildSettings.Android.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Android.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Android_Small2x => _d_BuildSettings_Android_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Android2x = BuildIcon("d_BuildSettings.Android@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Android@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Android2x => _d_BuildSettings_Android2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Broadcom = BuildIcon("d_BuildSettings.Broadcom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Broadcom" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Broadcom => _d_BuildSettings_Broadcom;


        private static readonly UnityEditorIcon _d_BuildSettings_Facebook = BuildIcon("d_BuildSettings.Facebook");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Facebook" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Facebook => _d_BuildSettings_Facebook;


        private static readonly UnityEditorIcon _d_BuildSettings_Facebook_Small = BuildIcon("d_BuildSettings.Facebook.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Facebook.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Facebook_Small => _d_BuildSettings_Facebook_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Facebook_Small2x = BuildIcon("d_BuildSettings.Facebook.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Facebook.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Facebook_Small2x => _d_BuildSettings_Facebook_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Facebook2x = BuildIcon("d_BuildSettings.Facebook@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Facebook@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Facebook2x => _d_BuildSettings_Facebook2x;


        private static readonly UnityEditorIcon _d_BuildSettings_FlashPlayer = BuildIcon("d_BuildSettings.FlashPlayer");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.FlashPlayer" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_FlashPlayer => _d_BuildSettings_FlashPlayer;


        private static readonly UnityEditorIcon _d_BuildSettings_FlashPlayer_Small = BuildIcon("d_BuildSettings.FlashPlayer.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.FlashPlayer.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_FlashPlayer_Small => _d_BuildSettings_FlashPlayer_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreScarlett = BuildIcon("d_BuildSettings.GameCoreScarlett");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreScarlett" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreScarlett => _d_BuildSettings_GameCoreScarlett;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreScarlett_Small = BuildIcon("d_BuildSettings.GameCoreScarlett.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreScarlett.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreScarlett_Small => _d_BuildSettings_GameCoreScarlett_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreScarlett_Small2x = BuildIcon("d_BuildSettings.GameCoreScarlett.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreScarlett.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreScarlett_Small2x => _d_BuildSettings_GameCoreScarlett_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreScarlett2x = BuildIcon("d_BuildSettings.GameCoreScarlett@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreScarlett@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreScarlett2x => _d_BuildSettings_GameCoreScarlett2x;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreXboxOne = BuildIcon("d_BuildSettings.GameCoreXboxOne");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreXboxOne" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreXboxOne => _d_BuildSettings_GameCoreXboxOne;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreXboxOne_Small = BuildIcon("d_BuildSettings.GameCoreXboxOne.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreXboxOne.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreXboxOne_Small => _d_BuildSettings_GameCoreXboxOne_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreXboxOne_Small2x = BuildIcon("d_BuildSettings.GameCoreXboxOne.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreXboxOne.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreXboxOne_Small2x => _d_BuildSettings_GameCoreXboxOne_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_GameCoreXboxOne2x = BuildIcon("d_BuildSettings.GameCoreXboxOne@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.GameCoreXboxOne@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_GameCoreXboxOne2x => _d_BuildSettings_GameCoreXboxOne2x;


        private static readonly UnityEditorIcon _d_BuildSettings_iPhone = BuildIcon("d_BuildSettings.iPhone");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.iPhone" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_iPhone => _d_BuildSettings_iPhone;


        private static readonly UnityEditorIcon _d_BuildSettings_iPhone_Small = BuildIcon("d_BuildSettings.iPhone.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.iPhone.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_iPhone_Small => _d_BuildSettings_iPhone_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_iPhone_Small2x = BuildIcon("d_BuildSettings.iPhone.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.iPhone.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_iPhone_Small2x => _d_BuildSettings_iPhone_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_iPhone2x = BuildIcon("d_BuildSettings.iPhone@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.iPhone@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_iPhone2x => _d_BuildSettings_iPhone2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Lumin = BuildIcon("d_BuildSettings.Lumin");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Lumin" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Lumin => _d_BuildSettings_Lumin;


        private static readonly UnityEditorIcon _d_BuildSettings_Lumin_small = BuildIcon("d_BuildSettings.Lumin.small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Lumin.small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Lumin_small => _d_BuildSettings_Lumin_small;


        private static readonly UnityEditorIcon _d_BuildSettings_Lumin_small2x = BuildIcon("d_BuildSettings.Lumin.small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Lumin.small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Lumin_small2x => _d_BuildSettings_Lumin_small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Lumin2x = BuildIcon("d_BuildSettings.Lumin@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Lumin@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Lumin2x => _d_BuildSettings_Lumin2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Metro = BuildIcon("d_BuildSettings.Metro");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Metro" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Metro => _d_BuildSettings_Metro;


        private static readonly UnityEditorIcon _d_BuildSettings_Metro_Small = BuildIcon("d_BuildSettings.Metro.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Metro.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Metro_Small => _d_BuildSettings_Metro_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Metro_Small2x = BuildIcon("d_BuildSettings.Metro.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Metro.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Metro_Small2x => _d_BuildSettings_Metro_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Metro2x = BuildIcon("d_BuildSettings.Metro@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Metro@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Metro2x => _d_BuildSettings_Metro2x;


        private static readonly UnityEditorIcon _d_BuildSettings_N3DS = BuildIcon("d_BuildSettings.N3DS");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.N3DS" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_N3DS => _d_BuildSettings_N3DS;


        private static readonly UnityEditorIcon _d_BuildSettings_N3DS_Small = BuildIcon("d_BuildSettings.N3DS.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.N3DS.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_N3DS_Small => _d_BuildSettings_N3DS_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_N3DS_Small2x = BuildIcon("d_BuildSettings.N3DS.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.N3DS.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_N3DS_Small2x => _d_BuildSettings_N3DS_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_N3DS2x = BuildIcon("d_BuildSettings.N3DS@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.N3DS@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_N3DS2x => _d_BuildSettings_N3DS2x;


        private static readonly UnityEditorIcon _d_BuildSettings_PS4 = BuildIcon("d_BuildSettings.PS4");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS4" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS4 => _d_BuildSettings_PS4;


        private static readonly UnityEditorIcon _d_BuildSettings_PS4_Small = BuildIcon("d_BuildSettings.PS4.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS4.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS4_Small => _d_BuildSettings_PS4_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_PS4_Small2x = BuildIcon("d_BuildSettings.PS4.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS4.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS4_Small2x => _d_BuildSettings_PS4_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_PS42x = BuildIcon("d_BuildSettings.PS4@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS4@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS42x => _d_BuildSettings_PS42x;


        private static readonly UnityEditorIcon _d_BuildSettings_PS5 = BuildIcon("d_BuildSettings.PS5");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS5" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS5 => _d_BuildSettings_PS5;


        private static readonly UnityEditorIcon _d_BuildSettings_PS5_Small = BuildIcon("d_BuildSettings.PS5.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS5.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS5_Small => _d_BuildSettings_PS5_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_PS5_Small2x = BuildIcon("d_BuildSettings.PS5.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS5.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS5_Small2x => _d_BuildSettings_PS5_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_PS52x = BuildIcon("d_BuildSettings.PS5@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PS5@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PS52x => _d_BuildSettings_PS52x;


        private static readonly UnityEditorIcon _d_BuildSettings_PSP2 = BuildIcon("d_BuildSettings.PSP2");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PSP2" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PSP2 => _d_BuildSettings_PSP2;


        private static readonly UnityEditorIcon _d_BuildSettings_PSP2_Small = BuildIcon("d_BuildSettings.PSP2.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.PSP2.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_PSP2_Small => _d_BuildSettings_PSP2_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_SelectedIcon = BuildIcon("d_BuildSettings.SelectedIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.SelectedIcon" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_SelectedIcon => _d_BuildSettings_SelectedIcon;


        private static readonly UnityEditorIcon _d_BuildSettings_Stadia = BuildIcon("d_BuildSettings.Stadia");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Stadia" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Stadia => _d_BuildSettings_Stadia;


        private static readonly UnityEditorIcon _d_BuildSettings_Stadia_Small = BuildIcon("d_BuildSettings.Stadia.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Stadia.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Stadia_Small => _d_BuildSettings_Stadia_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Stadia_Small2x = BuildIcon("d_BuildSettings.Stadia.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Stadia.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Stadia_Small2x => _d_BuildSettings_Stadia_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Stadia2x = BuildIcon("d_BuildSettings.Stadia@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Stadia@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Stadia2x => _d_BuildSettings_Stadia2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Standalone = BuildIcon("d_BuildSettings.Standalone");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Standalone" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Standalone => _d_BuildSettings_Standalone;


        private static readonly UnityEditorIcon _d_BuildSettings_Standalone_Small = BuildIcon("d_BuildSettings.Standalone.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Standalone.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Standalone_Small => _d_BuildSettings_Standalone_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Standalone_Small2x = BuildIcon("d_BuildSettings.Standalone.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Standalone.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Standalone_Small2x => _d_BuildSettings_Standalone_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Standalone2x = BuildIcon("d_BuildSettings.Standalone@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Standalone@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Standalone2x => _d_BuildSettings_Standalone2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Switch = BuildIcon("d_BuildSettings.Switch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Switch" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Switch => _d_BuildSettings_Switch;


        private static readonly UnityEditorIcon _d_BuildSettings_Switch_Small = BuildIcon("d_BuildSettings.Switch.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Switch.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Switch_Small => _d_BuildSettings_Switch_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Switch_Small2x = BuildIcon("d_BuildSettings.Switch.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Switch.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Switch_Small2x => _d_BuildSettings_Switch_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Switch2x = BuildIcon("d_BuildSettings.Switch@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Switch@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Switch2x => _d_BuildSettings_Switch2x;


        private static readonly UnityEditorIcon _d_BuildSettings_tvOS = BuildIcon("d_BuildSettings.tvOS");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.tvOS" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_tvOS => _d_BuildSettings_tvOS;


        private static readonly UnityEditorIcon _d_BuildSettings_tvOS_Small = BuildIcon("d_BuildSettings.tvOS.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.tvOS.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_tvOS_Small => _d_BuildSettings_tvOS_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_tvOS_Small2x = BuildIcon("d_BuildSettings.tvOS.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.tvOS.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_tvOS_Small2x => _d_BuildSettings_tvOS_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_tvOS2x = BuildIcon("d_BuildSettings.tvOS@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.tvOS@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_tvOS2x => _d_BuildSettings_tvOS2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Web = BuildIcon("d_BuildSettings.Web");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Web" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Web => _d_BuildSettings_Web;


        private static readonly UnityEditorIcon _d_BuildSettings_Web_Small = BuildIcon("d_BuildSettings.Web.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Web.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Web_Small => _d_BuildSettings_Web_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_WebGL = BuildIcon("d_BuildSettings.WebGL");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.WebGL" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_WebGL => _d_BuildSettings_WebGL;


        private static readonly UnityEditorIcon _d_BuildSettings_WebGL_Small = BuildIcon("d_BuildSettings.WebGL.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.WebGL.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_WebGL_Small => _d_BuildSettings_WebGL_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_WebGL_Small2x = BuildIcon("d_BuildSettings.WebGL.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.WebGL.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_WebGL_Small2x => _d_BuildSettings_WebGL_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_WebGL2x = BuildIcon("d_BuildSettings.WebGL@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.WebGL@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_WebGL2x => _d_BuildSettings_WebGL2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Xbox360 = BuildIcon("d_BuildSettings.Xbox360");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xbox360" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xbox360 => _d_BuildSettings_Xbox360;


        private static readonly UnityEditorIcon _d_BuildSettings_Xbox360_Small = BuildIcon("d_BuildSettings.Xbox360.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xbox360.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xbox360_Small => _d_BuildSettings_Xbox360_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_XboxOne = BuildIcon("d_BuildSettings.XboxOne");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.XboxOne" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_XboxOne => _d_BuildSettings_XboxOne;


        private static readonly UnityEditorIcon _d_BuildSettings_XboxOne_Small = BuildIcon("d_BuildSettings.XboxOne.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.XboxOne.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_XboxOne_Small => _d_BuildSettings_XboxOne_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_XboxOne_Small2x = BuildIcon("d_BuildSettings.XboxOne.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.XboxOne.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_XboxOne_Small2x => _d_BuildSettings_XboxOne_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_XboxOne2x = BuildIcon("d_BuildSettings.XboxOne@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.XboxOne@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_XboxOne2x => _d_BuildSettings_XboxOne2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Xiaomi = BuildIcon("d_BuildSettings.Xiaomi");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xiaomi" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xiaomi => _d_BuildSettings_Xiaomi;


        private static readonly UnityEditorIcon _d_BuildSettings_Xiaomi_Small = BuildIcon("d_BuildSettings.Xiaomi.Small");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xiaomi.Small" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xiaomi_Small => _d_BuildSettings_Xiaomi_Small;


        private static readonly UnityEditorIcon _d_BuildSettings_Xiaomi_Small2x = BuildIcon("d_BuildSettings.Xiaomi.Small@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xiaomi.Small@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xiaomi_Small2x => _d_BuildSettings_Xiaomi_Small2x;


        private static readonly UnityEditorIcon _d_BuildSettings_Xiaomi2x = BuildIcon("d_BuildSettings.Xiaomi@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuildSettings.Xiaomi@2x" icon.</summary>
        public static UnityEditorIcon d_BuildSettings_Xiaomi2x => _d_BuildSettings_Xiaomi2x;


        private static readonly UnityEditorIcon _d_CacheServerConnected = BuildIcon("d_CacheServerConnected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerConnected" icon.</summary>
        public static UnityEditorIcon d_CacheServerConnected => _d_CacheServerConnected;


        private static readonly UnityEditorIcon _d_CacheServerConnected2x = BuildIcon("d_CacheServerConnected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerConnected@2x" icon.</summary>
        public static UnityEditorIcon d_CacheServerConnected2x => _d_CacheServerConnected2x;


        private static readonly UnityEditorIcon _d_CacheServerDisabled = BuildIcon("d_CacheServerDisabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerDisabled" icon.</summary>
        public static UnityEditorIcon d_CacheServerDisabled => _d_CacheServerDisabled;


        private static readonly UnityEditorIcon _d_CacheServerDisabled2x = BuildIcon("d_CacheServerDisabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerDisabled@2x" icon.</summary>
        public static UnityEditorIcon d_CacheServerDisabled2x => _d_CacheServerDisabled2x;


        private static readonly UnityEditorIcon _d_CacheServerDisconnected = BuildIcon("d_CacheServerDisconnected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerDisconnected" icon.</summary>
        public static UnityEditorIcon d_CacheServerDisconnected => _d_CacheServerDisconnected;


        private static readonly UnityEditorIcon _d_CacheServerDisconnected2x = BuildIcon("d_CacheServerDisconnected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CacheServerDisconnected@2x" icon.</summary>
        public static UnityEditorIcon d_CacheServerDisconnected2x => _d_CacheServerDisconnected2x;


        private static readonly UnityEditorIcon _d_CheckerFloor = BuildIcon("d_CheckerFloor");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CheckerFloor" icon.</summary>
        public static UnityEditorIcon d_CheckerFloor => _d_CheckerFloor;


        private static readonly UnityEditorIcon _d_CloudConnect = BuildIcon("d_CloudConnect");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CloudConnect" icon.</summary>
        public static UnityEditorIcon d_CloudConnect => _d_CloudConnect;


        private static readonly UnityEditorIcon _d_CloudConnect2x = BuildIcon("d_CloudConnect@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CloudConnect@2x" icon.</summary>
        public static UnityEditorIcon d_CloudConnect2x => _d_CloudConnect2x;


        private static readonly UnityEditorIcon _d_Collab_FileAdded = BuildIcon("d_Collab.FileAdded");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileAdded" icon.</summary>
        public static UnityEditorIcon d_Collab_FileAdded => _d_Collab_FileAdded;


        private static readonly UnityEditorIcon _d_Collab_FileConflict = BuildIcon("d_Collab.FileConflict");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileConflict" icon.</summary>
        public static UnityEditorIcon d_Collab_FileConflict => _d_Collab_FileConflict;


        private static readonly UnityEditorIcon _d_Collab_FileDeleted = BuildIcon("d_Collab.FileDeleted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileDeleted" icon.</summary>
        public static UnityEditorIcon d_Collab_FileDeleted => _d_Collab_FileDeleted;


        private static readonly UnityEditorIcon _d_Collab_FileIgnored = BuildIcon("d_Collab.FileIgnored");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileIgnored" icon.</summary>
        public static UnityEditorIcon d_Collab_FileIgnored => _d_Collab_FileIgnored;


        private static readonly UnityEditorIcon _d_Collab_FileMoved = BuildIcon("d_Collab.FileMoved");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileMoved" icon.</summary>
        public static UnityEditorIcon d_Collab_FileMoved => _d_Collab_FileMoved;


        private static readonly UnityEditorIcon _d_Collab_FileUpdated = BuildIcon("d_Collab.FileUpdated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FileUpdated" icon.</summary>
        public static UnityEditorIcon d_Collab_FileUpdated => _d_Collab_FileUpdated;


        private static readonly UnityEditorIcon _d_Collab_FolderAdded = BuildIcon("d_Collab.FolderAdded");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderAdded" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderAdded => _d_Collab_FolderAdded;


        private static readonly UnityEditorIcon _d_Collab_FolderConflict = BuildIcon("d_Collab.FolderConflict");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderConflict" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderConflict => _d_Collab_FolderConflict;


        private static readonly UnityEditorIcon _d_Collab_FolderDeleted = BuildIcon("d_Collab.FolderDeleted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderDeleted" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderDeleted => _d_Collab_FolderDeleted;


        private static readonly UnityEditorIcon _d_Collab_FolderIgnored = BuildIcon("d_Collab.FolderIgnored");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderIgnored" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderIgnored => _d_Collab_FolderIgnored;


        private static readonly UnityEditorIcon _d_Collab_FolderMoved = BuildIcon("d_Collab.FolderMoved");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderMoved" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderMoved => _d_Collab_FolderMoved;


        private static readonly UnityEditorIcon _d_Collab_FolderUpdated = BuildIcon("d_Collab.FolderUpdated");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab.FolderUpdated" icon.</summary>
        public static UnityEditorIcon d_Collab_FolderUpdated => _d_Collab_FolderUpdated;


        private static readonly UnityEditorIcon _d_Collab = BuildIcon("d_Collab");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab" icon.</summary>
        public static UnityEditorIcon d_Collab => _d_Collab;


        private static readonly UnityEditorIcon _d_Collab2x = BuildIcon("d_Collab@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Collab@2x" icon.</summary>
        public static UnityEditorIcon d_Collab2x => _d_Collab2x;


        private static readonly UnityEditorIcon _d_ColorPicker_CycleColor = BuildIcon("d_ColorPicker.CycleColor");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ColorPicker.CycleColor" icon.</summary>
        public static UnityEditorIcon d_ColorPicker_CycleColor => _d_ColorPicker_CycleColor;


        private static readonly UnityEditorIcon _d_ColorPicker_CycleSlider = BuildIcon("d_ColorPicker.CycleSlider");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ColorPicker.CycleSlider" icon.</summary>
        public static UnityEditorIcon d_ColorPicker_CycleSlider => _d_ColorPicker_CycleSlider;


        private static readonly UnityEditorIcon _d_console_erroricon_inactive_sml = BuildIcon("d_console.erroricon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon.inactive.sml" icon.</summary>
        public static UnityEditorIcon d_console_erroricon_inactive_sml => _d_console_erroricon_inactive_sml;


        private static readonly UnityEditorIcon _d_console_erroricon_inactive_sml2x = BuildIcon("d_console.erroricon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_erroricon_inactive_sml2x => _d_console_erroricon_inactive_sml2x;


        private static readonly UnityEditorIcon _d_console_erroricon = BuildIcon("d_console.erroricon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon" icon.</summary>
        public static UnityEditorIcon d_console_erroricon => _d_console_erroricon;


        private static readonly UnityEditorIcon _d_console_erroricon_sml = BuildIcon("d_console.erroricon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon.sml" icon.</summary>
        public static UnityEditorIcon d_console_erroricon_sml => _d_console_erroricon_sml;


        private static readonly UnityEditorIcon _d_console_erroricon_sml2x = BuildIcon("d_console.erroricon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_erroricon_sml2x => _d_console_erroricon_sml2x;


        private static readonly UnityEditorIcon _d_console_erroricon2x = BuildIcon("d_console.erroricon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.erroricon@2x" icon.</summary>
        public static UnityEditorIcon d_console_erroricon2x => _d_console_erroricon2x;


        private static readonly UnityEditorIcon _d_console_infoicon_inactive_sml = BuildIcon("d_console.infoicon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon.inactive.sml" icon.</summary>
        public static UnityEditorIcon d_console_infoicon_inactive_sml => _d_console_infoicon_inactive_sml;


        private static readonly UnityEditorIcon _d_console_infoicon_inactive_sml2x = BuildIcon("d_console.infoicon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_infoicon_inactive_sml2x => _d_console_infoicon_inactive_sml2x;


        private static readonly UnityEditorIcon _d_console_infoicon = BuildIcon("d_console.infoicon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon" icon.</summary>
        public static UnityEditorIcon d_console_infoicon => _d_console_infoicon;


        private static readonly UnityEditorIcon _d_console_infoicon_sml = BuildIcon("d_console.infoicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon.sml" icon.</summary>
        public static UnityEditorIcon d_console_infoicon_sml => _d_console_infoicon_sml;


        private static readonly UnityEditorIcon _d_console_infoicon_sml2x = BuildIcon("d_console.infoicon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_infoicon_sml2x => _d_console_infoicon_sml2x;


        private static readonly UnityEditorIcon _d_console_infoicon2x = BuildIcon("d_console.infoicon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.infoicon@2x" icon.</summary>
        public static UnityEditorIcon d_console_infoicon2x => _d_console_infoicon2x;


        private static readonly UnityEditorIcon _d_console_warnicon_inactive_sml = BuildIcon("d_console.warnicon.inactive.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon.inactive.sml" icon.</summary>
        public static UnityEditorIcon d_console_warnicon_inactive_sml => _d_console_warnicon_inactive_sml;


        private static readonly UnityEditorIcon _d_console_warnicon_inactive_sml2x = BuildIcon("d_console.warnicon.inactive.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon.inactive.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_warnicon_inactive_sml2x => _d_console_warnicon_inactive_sml2x;


        private static readonly UnityEditorIcon _d_console_warnicon = BuildIcon("d_console.warnicon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon" icon.</summary>
        public static UnityEditorIcon d_console_warnicon => _d_console_warnicon;


        private static readonly UnityEditorIcon _d_console_warnicon_sml = BuildIcon("d_console.warnicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon.sml" icon.</summary>
        public static UnityEditorIcon d_console_warnicon_sml => _d_console_warnicon_sml;


        private static readonly UnityEditorIcon _d_console_warnicon_sml2x = BuildIcon("d_console.warnicon.sml@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon.sml@2x" icon.</summary>
        public static UnityEditorIcon d_console_warnicon_sml2x => _d_console_warnicon_sml2x;


        private static readonly UnityEditorIcon _d_console_warnicon2x = BuildIcon("d_console.warnicon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_console.warnicon@2x" icon.</summary>
        public static UnityEditorIcon d_console_warnicon2x => _d_console_warnicon2x;


        private static readonly UnityEditorIcon _d_CreateAddNew = BuildIcon("d_CreateAddNew");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CreateAddNew" icon.</summary>
        public static UnityEditorIcon d_CreateAddNew => _d_CreateAddNew;


        private static readonly UnityEditorIcon _d_CreateAddNew2x = BuildIcon("d_CreateAddNew@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CreateAddNew@2x" icon.</summary>
        public static UnityEditorIcon d_CreateAddNew2x => _d_CreateAddNew2x;


        private static readonly UnityEditorIcon _d_curvekeyframe = BuildIcon("d_curvekeyframe");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframe" icon.</summary>
        public static UnityEditorIcon d_curvekeyframe => _d_curvekeyframe;


        private static readonly UnityEditorIcon _d_curvekeyframe2x = BuildIcon("d_curvekeyframe@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframe@2x" icon.</summary>
        public static UnityEditorIcon d_curvekeyframe2x => _d_curvekeyframe2x;


        private static readonly UnityEditorIcon _d_curvekeyframeselected = BuildIcon("d_curvekeyframeselected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeselected" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeselected => _d_curvekeyframeselected;


        private static readonly UnityEditorIcon _d_curvekeyframeselected2x = BuildIcon("d_curvekeyframeselected@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeselected@2x" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeselected2x => _d_curvekeyframeselected2x;


        private static readonly UnityEditorIcon _d_curvekeyframeselectedoverlay = BuildIcon("d_curvekeyframeselectedoverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeselectedoverlay" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeselectedoverlay => _d_curvekeyframeselectedoverlay;


        private static readonly UnityEditorIcon _d_curvekeyframeselectedoverlay2x = BuildIcon("d_curvekeyframeselectedoverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeselectedoverlay@2x" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeselectedoverlay2x => _d_curvekeyframeselectedoverlay2x;


        private static readonly UnityEditorIcon _d_curvekeyframesemiselectedoverlay = BuildIcon("d_curvekeyframesemiselectedoverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframesemiselectedoverlay" icon.</summary>
        public static UnityEditorIcon d_curvekeyframesemiselectedoverlay => _d_curvekeyframesemiselectedoverlay;


        private static readonly UnityEditorIcon _d_curvekeyframesemiselectedoverlay2x = BuildIcon("d_curvekeyframesemiselectedoverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframesemiselectedoverlay@2x" icon.</summary>
        public static UnityEditorIcon d_curvekeyframesemiselectedoverlay2x => _d_curvekeyframesemiselectedoverlay2x;


        private static readonly UnityEditorIcon _d_curvekeyframeweighted = BuildIcon("d_curvekeyframeweighted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeweighted" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeweighted => _d_curvekeyframeweighted;


        private static readonly UnityEditorIcon _d_curvekeyframeweighted2x = BuildIcon("d_curvekeyframeweighted@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_curvekeyframeweighted@2x" icon.</summary>
        public static UnityEditorIcon d_curvekeyframeweighted2x => _d_curvekeyframeweighted2x;


        private static readonly UnityEditorIcon _d_CustomSorting = BuildIcon("d_CustomSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CustomSorting" icon.</summary>
        public static UnityEditorIcon d_CustomSorting => _d_CustomSorting;


        private static readonly UnityEditorIcon _d_CustomTool = BuildIcon("d_CustomTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CustomTool" icon.</summary>
        public static UnityEditorIcon d_CustomTool => _d_CustomTool;


        private static readonly UnityEditorIcon _d_CustomTool2x = BuildIcon("d_CustomTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CustomTool@2x" icon.</summary>
        public static UnityEditorIcon d_CustomTool2x => _d_CustomTool2x;


        private static readonly UnityEditorIcon _d_DebuggerAttached = BuildIcon("d_DebuggerAttached");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerAttached" icon.</summary>
        public static UnityEditorIcon d_DebuggerAttached => _d_DebuggerAttached;


        private static readonly UnityEditorIcon _d_DebuggerAttached2x = BuildIcon("d_DebuggerAttached@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerAttached@2x" icon.</summary>
        public static UnityEditorIcon d_DebuggerAttached2x => _d_DebuggerAttached2x;


        private static readonly UnityEditorIcon _d_DebuggerDisabled = BuildIcon("d_DebuggerDisabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerDisabled" icon.</summary>
        public static UnityEditorIcon d_DebuggerDisabled => _d_DebuggerDisabled;


        private static readonly UnityEditorIcon _d_DebuggerDisabled2x = BuildIcon("d_DebuggerDisabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerDisabled@2x" icon.</summary>
        public static UnityEditorIcon d_DebuggerDisabled2x => _d_DebuggerDisabled2x;


        private static readonly UnityEditorIcon _d_DebuggerEnabled = BuildIcon("d_DebuggerEnabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerEnabled" icon.</summary>
        public static UnityEditorIcon d_DebuggerEnabled => _d_DebuggerEnabled;


        private static readonly UnityEditorIcon _d_DebuggerEnabled2x = BuildIcon("d_DebuggerEnabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DebuggerEnabled@2x" icon.</summary>
        public static UnityEditorIcon d_DebuggerEnabled2x => _d_DebuggerEnabled2x;


        private static readonly UnityEditorIcon _d_DefaultSorting = BuildIcon("d_DefaultSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DefaultSorting" icon.</summary>
        public static UnityEditorIcon d_DefaultSorting => _d_DefaultSorting;


        private static readonly UnityEditorIcon _d_DefaultSorting2x = BuildIcon("d_DefaultSorting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DefaultSorting@2x" icon.</summary>
        public static UnityEditorIcon d_DefaultSorting2x => _d_DefaultSorting2x;


        private static readonly UnityEditorIcon _d_EditCollider = BuildIcon("d_EditCollider");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_EditCollider" icon.</summary>
        public static UnityEditorIcon d_EditCollider => _d_EditCollider;


        private static readonly UnityEditorIcon _d_editcollision_16 = BuildIcon("d_editcollision_16");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editcollision_16" icon.</summary>
        public static UnityEditorIcon d_editcollision_16 => _d_editcollision_16;


        private static readonly UnityEditorIcon _d_editcollision_162x = BuildIcon("d_editcollision_16@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editcollision_16@2x" icon.</summary>
        public static UnityEditorIcon d_editcollision_162x => _d_editcollision_162x;


        private static readonly UnityEditorIcon _d_editcollision_32 = BuildIcon("d_editcollision_32");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editcollision_32" icon.</summary>
        public static UnityEditorIcon d_editcollision_32 => _d_editcollision_32;


        private static readonly UnityEditorIcon _d_editconstraints_16 = BuildIcon("d_editconstraints_16");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editconstraints_16" icon.</summary>
        public static UnityEditorIcon d_editconstraints_16 => _d_editconstraints_16;


        private static readonly UnityEditorIcon _d_editconstraints_162x = BuildIcon("d_editconstraints_16@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editconstraints_16@2x" icon.</summary>
        public static UnityEditorIcon d_editconstraints_162x => _d_editconstraints_162x;


        private static readonly UnityEditorIcon _d_editconstraints_32 = BuildIcon("d_editconstraints_32");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editconstraints_32" icon.</summary>
        public static UnityEditorIcon d_editconstraints_32 => _d_editconstraints_32;


        private static readonly UnityEditorIcon _d_editicon_sml = BuildIcon("d_editicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_editicon.sml" icon.</summary>
        public static UnityEditorIcon d_editicon_sml => _d_editicon_sml;


        private static readonly UnityEditorIcon _d_endButton_On = BuildIcon("d_endButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_endButton-On" icon.</summary>
        public static UnityEditorIcon d_endButton_On => _d_endButton_On;


        private static readonly UnityEditorIcon _d_endButton = BuildIcon("d_endButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_endButton" icon.</summary>
        public static UnityEditorIcon d_endButton => _d_endButton;


        private static readonly UnityEditorIcon _d_Exposure = BuildIcon("d_Exposure");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Exposure" icon.</summary>
        public static UnityEditorIcon d_Exposure => _d_Exposure;


        private static readonly UnityEditorIcon _d_Exposure2x = BuildIcon("d_Exposure@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Exposure@2x" icon.</summary>
        public static UnityEditorIcon d_Exposure2x => _d_Exposure2x;


        private static readonly UnityEditorIcon _d_eyeDropper_Large = BuildIcon("d_eyeDropper.Large");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_eyeDropper.Large" icon.</summary>
        public static UnityEditorIcon d_eyeDropper_Large => _d_eyeDropper_Large;


        private static readonly UnityEditorIcon _d_eyeDropper_Large2x = BuildIcon("d_eyeDropper.Large@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_eyeDropper.Large@2x" icon.</summary>
        public static UnityEditorIcon d_eyeDropper_Large2x => _d_eyeDropper_Large2x;


        private static readonly UnityEditorIcon _d_eyeDropper_sml = BuildIcon("d_eyeDropper.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_eyeDropper.sml" icon.</summary>
        public static UnityEditorIcon d_eyeDropper_sml => _d_eyeDropper_sml;


        private static readonly UnityEditorIcon _d_Favorite = BuildIcon("d_Favorite");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Favorite" icon.</summary>
        public static UnityEditorIcon d_Favorite => _d_Favorite;


        private static readonly UnityEditorIcon _d_Favorite2x = BuildIcon("d_Favorite@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Favorite@2x" icon.</summary>
        public static UnityEditorIcon d_Favorite2x => _d_Favorite2x;


        private static readonly UnityEditorIcon _d_FilterByLabel = BuildIcon("d_FilterByLabel");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterByLabel" icon.</summary>
        public static UnityEditorIcon d_FilterByLabel => _d_FilterByLabel;


        private static readonly UnityEditorIcon _d_FilterByLabel2x = BuildIcon("d_FilterByLabel@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterByLabel@2x" icon.</summary>
        public static UnityEditorIcon d_FilterByLabel2x => _d_FilterByLabel2x;


        private static readonly UnityEditorIcon _d_FilterByType = BuildIcon("d_FilterByType");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterByType" icon.</summary>
        public static UnityEditorIcon d_FilterByType => _d_FilterByType;


        private static readonly UnityEditorIcon _d_FilterByType2x = BuildIcon("d_FilterByType@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterByType@2x" icon.</summary>
        public static UnityEditorIcon d_FilterByType2x => _d_FilterByType2x;


        private static readonly UnityEditorIcon _d_FilterSelectedOnly = BuildIcon("d_FilterSelectedOnly");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterSelectedOnly" icon.</summary>
        public static UnityEditorIcon d_FilterSelectedOnly => _d_FilterSelectedOnly;


        private static readonly UnityEditorIcon _d_FilterSelectedOnly2x = BuildIcon("d_FilterSelectedOnly@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FilterSelectedOnly@2x" icon.</summary>
        public static UnityEditorIcon d_FilterSelectedOnly2x => _d_FilterSelectedOnly2x;


        private static readonly UnityEditorIcon _d_forward = BuildIcon("d_forward");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_forward" icon.</summary>
        public static UnityEditorIcon d_forward => _d_forward;


        private static readonly UnityEditorIcon _d_forward2x = BuildIcon("d_forward@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_forward@2x" icon.</summary>
        public static UnityEditorIcon d_forward2x => _d_forward2x;


        private static readonly UnityEditorIcon _d_FrameCapture = BuildIcon("d_FrameCapture");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FrameCapture" icon.</summary>
        public static UnityEditorIcon d_FrameCapture => _d_FrameCapture;


        private static readonly UnityEditorIcon _d_FrameCapture2x = BuildIcon("d_FrameCapture@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FrameCapture@2x" icon.</summary>
        public static UnityEditorIcon d_FrameCapture2x => _d_FrameCapture2x;


        private static readonly UnityEditorIcon _d_GEAR = BuildIcon("d_GEAR");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GEAR" icon.</summary>
        public static UnityEditorIcon d_GEAR => _d_GEAR;


        private static readonly UnityEditorIcon _d_Grid_BoxTool = BuildIcon("d_Grid.BoxTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.BoxTool" icon.</summary>
        public static UnityEditorIcon d_Grid_BoxTool => _d_Grid_BoxTool;


        private static readonly UnityEditorIcon _d_Grid_BoxTool2x = BuildIcon("d_Grid.BoxTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.BoxTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_BoxTool2x => _d_Grid_BoxTool2x;


        private static readonly UnityEditorIcon _d_Grid_Default = BuildIcon("d_Grid.Default");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.Default" icon.</summary>
        public static UnityEditorIcon d_Grid_Default => _d_Grid_Default;


        private static readonly UnityEditorIcon _d_Grid_Default2x = BuildIcon("d_Grid.Default@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.Default@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_Default2x => _d_Grid_Default2x;


        private static readonly UnityEditorIcon _d_Grid_EraserTool = BuildIcon("d_Grid.EraserTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.EraserTool" icon.</summary>
        public static UnityEditorIcon d_Grid_EraserTool => _d_Grid_EraserTool;


        private static readonly UnityEditorIcon _d_Grid_EraserTool2x = BuildIcon("d_Grid.EraserTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.EraserTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_EraserTool2x => _d_Grid_EraserTool2x;


        private static readonly UnityEditorIcon _d_Grid_FillTool = BuildIcon("d_Grid.FillTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.FillTool" icon.</summary>
        public static UnityEditorIcon d_Grid_FillTool => _d_Grid_FillTool;


        private static readonly UnityEditorIcon _d_Grid_FillTool2x = BuildIcon("d_Grid.FillTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.FillTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_FillTool2x => _d_Grid_FillTool2x;


        private static readonly UnityEditorIcon _d_Grid_MoveTool = BuildIcon("d_Grid.MoveTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.MoveTool" icon.</summary>
        public static UnityEditorIcon d_Grid_MoveTool => _d_Grid_MoveTool;


        private static readonly UnityEditorIcon _d_Grid_MoveTool2x = BuildIcon("d_Grid.MoveTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.MoveTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_MoveTool2x => _d_Grid_MoveTool2x;


        private static readonly UnityEditorIcon _d_Grid_PaintTool = BuildIcon("d_Grid.PaintTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.PaintTool" icon.</summary>
        public static UnityEditorIcon d_Grid_PaintTool => _d_Grid_PaintTool;


        private static readonly UnityEditorIcon _d_Grid_PaintTool2x = BuildIcon("d_Grid.PaintTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.PaintTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_PaintTool2x => _d_Grid_PaintTool2x;


        private static readonly UnityEditorIcon _d_Grid_PickingTool = BuildIcon("d_Grid.PickingTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.PickingTool" icon.</summary>
        public static UnityEditorIcon d_Grid_PickingTool => _d_Grid_PickingTool;


        private static readonly UnityEditorIcon _d_Grid_PickingTool2x = BuildIcon("d_Grid.PickingTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid.PickingTool@2x" icon.</summary>
        public static UnityEditorIcon d_Grid_PickingTool2x => _d_Grid_PickingTool2x;


        private static readonly UnityEditorIcon _d_Groove = BuildIcon("d_Groove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Groove" icon.</summary>
        public static UnityEditorIcon d_Groove => _d_Groove;


        private static readonly UnityEditorIcon _d_HorizontalSplit = BuildIcon("d_HorizontalSplit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_HorizontalSplit" icon.</summary>
        public static UnityEditorIcon d_HorizontalSplit => _d_HorizontalSplit;


        private static readonly UnityEditorIcon _d_icon_dropdown = BuildIcon("d_icon dropdown");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_icon dropdown" icon.</summary>
        public static UnityEditorIcon d_icon_dropdown => _d_icon_dropdown;


        private static readonly UnityEditorIcon _d_icon_dropdown2x = BuildIcon("d_icon dropdown@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_icon dropdown@2x" icon.</summary>
        public static UnityEditorIcon d_icon_dropdown2x => _d_icon_dropdown2x;


        private static readonly UnityEditorIcon _d_Import = BuildIcon("d_Import");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Import" icon.</summary>
        public static UnityEditorIcon d_Import => _d_Import;


        private static readonly UnityEditorIcon _d_Import2x = BuildIcon("d_Import@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Import@2x" icon.</summary>
        public static UnityEditorIcon d_Import2x => _d_Import2x;


        private static readonly UnityEditorIcon _d_InspectorLock = BuildIcon("d_InspectorLock");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_InspectorLock" icon.</summary>
        public static UnityEditorIcon d_InspectorLock => _d_InspectorLock;


        private static readonly UnityEditorIcon _d_Invalid = BuildIcon("d_Invalid");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Invalid" icon.</summary>
        public static UnityEditorIcon d_Invalid => _d_Invalid;


        private static readonly UnityEditorIcon _d_Invalid2x = BuildIcon("d_Invalid@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Invalid@2x" icon.</summary>
        public static UnityEditorIcon d_Invalid2x => _d_Invalid2x;


        private static readonly UnityEditorIcon _d_JointAngularLimits = BuildIcon("d_JointAngularLimits");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_JointAngularLimits" icon.</summary>
        public static UnityEditorIcon d_JointAngularLimits => _d_JointAngularLimits;


        private static readonly UnityEditorIcon _d_leftBracket = BuildIcon("d_leftBracket");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_leftBracket" icon.</summary>
        public static UnityEditorIcon d_leftBracket => _d_leftBracket;


        private static readonly UnityEditorIcon _d_Lighting = BuildIcon("d_Lighting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Lighting" icon.</summary>
        public static UnityEditorIcon d_Lighting => _d_Lighting;


        private static readonly UnityEditorIcon _d_Lighting2x = BuildIcon("d_Lighting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Lighting@2x" icon.</summary>
        public static UnityEditorIcon d_Lighting2x => _d_Lighting2x;


        private static readonly UnityEditorIcon _d_LightmapEditor_WindowTitle = BuildIcon("d_LightmapEditor.WindowTitle");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightmapEditor.WindowTitle" icon.</summary>
        public static UnityEditorIcon d_LightmapEditor_WindowTitle => _d_LightmapEditor_WindowTitle;


        private static readonly UnityEditorIcon _d_LightmapEditor_WindowTitle2x = BuildIcon("d_LightmapEditor.WindowTitle@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightmapEditor.WindowTitle@2x" icon.</summary>
        public static UnityEditorIcon d_LightmapEditor_WindowTitle2x => _d_LightmapEditor_WindowTitle2x;


        private static readonly UnityEditorIcon _d_Linked = BuildIcon("d_Linked");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Linked" icon.</summary>
        public static UnityEditorIcon d_Linked => _d_Linked;


        private static readonly UnityEditorIcon _d_Linked2x = BuildIcon("d_Linked@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Linked@2x" icon.</summary>
        public static UnityEditorIcon d_Linked2x => _d_Linked2x;


        private static readonly UnityEditorIcon _d_MainStageView = BuildIcon("d_MainStageView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MainStageView" icon.</summary>
        public static UnityEditorIcon d_MainStageView => _d_MainStageView;


        private static readonly UnityEditorIcon _d_MainStageView2x = BuildIcon("d_MainStageView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MainStageView@2x" icon.</summary>
        public static UnityEditorIcon d_MainStageView2x => _d_MainStageView2x;


        private static readonly UnityEditorIcon _d_Mirror = BuildIcon("d_Mirror");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Mirror" icon.</summary>
        public static UnityEditorIcon d_Mirror => _d_Mirror;


        private static readonly UnityEditorIcon _d_model_large = BuildIcon("d_model large");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_model large" icon.</summary>
        public static UnityEditorIcon d_model_large => _d_model_large;


        private static readonly UnityEditorIcon _d_monologo = BuildIcon("d_monologo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_monologo" icon.</summary>
        public static UnityEditorIcon d_monologo => _d_monologo;


        private static readonly UnityEditorIcon _d_MoreOptions = BuildIcon("d_MoreOptions");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoreOptions" icon.</summary>
        public static UnityEditorIcon d_MoreOptions => _d_MoreOptions;


        private static readonly UnityEditorIcon _d_MoreOptions2x = BuildIcon("d_MoreOptions@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoreOptions@2x" icon.</summary>
        public static UnityEditorIcon d_MoreOptions2x => _d_MoreOptions2x;


        private static readonly UnityEditorIcon _d_MoveTool_on = BuildIcon("d_MoveTool on");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoveTool on" icon.</summary>
        public static UnityEditorIcon d_MoveTool_on => _d_MoveTool_on;


        private static readonly UnityEditorIcon _d_MoveTool_On2x = BuildIcon("d_MoveTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoveTool On@2x" icon.</summary>
        public static UnityEditorIcon d_MoveTool_On2x => _d_MoveTool_On2x;


        private static readonly UnityEditorIcon _d_MoveTool = BuildIcon("d_MoveTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoveTool" icon.</summary>
        public static UnityEditorIcon d_MoveTool => _d_MoveTool;


        private static readonly UnityEditorIcon _d_MoveTool2x = BuildIcon("d_MoveTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MoveTool@2x" icon.</summary>
        public static UnityEditorIcon d_MoveTool2x => _d_MoveTool2x;


        private static readonly UnityEditorIcon _d_Navigation = BuildIcon("d_Navigation");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Navigation" icon.</summary>
        public static UnityEditorIcon d_Navigation => _d_Navigation;


        private static readonly UnityEditorIcon _d_Occlusion = BuildIcon("d_Occlusion");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Occlusion" icon.</summary>
        public static UnityEditorIcon d_Occlusion => _d_Occlusion;


        private static readonly UnityEditorIcon _d_Occlusion2x = BuildIcon("d_Occlusion@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Occlusion@2x" icon.</summary>
        public static UnityEditorIcon d_Occlusion2x => _d_Occlusion2x;


        private static readonly UnityEditorIcon _d_Package_Manager = BuildIcon("d_Package Manager");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Package Manager" icon.</summary>
        public static UnityEditorIcon d_Package_Manager => _d_Package_Manager;


        private static readonly UnityEditorIcon _d_Package_Manager2x = BuildIcon("d_Package Manager@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Package Manager@2x" icon.</summary>
        public static UnityEditorIcon d_Package_Manager2x => _d_Package_Manager2x;


        private static readonly UnityEditorIcon _d_Particle_Effect = BuildIcon("d_Particle Effect");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Particle Effect" icon.</summary>
        public static UnityEditorIcon d_Particle_Effect => _d_Particle_Effect;


        private static readonly UnityEditorIcon _d_ParticleShapeTool_On = BuildIcon("d_ParticleShapeTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool On" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool_On => _d_ParticleShapeTool_On;


        private static readonly UnityEditorIcon _d_ParticleShapeTool_On2x = BuildIcon("d_ParticleShapeTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool On@2x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool_On2x => _d_ParticleShapeTool_On2x;


        private static readonly UnityEditorIcon _d_ParticleShapeTool_On3x = BuildIcon("d_ParticleShapeTool On@3x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool On@3x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool_On3x => _d_ParticleShapeTool_On3x;


        private static readonly UnityEditorIcon _d_ParticleShapeTool_On4x = BuildIcon("d_ParticleShapeTool On@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool On@4x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool_On4x => _d_ParticleShapeTool_On4x;


        private static readonly UnityEditorIcon _d_ParticleShapeTool = BuildIcon("d_ParticleShapeTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool => _d_ParticleShapeTool;


        private static readonly UnityEditorIcon _d_ParticleShapeTool2x = BuildIcon("d_ParticleShapeTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool@2x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool2x => _d_ParticleShapeTool2x;


        private static readonly UnityEditorIcon _d_ParticleShapeTool3x = BuildIcon("d_ParticleShapeTool@3x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool@3x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool3x => _d_ParticleShapeTool3x;


        private static readonly UnityEditorIcon _d_ParticleShapeTool4x = BuildIcon("d_ParticleShapeTool@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleShapeTool@4x" icon.</summary>
        public static UnityEditorIcon d_ParticleShapeTool4x => _d_ParticleShapeTool4x;


        private static readonly UnityEditorIcon _d_PauseButton_On = BuildIcon("d_PauseButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PauseButton On" icon.</summary>
        public static UnityEditorIcon d_PauseButton_On => _d_PauseButton_On;


        private static readonly UnityEditorIcon _d_PauseButton_On2x = BuildIcon("d_PauseButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PauseButton On@2x" icon.</summary>
        public static UnityEditorIcon d_PauseButton_On2x => _d_PauseButton_On2x;


        private static readonly UnityEditorIcon _d_PauseButton = BuildIcon("d_PauseButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PauseButton" icon.</summary>
        public static UnityEditorIcon d_PauseButton => _d_PauseButton;


        private static readonly UnityEditorIcon _d_PauseButton2x = BuildIcon("d_PauseButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PauseButton@2x" icon.</summary>
        public static UnityEditorIcon d_PauseButton2x => _d_PauseButton2x;


        private static readonly UnityEditorIcon _d_PlayButton_On = BuildIcon("d_PlayButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButton On" icon.</summary>
        public static UnityEditorIcon d_PlayButton_On => _d_PlayButton_On;


        private static readonly UnityEditorIcon _d_PlayButton_On2x = BuildIcon("d_PlayButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButton On@2x" icon.</summary>
        public static UnityEditorIcon d_PlayButton_On2x => _d_PlayButton_On2x;


        private static readonly UnityEditorIcon _d_PlayButton = BuildIcon("d_PlayButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButton" icon.</summary>
        public static UnityEditorIcon d_PlayButton => _d_PlayButton;


        private static readonly UnityEditorIcon _d_PlayButton2x = BuildIcon("d_PlayButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButton@2x" icon.</summary>
        public static UnityEditorIcon d_PlayButton2x => _d_PlayButton2x;


        private static readonly UnityEditorIcon _d_PlayButtonProfile_On = BuildIcon("d_PlayButtonProfile On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButtonProfile On" icon.</summary>
        public static UnityEditorIcon d_PlayButtonProfile_On => _d_PlayButtonProfile_On;


        private static readonly UnityEditorIcon _d_PlayButtonProfile = BuildIcon("d_PlayButtonProfile");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayButtonProfile" icon.</summary>
        public static UnityEditorIcon d_PlayButtonProfile => _d_PlayButtonProfile;


        private static readonly UnityEditorIcon _d_playLoopOff = BuildIcon("d_playLoopOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_playLoopOff" icon.</summary>
        public static UnityEditorIcon d_playLoopOff => _d_playLoopOff;


        private static readonly UnityEditorIcon _d_playLoopOn = BuildIcon("d_playLoopOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_playLoopOn" icon.</summary>
        public static UnityEditorIcon d_playLoopOn => _d_playLoopOn;


        private static readonly UnityEditorIcon _d_preAudioAutoPlayOff = BuildIcon("d_preAudioAutoPlayOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioAutoPlayOff" icon.</summary>
        public static UnityEditorIcon d_preAudioAutoPlayOff => _d_preAudioAutoPlayOff;


        private static readonly UnityEditorIcon _d_preAudioAutoPlayOff2x = BuildIcon("d_preAudioAutoPlayOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioAutoPlayOff@2x" icon.</summary>
        public static UnityEditorIcon d_preAudioAutoPlayOff2x => _d_preAudioAutoPlayOff2x;


        private static readonly UnityEditorIcon _d_preAudioAutoPlayOn = BuildIcon("d_preAudioAutoPlayOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioAutoPlayOn" icon.</summary>
        public static UnityEditorIcon d_preAudioAutoPlayOn => _d_preAudioAutoPlayOn;


        private static readonly UnityEditorIcon _d_preAudioLoopOff = BuildIcon("d_preAudioLoopOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioLoopOff" icon.</summary>
        public static UnityEditorIcon d_preAudioLoopOff => _d_preAudioLoopOff;


        private static readonly UnityEditorIcon _d_preAudioLoopOff2x = BuildIcon("d_preAudioLoopOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioLoopOff@2x" icon.</summary>
        public static UnityEditorIcon d_preAudioLoopOff2x => _d_preAudioLoopOff2x;


        private static readonly UnityEditorIcon _d_preAudioLoopOn = BuildIcon("d_preAudioLoopOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioLoopOn" icon.</summary>
        public static UnityEditorIcon d_preAudioLoopOn => _d_preAudioLoopOn;


        private static readonly UnityEditorIcon _d_preAudioPlayOff = BuildIcon("d_preAudioPlayOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioPlayOff" icon.</summary>
        public static UnityEditorIcon d_preAudioPlayOff => _d_preAudioPlayOff;


        private static readonly UnityEditorIcon _d_preAudioPlayOn = BuildIcon("d_preAudioPlayOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_preAudioPlayOn" icon.</summary>
        public static UnityEditorIcon d_preAudioPlayOn => _d_preAudioPlayOn;


        private static readonly UnityEditorIcon _d_PreMatCube = BuildIcon("d_PreMatCube");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatCube" icon.</summary>
        public static UnityEditorIcon d_PreMatCube => _d_PreMatCube;


        private static readonly UnityEditorIcon _d_PreMatCube2x = BuildIcon("d_PreMatCube@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatCube@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatCube2x => _d_PreMatCube2x;


        private static readonly UnityEditorIcon _d_PreMatCylinder = BuildIcon("d_PreMatCylinder");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatCylinder" icon.</summary>
        public static UnityEditorIcon d_PreMatCylinder => _d_PreMatCylinder;


        private static readonly UnityEditorIcon _d_PreMatCylinder2x = BuildIcon("d_PreMatCylinder@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatCylinder@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatCylinder2x => _d_PreMatCylinder2x;


        private static readonly UnityEditorIcon _d_PreMatLight0 = BuildIcon("d_PreMatLight0");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatLight0" icon.</summary>
        public static UnityEditorIcon d_PreMatLight0 => _d_PreMatLight0;


        private static readonly UnityEditorIcon _d_PreMatLight02x = BuildIcon("d_PreMatLight0@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatLight0@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatLight02x => _d_PreMatLight02x;


        private static readonly UnityEditorIcon _d_PreMatLight1 = BuildIcon("d_PreMatLight1");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatLight1" icon.</summary>
        public static UnityEditorIcon d_PreMatLight1 => _d_PreMatLight1;


        private static readonly UnityEditorIcon _d_PreMatLight12x = BuildIcon("d_PreMatLight1@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatLight1@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatLight12x => _d_PreMatLight12x;


        private static readonly UnityEditorIcon _d_PreMatQuad = BuildIcon("d_PreMatQuad");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatQuad" icon.</summary>
        public static UnityEditorIcon d_PreMatQuad => _d_PreMatQuad;


        private static readonly UnityEditorIcon _d_PreMatQuad2x = BuildIcon("d_PreMatQuad@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatQuad@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatQuad2x => _d_PreMatQuad2x;


        private static readonly UnityEditorIcon _d_PreMatSphere = BuildIcon("d_PreMatSphere");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatSphere" icon.</summary>
        public static UnityEditorIcon d_PreMatSphere => _d_PreMatSphere;


        private static readonly UnityEditorIcon _d_PreMatSphere2x = BuildIcon("d_PreMatSphere@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatSphere@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatSphere2x => _d_PreMatSphere2x;


        private static readonly UnityEditorIcon _d_PreMatTorus = BuildIcon("d_PreMatTorus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatTorus" icon.</summary>
        public static UnityEditorIcon d_PreMatTorus => _d_PreMatTorus;


        private static readonly UnityEditorIcon _d_PreMatTorus2x = BuildIcon("d_PreMatTorus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreMatTorus@2x" icon.</summary>
        public static UnityEditorIcon d_PreMatTorus2x => _d_PreMatTorus2x;


        private static readonly UnityEditorIcon _d_Preset_Context = BuildIcon("d_Preset.Context");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Preset.Context" icon.</summary>
        public static UnityEditorIcon d_Preset_Context => _d_Preset_Context;


        private static readonly UnityEditorIcon _d_Preset_Context2x = BuildIcon("d_Preset.Context@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Preset.Context@2x" icon.</summary>
        public static UnityEditorIcon d_Preset_Context2x => _d_Preset_Context2x;


        private static readonly UnityEditorIcon _d_PreTexA = BuildIcon("d_PreTexA");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexA" icon.</summary>
        public static UnityEditorIcon d_PreTexA => _d_PreTexA;


        private static readonly UnityEditorIcon _d_PreTexA2x = BuildIcon("d_PreTexA@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexA@2x" icon.</summary>
        public static UnityEditorIcon d_PreTexA2x => _d_PreTexA2x;


        private static readonly UnityEditorIcon _d_PreTexB = BuildIcon("d_PreTexB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexB" icon.</summary>
        public static UnityEditorIcon d_PreTexB => _d_PreTexB;


        private static readonly UnityEditorIcon _d_PreTexB2x = BuildIcon("d_PreTexB@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexB@2x" icon.</summary>
        public static UnityEditorIcon d_PreTexB2x => _d_PreTexB2x;


        private static readonly UnityEditorIcon _d_PreTexG = BuildIcon("d_PreTexG");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexG" icon.</summary>
        public static UnityEditorIcon d_PreTexG => _d_PreTexG;


        private static readonly UnityEditorIcon _d_PreTexG2x = BuildIcon("d_PreTexG@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexG@2x" icon.</summary>
        public static UnityEditorIcon d_PreTexG2x => _d_PreTexG2x;


        private static readonly UnityEditorIcon _d_PreTexR = BuildIcon("d_PreTexR");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexR" icon.</summary>
        public static UnityEditorIcon d_PreTexR => _d_PreTexR;


        private static readonly UnityEditorIcon _d_PreTexR2x = BuildIcon("d_PreTexR@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexR@2x" icon.</summary>
        public static UnityEditorIcon d_PreTexR2x => _d_PreTexR2x;


        private static readonly UnityEditorIcon _d_PreTexRGB = BuildIcon("d_PreTexRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexRGB" icon.</summary>
        public static UnityEditorIcon d_PreTexRGB => _d_PreTexRGB;


        private static readonly UnityEditorIcon _d_PreTexRGB2x = BuildIcon("d_PreTexRGB@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTexRGB@2x" icon.</summary>
        public static UnityEditorIcon d_PreTexRGB2x => _d_PreTexRGB2x;


        private static readonly UnityEditorIcon _d_PreTextureAlpha = BuildIcon("d_PreTextureAlpha");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTextureAlpha" icon.</summary>
        public static UnityEditorIcon d_PreTextureAlpha => _d_PreTextureAlpha;


        private static readonly UnityEditorIcon _d_PreTextureMipMapHigh = BuildIcon("d_PreTextureMipMapHigh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTextureMipMapHigh" icon.</summary>
        public static UnityEditorIcon d_PreTextureMipMapHigh => _d_PreTextureMipMapHigh;


        private static readonly UnityEditorIcon _d_PreTextureMipMapLow = BuildIcon("d_PreTextureMipMapLow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTextureMipMapLow" icon.</summary>
        public static UnityEditorIcon d_PreTextureMipMapLow => _d_PreTextureMipMapLow;


        private static readonly UnityEditorIcon _d_PreTextureRGB = BuildIcon("d_PreTextureRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PreTextureRGB" icon.</summary>
        public static UnityEditorIcon d_PreTextureRGB => _d_PreTextureRGB;


        private static readonly UnityEditorIcon _d_Profiler_Audio = BuildIcon("d_Profiler.Audio");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Audio" icon.</summary>
        public static UnityEditorIcon d_Profiler_Audio => _d_Profiler_Audio;


        private static readonly UnityEditorIcon _d_Profiler_Audio2x = BuildIcon("d_Profiler.Audio@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Audio@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Audio2x => _d_Profiler_Audio2x;


        private static readonly UnityEditorIcon _d_Profiler_CPU = BuildIcon("d_Profiler.CPU");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.CPU" icon.</summary>
        public static UnityEditorIcon d_Profiler_CPU => _d_Profiler_CPU;


        private static readonly UnityEditorIcon _d_Profiler_CPU2x = BuildIcon("d_Profiler.CPU@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.CPU@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_CPU2x => _d_Profiler_CPU2x;


        private static readonly UnityEditorIcon _d_Profiler_Custom = BuildIcon("d_Profiler.Custom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Custom" icon.</summary>
        public static UnityEditorIcon d_Profiler_Custom => _d_Profiler_Custom;


        private static readonly UnityEditorIcon _d_Profiler_Custom2x = BuildIcon("d_Profiler.Custom@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Custom@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Custom2x => _d_Profiler_Custom2x;


        private static readonly UnityEditorIcon _d_Profiler_FirstFrame = BuildIcon("d_Profiler.FirstFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.FirstFrame" icon.</summary>
        public static UnityEditorIcon d_Profiler_FirstFrame => _d_Profiler_FirstFrame;


        private static readonly UnityEditorIcon _d_Profiler_GlobalIllumination = BuildIcon("d_Profiler.GlobalIllumination");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.GlobalIllumination" icon.</summary>
        public static UnityEditorIcon d_Profiler_GlobalIllumination => _d_Profiler_GlobalIllumination;


        private static readonly UnityEditorIcon _d_Profiler_GlobalIllumination2x = BuildIcon("d_Profiler.GlobalIllumination@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.GlobalIllumination@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_GlobalIllumination2x => _d_Profiler_GlobalIllumination2x;


        private static readonly UnityEditorIcon _d_Profiler_GPU = BuildIcon("d_Profiler.GPU");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.GPU" icon.</summary>
        public static UnityEditorIcon d_Profiler_GPU => _d_Profiler_GPU;


        private static readonly UnityEditorIcon _d_Profiler_GPU2x = BuildIcon("d_Profiler.GPU@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.GPU@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_GPU2x => _d_Profiler_GPU2x;


        private static readonly UnityEditorIcon _d_Profiler_LastFrame = BuildIcon("d_Profiler.LastFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.LastFrame" icon.</summary>
        public static UnityEditorIcon d_Profiler_LastFrame => _d_Profiler_LastFrame;


        private static readonly UnityEditorIcon _d_Profiler_Memory = BuildIcon("d_Profiler.Memory");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Memory" icon.</summary>
        public static UnityEditorIcon d_Profiler_Memory => _d_Profiler_Memory;


        private static readonly UnityEditorIcon _d_Profiler_Memory2x = BuildIcon("d_Profiler.Memory@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Memory@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Memory2x => _d_Profiler_Memory2x;


        private static readonly UnityEditorIcon _d_Profiler_Network = BuildIcon("d_Profiler.Network");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Network" icon.</summary>
        public static UnityEditorIcon d_Profiler_Network => _d_Profiler_Network;


        private static readonly UnityEditorIcon _d_Profiler_NetworkMessages = BuildIcon("d_Profiler.NetworkMessages");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.NetworkMessages" icon.</summary>
        public static UnityEditorIcon d_Profiler_NetworkMessages => _d_Profiler_NetworkMessages;


        private static readonly UnityEditorIcon _d_Profiler_NetworkMessages2x = BuildIcon("d_Profiler.NetworkMessages@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.NetworkMessages@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_NetworkMessages2x => _d_Profiler_NetworkMessages2x;


        private static readonly UnityEditorIcon _d_Profiler_NetworkOperations = BuildIcon("d_Profiler.NetworkOperations");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.NetworkOperations" icon.</summary>
        public static UnityEditorIcon d_Profiler_NetworkOperations => _d_Profiler_NetworkOperations;


        private static readonly UnityEditorIcon _d_Profiler_NetworkOperations2x = BuildIcon("d_Profiler.NetworkOperations@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.NetworkOperations@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_NetworkOperations2x => _d_Profiler_NetworkOperations2x;


        private static readonly UnityEditorIcon _d_Profiler_NextFrame = BuildIcon("d_Profiler.NextFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.NextFrame" icon.</summary>
        public static UnityEditorIcon d_Profiler_NextFrame => _d_Profiler_NextFrame;


        private static readonly UnityEditorIcon _d_Profiler_Open = BuildIcon("d_Profiler.Open");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Open" icon.</summary>
        public static UnityEditorIcon d_Profiler_Open => _d_Profiler_Open;


        private static readonly UnityEditorIcon _d_Profiler_Open2x = BuildIcon("d_Profiler.Open@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Open@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Open2x => _d_Profiler_Open2x;


        private static readonly UnityEditorIcon _d_Profiler_Open4x = BuildIcon("d_Profiler.Open@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Open@4x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Open4x => _d_Profiler_Open4x;


        private static readonly UnityEditorIcon _d_Profiler_Physics = BuildIcon("d_Profiler.Physics");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Physics" icon.</summary>
        public static UnityEditorIcon d_Profiler_Physics => _d_Profiler_Physics;


        private static readonly UnityEditorIcon _d_Profiler_Physics2D = BuildIcon("d_Profiler.Physics2D");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Physics2D" icon.</summary>
        public static UnityEditorIcon d_Profiler_Physics2D => _d_Profiler_Physics2D;


        private static readonly UnityEditorIcon _d_Profiler_Physics2D2x = BuildIcon("d_Profiler.Physics2D@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Physics2D@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Physics2D2x => _d_Profiler_Physics2D2x;


        private static readonly UnityEditorIcon _d_Profiler_Physics2x = BuildIcon("d_Profiler.Physics@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Physics@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Physics2x => _d_Profiler_Physics2x;


        private static readonly UnityEditorIcon _d_Profiler_PrevFrame = BuildIcon("d_Profiler.PrevFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.PrevFrame" icon.</summary>
        public static UnityEditorIcon d_Profiler_PrevFrame => _d_Profiler_PrevFrame;


        private static readonly UnityEditorIcon _d_Profiler_Record = BuildIcon("d_Profiler.Record");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Record" icon.</summary>
        public static UnityEditorIcon d_Profiler_Record => _d_Profiler_Record;


        private static readonly UnityEditorIcon _d_Profiler_Rendering = BuildIcon("d_Profiler.Rendering");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Rendering" icon.</summary>
        public static UnityEditorIcon d_Profiler_Rendering => _d_Profiler_Rendering;


        private static readonly UnityEditorIcon _d_Profiler_Rendering2x = BuildIcon("d_Profiler.Rendering@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Rendering@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Rendering2x => _d_Profiler_Rendering2x;


        private static readonly UnityEditorIcon _d_Profiler_UI = BuildIcon("d_Profiler.UI");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.UI" icon.</summary>
        public static UnityEditorIcon d_Profiler_UI => _d_Profiler_UI;


        private static readonly UnityEditorIcon _d_Profiler_UI2x = BuildIcon("d_Profiler.UI@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.UI@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_UI2x => _d_Profiler_UI2x;


        private static readonly UnityEditorIcon _d_Profiler_UIDetails = BuildIcon("d_Profiler.UIDetails");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.UIDetails" icon.</summary>
        public static UnityEditorIcon d_Profiler_UIDetails => _d_Profiler_UIDetails;


        private static readonly UnityEditorIcon _d_Profiler_UIDetails2x = BuildIcon("d_Profiler.UIDetails@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.UIDetails@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_UIDetails2x => _d_Profiler_UIDetails2x;


        private static readonly UnityEditorIcon _d_Profiler_Video = BuildIcon("d_Profiler.Video");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Video" icon.</summary>
        public static UnityEditorIcon d_Profiler_Video => _d_Profiler_Video;


        private static readonly UnityEditorIcon _d_Profiler_Video2x = BuildIcon("d_Profiler.Video@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.Video@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_Video2x => _d_Profiler_Video2x;


        private static readonly UnityEditorIcon _d_Profiler_VirtualTexturing = BuildIcon("d_Profiler.VirtualTexturing");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.VirtualTexturing" icon.</summary>
        public static UnityEditorIcon d_Profiler_VirtualTexturing => _d_Profiler_VirtualTexturing;


        private static readonly UnityEditorIcon _d_Profiler_VirtualTexturing2x = BuildIcon("d_Profiler.VirtualTexturing@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Profiler.VirtualTexturing@2x" icon.</summary>
        public static UnityEditorIcon d_Profiler_VirtualTexturing2x => _d_Profiler_VirtualTexturing2x;


        private static readonly UnityEditorIcon _d_ProfilerColumn_WarningCount = BuildIcon("d_ProfilerColumn.WarningCount");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ProfilerColumn.WarningCount" icon.</summary>
        public static UnityEditorIcon d_ProfilerColumn_WarningCount => _d_ProfilerColumn_WarningCount;


        private static readonly UnityEditorIcon _d_Progress = BuildIcon("d_Progress");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Progress" icon.</summary>
        public static UnityEditorIcon d_Progress => _d_Progress;


        private static readonly UnityEditorIcon _d_Progress2x = BuildIcon("d_Progress@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Progress@2x" icon.</summary>
        public static UnityEditorIcon d_Progress2x => _d_Progress2x;


        private static readonly UnityEditorIcon _d_Project = BuildIcon("d_Project");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Project" icon.</summary>
        public static UnityEditorIcon d_Project => _d_Project;


        private static readonly UnityEditorIcon _d_Project2x = BuildIcon("d_Project@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Project@2x" icon.</summary>
        public static UnityEditorIcon d_Project2x => _d_Project2x;


        private static readonly UnityEditorIcon _d_Record_Off = BuildIcon("d_Record Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Record Off" icon.</summary>
        public static UnityEditorIcon d_Record_Off => _d_Record_Off;


        private static readonly UnityEditorIcon _d_Record_Off2x = BuildIcon("d_Record Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Record Off@2x" icon.</summary>
        public static UnityEditorIcon d_Record_Off2x => _d_Record_Off2x;


        private static readonly UnityEditorIcon _d_Record_On = BuildIcon("d_Record On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Record On" icon.</summary>
        public static UnityEditorIcon d_Record_On => _d_Record_On;


        private static readonly UnityEditorIcon _d_Record_On2x = BuildIcon("d_Record On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Record On@2x" icon.</summary>
        public static UnityEditorIcon d_Record_On2x => _d_Record_On2x;


        private static readonly UnityEditorIcon _d_RectTool_On = BuildIcon("d_RectTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTool On" icon.</summary>
        public static UnityEditorIcon d_RectTool_On => _d_RectTool_On;


        private static readonly UnityEditorIcon _d_RectTool_On2x = BuildIcon("d_RectTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTool On@2x" icon.</summary>
        public static UnityEditorIcon d_RectTool_On2x => _d_RectTool_On2x;


        private static readonly UnityEditorIcon _d_RectTool = BuildIcon("d_RectTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTool" icon.</summary>
        public static UnityEditorIcon d_RectTool => _d_RectTool;


        private static readonly UnityEditorIcon _d_RectTool2x = BuildIcon("d_RectTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTool@2x" icon.</summary>
        public static UnityEditorIcon d_RectTool2x => _d_RectTool2x;


        private static readonly UnityEditorIcon _d_RectTransformBlueprint = BuildIcon("d_RectTransformBlueprint");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTransformBlueprint" icon.</summary>
        public static UnityEditorIcon d_RectTransformBlueprint => _d_RectTransformBlueprint;


        private static readonly UnityEditorIcon _d_RectTransformRaw = BuildIcon("d_RectTransformRaw");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTransformRaw" icon.</summary>
        public static UnityEditorIcon d_RectTransformRaw => _d_RectTransformRaw;


        private static readonly UnityEditorIcon _d_redGroove = BuildIcon("d_redGroove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_redGroove" icon.</summary>
        public static UnityEditorIcon d_redGroove => _d_redGroove;


        private static readonly UnityEditorIcon _d_ReflectionProbeSelector = BuildIcon("d_ReflectionProbeSelector");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ReflectionProbeSelector" icon.</summary>
        public static UnityEditorIcon d_ReflectionProbeSelector => _d_ReflectionProbeSelector;


        private static readonly UnityEditorIcon _d_ReflectionProbeSelector2x = BuildIcon("d_ReflectionProbeSelector@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ReflectionProbeSelector@2x" icon.</summary>
        public static UnityEditorIcon d_ReflectionProbeSelector2x => _d_ReflectionProbeSelector2x;


        private static readonly UnityEditorIcon _d_Refresh = BuildIcon("d_Refresh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Refresh" icon.</summary>
        public static UnityEditorIcon d_Refresh => _d_Refresh;


        private static readonly UnityEditorIcon _d_Refresh2x = BuildIcon("d_Refresh@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Refresh@2x" icon.</summary>
        public static UnityEditorIcon d_Refresh2x => _d_Refresh2x;


        private static readonly UnityEditorIcon _d_rightBracket = BuildIcon("d_rightBracket");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_rightBracket" icon.</summary>
        public static UnityEditorIcon d_rightBracket => _d_rightBracket;


        private static readonly UnityEditorIcon _d_RotateTool_On = BuildIcon("d_RotateTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RotateTool On" icon.</summary>
        public static UnityEditorIcon d_RotateTool_On => _d_RotateTool_On;


        private static readonly UnityEditorIcon _d_RotateTool_On2x = BuildIcon("d_RotateTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RotateTool On@2x" icon.</summary>
        public static UnityEditorIcon d_RotateTool_On2x => _d_RotateTool_On2x;


        private static readonly UnityEditorIcon _d_RotateTool = BuildIcon("d_RotateTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RotateTool" icon.</summary>
        public static UnityEditorIcon d_RotateTool => _d_RotateTool;


        private static readonly UnityEditorIcon _d_RotateTool2x = BuildIcon("d_RotateTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RotateTool@2x" icon.</summary>
        public static UnityEditorIcon d_RotateTool2x => _d_RotateTool2x;


        private static readonly UnityEditorIcon _d_SaveAs = BuildIcon("d_SaveAs");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SaveAs" icon.</summary>
        public static UnityEditorIcon d_SaveAs => _d_SaveAs;


        private static readonly UnityEditorIcon _d_SaveAs2x = BuildIcon("d_SaveAs@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SaveAs@2x" icon.</summary>
        public static UnityEditorIcon d_SaveAs2x => _d_SaveAs2x;


        private static readonly UnityEditorIcon _d_ScaleTool_On = BuildIcon("d_ScaleTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScaleTool On" icon.</summary>
        public static UnityEditorIcon d_ScaleTool_On => _d_ScaleTool_On;


        private static readonly UnityEditorIcon _d_ScaleTool_On2x = BuildIcon("d_ScaleTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScaleTool On@2x" icon.</summary>
        public static UnityEditorIcon d_ScaleTool_On2x => _d_ScaleTool_On2x;


        private static readonly UnityEditorIcon _d_ScaleTool = BuildIcon("d_ScaleTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScaleTool" icon.</summary>
        public static UnityEditorIcon d_ScaleTool => _d_ScaleTool;


        private static readonly UnityEditorIcon _d_ScaleTool2x = BuildIcon("d_ScaleTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScaleTool@2x" icon.</summary>
        public static UnityEditorIcon d_ScaleTool2x => _d_ScaleTool2x;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_mixed = BuildIcon("d_scenepicking_notpickable-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable-mixed" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_mixed => _d_scenepicking_notpickable_mixed;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_mixed2x = BuildIcon("d_scenepicking_notpickable-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable-mixed@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_mixed2x => _d_scenepicking_notpickable_mixed2x;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_mixed_hover = BuildIcon("d_scenepicking_notpickable-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable-mixed_hover" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_mixed_hover => _d_scenepicking_notpickable_mixed_hover;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_mixed_hover2x = BuildIcon("d_scenepicking_notpickable-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_mixed_hover2x => _d_scenepicking_notpickable_mixed_hover2x;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable = BuildIcon("d_scenepicking_notpickable");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable => _d_scenepicking_notpickable;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable2x = BuildIcon("d_scenepicking_notpickable@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable2x => _d_scenepicking_notpickable2x;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_hover = BuildIcon("d_scenepicking_notpickable_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable_hover" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_hover => _d_scenepicking_notpickable_hover;


        private static readonly UnityEditorIcon _d_scenepicking_notpickable_hover2x = BuildIcon("d_scenepicking_notpickable_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_notpickable_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_notpickable_hover2x => _d_scenepicking_notpickable_hover2x;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_mixed = BuildIcon("d_scenepicking_pickable-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable-mixed" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_mixed => _d_scenepicking_pickable_mixed;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_mixed2x = BuildIcon("d_scenepicking_pickable-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable-mixed@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_mixed2x => _d_scenepicking_pickable_mixed2x;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_mixed_hover = BuildIcon("d_scenepicking_pickable-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable-mixed_hover" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_mixed_hover => _d_scenepicking_pickable_mixed_hover;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_mixed_hover2x = BuildIcon("d_scenepicking_pickable-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_mixed_hover2x => _d_scenepicking_pickable_mixed_hover2x;


        private static readonly UnityEditorIcon _d_scenepicking_pickable = BuildIcon("d_scenepicking_pickable");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable => _d_scenepicking_pickable;


        private static readonly UnityEditorIcon _d_scenepicking_pickable2x = BuildIcon("d_scenepicking_pickable@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable2x => _d_scenepicking_pickable2x;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_hover = BuildIcon("d_scenepicking_pickable_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable_hover" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_hover => _d_scenepicking_pickable_hover;


        private static readonly UnityEditorIcon _d_scenepicking_pickable_hover2x = BuildIcon("d_scenepicking_pickable_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenepicking_pickable_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenepicking_pickable_hover2x => _d_scenepicking_pickable_hover2x;


        private static readonly UnityEditorIcon _d_SceneView2D = BuildIcon("d_SceneView2D");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneView2D" icon.</summary>
        public static UnityEditorIcon d_SceneView2D => _d_SceneView2D;


        private static readonly UnityEditorIcon _d_SceneView2D2x = BuildIcon("d_SceneView2D@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneView2D@2x" icon.</summary>
        public static UnityEditorIcon d_SceneView2D2x => _d_SceneView2D2x;


        private static readonly UnityEditorIcon _d_SceneViewAlpha = BuildIcon("d_SceneViewAlpha");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewAlpha" icon.</summary>
        public static UnityEditorIcon d_SceneViewAlpha => _d_SceneViewAlpha;


        private static readonly UnityEditorIcon _d_SceneViewAudio_Off = BuildIcon("d_SceneViewAudio Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewAudio Off" icon.</summary>
        public static UnityEditorIcon d_SceneViewAudio_Off => _d_SceneViewAudio_Off;


        private static readonly UnityEditorIcon _d_SceneViewAudio_Off2x = BuildIcon("d_SceneViewAudio Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewAudio Off@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewAudio_Off2x => _d_SceneViewAudio_Off2x;


        private static readonly UnityEditorIcon _d_SceneViewAudio = BuildIcon("d_SceneViewAudio");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewAudio" icon.</summary>
        public static UnityEditorIcon d_SceneViewAudio => _d_SceneViewAudio;


        private static readonly UnityEditorIcon _d_SceneViewAudio2x = BuildIcon("d_SceneViewAudio@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewAudio@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewAudio2x => _d_SceneViewAudio2x;


        private static readonly UnityEditorIcon _d_SceneViewCamera = BuildIcon("d_SceneViewCamera");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewCamera" icon.</summary>
        public static UnityEditorIcon d_SceneViewCamera => _d_SceneViewCamera;


        private static readonly UnityEditorIcon _d_SceneViewCamera2x = BuildIcon("d_SceneViewCamera@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewCamera@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewCamera2x => _d_SceneViewCamera2x;


        private static readonly UnityEditorIcon _d_SceneViewFx = BuildIcon("d_SceneViewFx");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewFx" icon.</summary>
        public static UnityEditorIcon d_SceneViewFx => _d_SceneViewFx;


        private static readonly UnityEditorIcon _d_SceneViewFX2x = BuildIcon("d_SceneViewFX@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewFX@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewFX2x => _d_SceneViewFX2x;


        private static readonly UnityEditorIcon _d_SceneViewLighting_Off = BuildIcon("d_SceneViewLighting Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewLighting Off" icon.</summary>
        public static UnityEditorIcon d_SceneViewLighting_Off => _d_SceneViewLighting_Off;


        private static readonly UnityEditorIcon _d_SceneViewLighting_Off2x = BuildIcon("d_SceneViewLighting Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewLighting Off@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewLighting_Off2x => _d_SceneViewLighting_Off2x;


        private static readonly UnityEditorIcon _d_SceneViewLighting = BuildIcon("d_SceneViewLighting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewLighting" icon.</summary>
        public static UnityEditorIcon d_SceneViewLighting => _d_SceneViewLighting;


        private static readonly UnityEditorIcon _d_SceneViewLighting2x = BuildIcon("d_SceneViewLighting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewLighting@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewLighting2x => _d_SceneViewLighting2x;


        private static readonly UnityEditorIcon _d_SceneViewOrtho = BuildIcon("d_SceneViewOrtho");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewOrtho" icon.</summary>
        public static UnityEditorIcon d_SceneViewOrtho => _d_SceneViewOrtho;


        private static readonly UnityEditorIcon _d_SceneViewRGB = BuildIcon("d_SceneViewRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewRGB" icon.</summary>
        public static UnityEditorIcon d_SceneViewRGB => _d_SceneViewRGB;


        private static readonly UnityEditorIcon _d_SceneViewTools = BuildIcon("d_SceneViewTools");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewTools" icon.</summary>
        public static UnityEditorIcon d_SceneViewTools => _d_SceneViewTools;


        private static readonly UnityEditorIcon _d_SceneViewTools2x = BuildIcon("d_SceneViewTools@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewTools@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewTools2x => _d_SceneViewTools2x;


        private static readonly UnityEditorIcon _d_SceneViewVisibility = BuildIcon("d_SceneViewVisibility");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewVisibility" icon.</summary>
        public static UnityEditorIcon d_SceneViewVisibility => _d_SceneViewVisibility;


        private static readonly UnityEditorIcon _d_SceneViewVisibility2x = BuildIcon("d_SceneViewVisibility@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewVisibility@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewVisibility2x => _d_SceneViewVisibility2x;


        private static readonly UnityEditorIcon _d_scenevis_hidden_mixed = BuildIcon("d_scenevis_hidden-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden-mixed" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_mixed => _d_scenevis_hidden_mixed;


        private static readonly UnityEditorIcon _d_scenevis_hidden_mixed2x = BuildIcon("d_scenevis_hidden-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden-mixed@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_mixed2x => _d_scenevis_hidden_mixed2x;


        private static readonly UnityEditorIcon _d_scenevis_hidden_mixed_hover = BuildIcon("d_scenevis_hidden-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden-mixed_hover" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_mixed_hover => _d_scenevis_hidden_mixed_hover;


        private static readonly UnityEditorIcon _d_scenevis_hidden_mixed_hover2x = BuildIcon("d_scenevis_hidden-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_mixed_hover2x => _d_scenevis_hidden_mixed_hover2x;


        private static readonly UnityEditorIcon _d_scenevis_hidden = BuildIcon("d_scenevis_hidden");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden => _d_scenevis_hidden;


        private static readonly UnityEditorIcon _d_scenevis_hidden2x = BuildIcon("d_scenevis_hidden@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden2x => _d_scenevis_hidden2x;


        private static readonly UnityEditorIcon _d_scenevis_hidden_hover = BuildIcon("d_scenevis_hidden_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden_hover" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_hover => _d_scenevis_hidden_hover;


        private static readonly UnityEditorIcon _d_scenevis_hidden_hover2x = BuildIcon("d_scenevis_hidden_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_hidden_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_hidden_hover2x => _d_scenevis_hidden_hover2x;


        private static readonly UnityEditorIcon _d_scenevis_scene_hover = BuildIcon("d_scenevis_scene_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_scene_hover" icon.</summary>
        public static UnityEditorIcon d_scenevis_scene_hover => _d_scenevis_scene_hover;


        private static readonly UnityEditorIcon _d_scenevis_scene_hover2x = BuildIcon("d_scenevis_scene_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_scene_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_scene_hover2x => _d_scenevis_scene_hover2x;


        private static readonly UnityEditorIcon _d_scenevis_visible_mixed = BuildIcon("d_scenevis_visible-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible-mixed" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_mixed => _d_scenevis_visible_mixed;


        private static readonly UnityEditorIcon _d_scenevis_visible_mixed2x = BuildIcon("d_scenevis_visible-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible-mixed@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_mixed2x => _d_scenevis_visible_mixed2x;


        private static readonly UnityEditorIcon _d_scenevis_visible_mixed_hover = BuildIcon("d_scenevis_visible-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible-mixed_hover" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_mixed_hover => _d_scenevis_visible_mixed_hover;


        private static readonly UnityEditorIcon _d_scenevis_visible_mixed_hover2x = BuildIcon("d_scenevis_visible-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_mixed_hover2x => _d_scenevis_visible_mixed_hover2x;


        private static readonly UnityEditorIcon _d_scenevis_visible = BuildIcon("d_scenevis_visible");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible => _d_scenevis_visible;


        private static readonly UnityEditorIcon _d_scenevis_visible2x = BuildIcon("d_scenevis_visible@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible2x => _d_scenevis_visible2x;


        private static readonly UnityEditorIcon _d_scenevis_visible_hover = BuildIcon("d_scenevis_visible_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible_hover" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_hover => _d_scenevis_visible_hover;


        private static readonly UnityEditorIcon _d_scenevis_visible_hover2x = BuildIcon("d_scenevis_visible_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_scenevis_visible_hover@2x" icon.</summary>
        public static UnityEditorIcon d_scenevis_visible_hover2x => _d_scenevis_visible_hover2x;


        private static readonly UnityEditorIcon _d_ScrollShadow = BuildIcon("d_ScrollShadow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScrollShadow" icon.</summary>
        public static UnityEditorIcon d_ScrollShadow => _d_ScrollShadow;


        private static readonly UnityEditorIcon _d_Settings = BuildIcon("d_Settings");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Settings" icon.</summary>
        public static UnityEditorIcon d_Settings => _d_Settings;


        private static readonly UnityEditorIcon _d_Settings2x = BuildIcon("d_Settings@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Settings@2x" icon.</summary>
        public static UnityEditorIcon d_Settings2x => _d_Settings2x;


        private static readonly UnityEditorIcon _d_SettingsIcon = BuildIcon("d_SettingsIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SettingsIcon" icon.</summary>
        public static UnityEditorIcon d_SettingsIcon => _d_SettingsIcon;


        private static readonly UnityEditorIcon _d_SettingsIcon2x = BuildIcon("d_SettingsIcon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SettingsIcon@2x" icon.</summary>
        public static UnityEditorIcon d_SettingsIcon2x => _d_SettingsIcon2x;


        private static readonly UnityEditorIcon _d_SocialNetworks_FacebookShare = BuildIcon("d_SocialNetworks.FacebookShare");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SocialNetworks.FacebookShare" icon.</summary>
        public static UnityEditorIcon d_SocialNetworks_FacebookShare => _d_SocialNetworks_FacebookShare;


        private static readonly UnityEditorIcon _d_SocialNetworks_LinkedInShare = BuildIcon("d_SocialNetworks.LinkedInShare");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SocialNetworks.LinkedInShare" icon.</summary>
        public static UnityEditorIcon d_SocialNetworks_LinkedInShare => _d_SocialNetworks_LinkedInShare;


        private static readonly UnityEditorIcon _d_SocialNetworks_Tweet = BuildIcon("d_SocialNetworks.Tweet");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SocialNetworks.Tweet" icon.</summary>
        public static UnityEditorIcon d_SocialNetworks_Tweet => _d_SocialNetworks_Tweet;


        private static readonly UnityEditorIcon _d_SocialNetworks_UDNOpen = BuildIcon("d_SocialNetworks.UDNOpen");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SocialNetworks.UDNOpen" icon.</summary>
        public static UnityEditorIcon d_SocialNetworks_UDNOpen => _d_SocialNetworks_UDNOpen;


        private static readonly UnityEditorIcon _d_SpeedScale = BuildIcon("d_SpeedScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpeedScale" icon.</summary>
        public static UnityEditorIcon d_SpeedScale => _d_SpeedScale;


        private static readonly UnityEditorIcon _d_StepButton_On = BuildIcon("d_StepButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepButton On" icon.</summary>
        public static UnityEditorIcon d_StepButton_On => _d_StepButton_On;


        private static readonly UnityEditorIcon _d_StepButton_On2x = BuildIcon("d_StepButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepButton On@2x" icon.</summary>
        public static UnityEditorIcon d_StepButton_On2x => _d_StepButton_On2x;


        private static readonly UnityEditorIcon _d_StepButton = BuildIcon("d_StepButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepButton" icon.</summary>
        public static UnityEditorIcon d_StepButton => _d_StepButton;


        private static readonly UnityEditorIcon _d_StepButton2x = BuildIcon("d_StepButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepButton@2x" icon.</summary>
        public static UnityEditorIcon d_StepButton2x => _d_StepButton2x;


        private static readonly UnityEditorIcon _d_StepLeftButton_On = BuildIcon("d_StepLeftButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepLeftButton-On" icon.</summary>
        public static UnityEditorIcon d_StepLeftButton_On => _d_StepLeftButton_On;


        private static readonly UnityEditorIcon _d_StepLeftButton = BuildIcon("d_StepLeftButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StepLeftButton" icon.</summary>
        public static UnityEditorIcon d_StepLeftButton => _d_StepLeftButton;


        private static readonly UnityEditorIcon _d_tab_next = BuildIcon("d_tab_next");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tab_next" icon.</summary>
        public static UnityEditorIcon d_tab_next => _d_tab_next;


        private static readonly UnityEditorIcon _d_tab_next2x = BuildIcon("d_tab_next@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tab_next@2x" icon.</summary>
        public static UnityEditorIcon d_tab_next2x => _d_tab_next2x;


        private static readonly UnityEditorIcon _d_tab_prev = BuildIcon("d_tab_prev");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tab_prev" icon.</summary>
        public static UnityEditorIcon d_tab_prev => _d_tab_prev;


        private static readonly UnityEditorIcon _d_tab_prev2x = BuildIcon("d_tab_prev@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tab_prev@2x" icon.</summary>
        public static UnityEditorIcon d_tab_prev2x => _d_tab_prev2x;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolLower_On = BuildIcon("d_TerrainInspector.TerrainToolLower On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolLower On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolLower_On => _d_TerrainInspector_TerrainToolLower_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolLowerAlt = BuildIcon("d_TerrainInspector.TerrainToolLowerAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolLowerAlt" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolLowerAlt => _d_TerrainInspector_TerrainToolLowerAlt;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolPlants_On = BuildIcon("d_TerrainInspector.TerrainToolPlants On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolPlants On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolPlants_On => _d_TerrainInspector_TerrainToolPlants_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolPlants = BuildIcon("d_TerrainInspector.TerrainToolPlants");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolPlants" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolPlants => _d_TerrainInspector_TerrainToolPlants;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolPlantsAlt_On = BuildIcon("d_TerrainInspector.TerrainToolPlantsAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolPlantsAlt On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolPlantsAlt_On => _d_TerrainInspector_TerrainToolPlantsAlt_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolPlantsAlt = BuildIcon("d_TerrainInspector.TerrainToolPlantsAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolPlantsAlt" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolPlantsAlt => _d_TerrainInspector_TerrainToolPlantsAlt;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolRaise_On = BuildIcon("d_TerrainInspector.TerrainToolRaise On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolRaise On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolRaise_On => _d_TerrainInspector_TerrainToolRaise_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolRaise = BuildIcon("d_TerrainInspector.TerrainToolRaise");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolRaise" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolRaise => _d_TerrainInspector_TerrainToolRaise;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSetheight_On = BuildIcon("d_TerrainInspector.TerrainToolSetheight On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSetheight On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSetheight_On => _d_TerrainInspector_TerrainToolSetheight_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSetheight = BuildIcon("d_TerrainInspector.TerrainToolSetheight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSetheight" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSetheight => _d_TerrainInspector_TerrainToolSetheight;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSetheightAlt_On = BuildIcon("d_TerrainInspector.TerrainToolSetheightAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSetheightAlt On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSetheightAlt_On => _d_TerrainInspector_TerrainToolSetheightAlt_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSetheightAlt = BuildIcon("d_TerrainInspector.TerrainToolSetheightAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSetheightAlt" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSetheightAlt => _d_TerrainInspector_TerrainToolSetheightAlt;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSettings_On = BuildIcon("d_TerrainInspector.TerrainToolSettings On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSettings On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSettings_On => _d_TerrainInspector_TerrainToolSettings_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSettings = BuildIcon("d_TerrainInspector.TerrainToolSettings");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSettings" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSettings => _d_TerrainInspector_TerrainToolSettings;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSmoothHeight_On = BuildIcon("d_TerrainInspector.TerrainToolSmoothHeight On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSmoothHeight On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSmoothHeight_On => _d_TerrainInspector_TerrainToolSmoothHeight_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSmoothHeight = BuildIcon("d_TerrainInspector.TerrainToolSmoothHeight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSmoothHeight" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSmoothHeight => _d_TerrainInspector_TerrainToolSmoothHeight;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSplat_On = BuildIcon("d_TerrainInspector.TerrainToolSplat On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSplat On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSplat_On => _d_TerrainInspector_TerrainToolSplat_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSplat = BuildIcon("d_TerrainInspector.TerrainToolSplat");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSplat" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSplat => _d_TerrainInspector_TerrainToolSplat;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSplatAlt_On = BuildIcon("d_TerrainInspector.TerrainToolSplatAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSplatAlt On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSplatAlt_On => _d_TerrainInspector_TerrainToolSplatAlt_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolSplatAlt = BuildIcon("d_TerrainInspector.TerrainToolSplatAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolSplatAlt" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolSplatAlt => _d_TerrainInspector_TerrainToolSplatAlt;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolTrees_On = BuildIcon("d_TerrainInspector.TerrainToolTrees On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolTrees On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolTrees_On => _d_TerrainInspector_TerrainToolTrees_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolTrees = BuildIcon("d_TerrainInspector.TerrainToolTrees");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolTrees" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolTrees => _d_TerrainInspector_TerrainToolTrees;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolTreesAlt_On = BuildIcon("d_TerrainInspector.TerrainToolTreesAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolTreesAlt On" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolTreesAlt_On => _d_TerrainInspector_TerrainToolTreesAlt_On;


        private static readonly UnityEditorIcon _d_TerrainInspector_TerrainToolTreesAlt = BuildIcon("d_TerrainInspector.TerrainToolTreesAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainInspector.TerrainToolTreesAlt" icon.</summary>
        public static UnityEditorIcon d_TerrainInspector_TerrainToolTreesAlt => _d_TerrainInspector_TerrainToolTreesAlt;


        private static readonly UnityEditorIcon _d_ToggleUVOverlay = BuildIcon("d_ToggleUVOverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToggleUVOverlay" icon.</summary>
        public static UnityEditorIcon d_ToggleUVOverlay => _d_ToggleUVOverlay;


        private static readonly UnityEditorIcon _d_ToggleUVOverlay2x = BuildIcon("d_ToggleUVOverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToggleUVOverlay@2x" icon.</summary>
        public static UnityEditorIcon d_ToggleUVOverlay2x => _d_ToggleUVOverlay2x;


        private static readonly UnityEditorIcon _d_Toolbar_Minus = BuildIcon("d_Toolbar Minus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Minus" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Minus => _d_Toolbar_Minus;


        private static readonly UnityEditorIcon _d_Toolbar_Minus2x = BuildIcon("d_Toolbar Minus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Minus@2x" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Minus2x => _d_Toolbar_Minus2x;


        private static readonly UnityEditorIcon _d_Toolbar_Plus_More = BuildIcon("d_Toolbar Plus More");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Plus More" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Plus_More => _d_Toolbar_Plus_More;


        private static readonly UnityEditorIcon _d_Toolbar_Plus_More2x = BuildIcon("d_Toolbar Plus More@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Plus More@2x" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Plus_More2x => _d_Toolbar_Plus_More2x;


        private static readonly UnityEditorIcon _d_Toolbar_Plus = BuildIcon("d_Toolbar Plus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Plus" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Plus => _d_Toolbar_Plus;


        private static readonly UnityEditorIcon _d_Toolbar_Plus2x = BuildIcon("d_Toolbar Plus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toolbar Plus@2x" icon.</summary>
        public static UnityEditorIcon d_Toolbar_Plus2x => _d_Toolbar_Plus2x;


        private static readonly UnityEditorIcon _d_ToolHandleCenter = BuildIcon("d_ToolHandleCenter");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleCenter" icon.</summary>
        public static UnityEditorIcon d_ToolHandleCenter => _d_ToolHandleCenter;


        private static readonly UnityEditorIcon _d_ToolHandleCenter2x = BuildIcon("d_ToolHandleCenter@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleCenter@2x" icon.</summary>
        public static UnityEditorIcon d_ToolHandleCenter2x => _d_ToolHandleCenter2x;


        private static readonly UnityEditorIcon _d_ToolHandleGlobal = BuildIcon("d_ToolHandleGlobal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleGlobal" icon.</summary>
        public static UnityEditorIcon d_ToolHandleGlobal => _d_ToolHandleGlobal;


        private static readonly UnityEditorIcon _d_ToolHandleGlobal2x = BuildIcon("d_ToolHandleGlobal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleGlobal@2x" icon.</summary>
        public static UnityEditorIcon d_ToolHandleGlobal2x => _d_ToolHandleGlobal2x;


        private static readonly UnityEditorIcon _d_ToolHandleLocal = BuildIcon("d_ToolHandleLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleLocal" icon.</summary>
        public static UnityEditorIcon d_ToolHandleLocal => _d_ToolHandleLocal;


        private static readonly UnityEditorIcon _d_ToolHandleLocal2x = BuildIcon("d_ToolHandleLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandleLocal@2x" icon.</summary>
        public static UnityEditorIcon d_ToolHandleLocal2x => _d_ToolHandleLocal2x;


        private static readonly UnityEditorIcon _d_ToolHandlePivot = BuildIcon("d_ToolHandlePivot");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandlePivot" icon.</summary>
        public static UnityEditorIcon d_ToolHandlePivot => _d_ToolHandlePivot;


        private static readonly UnityEditorIcon _d_ToolHandlePivot2x = BuildIcon("d_ToolHandlePivot@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolHandlePivot@2x" icon.</summary>
        public static UnityEditorIcon d_ToolHandlePivot2x => _d_ToolHandlePivot2x;


        private static readonly UnityEditorIcon _d_ToolsIcon = BuildIcon("d_ToolsIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToolsIcon" icon.</summary>
        public static UnityEditorIcon d_ToolsIcon => _d_ToolsIcon;


        private static readonly UnityEditorIcon _d_tranp = BuildIcon("d_tranp");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tranp" icon.</summary>
        public static UnityEditorIcon d_tranp => _d_tranp;


        private static readonly UnityEditorIcon _d_TransformTool_On = BuildIcon("d_TransformTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TransformTool On" icon.</summary>
        public static UnityEditorIcon d_TransformTool_On => _d_TransformTool_On;


        private static readonly UnityEditorIcon _d_TransformTool_On2x = BuildIcon("d_TransformTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TransformTool On@2x" icon.</summary>
        public static UnityEditorIcon d_TransformTool_On2x => _d_TransformTool_On2x;


        private static readonly UnityEditorIcon _d_TransformTool = BuildIcon("d_TransformTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TransformTool" icon.</summary>
        public static UnityEditorIcon d_TransformTool => _d_TransformTool;


        private static readonly UnityEditorIcon _d_TransformTool2x = BuildIcon("d_TransformTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TransformTool@2x" icon.</summary>
        public static UnityEditorIcon d_TransformTool2x => _d_TransformTool2x;


        private static readonly UnityEditorIcon _d_tree_icon = BuildIcon("d_tree_icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tree_icon" icon.</summary>
        public static UnityEditorIcon d_tree_icon => _d_tree_icon;


        private static readonly UnityEditorIcon _d_tree_icon_branch = BuildIcon("d_tree_icon_branch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tree_icon_branch" icon.</summary>
        public static UnityEditorIcon d_tree_icon_branch => _d_tree_icon_branch;


        private static readonly UnityEditorIcon _d_tree_icon_branch_frond = BuildIcon("d_tree_icon_branch_frond");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tree_icon_branch_frond" icon.</summary>
        public static UnityEditorIcon d_tree_icon_branch_frond => _d_tree_icon_branch_frond;


        private static readonly UnityEditorIcon _d_tree_icon_frond = BuildIcon("d_tree_icon_frond");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tree_icon_frond" icon.</summary>
        public static UnityEditorIcon d_tree_icon_frond => _d_tree_icon_frond;


        private static readonly UnityEditorIcon _d_tree_icon_leaf = BuildIcon("d_tree_icon_leaf");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_tree_icon_leaf" icon.</summary>
        public static UnityEditorIcon d_tree_icon_leaf => _d_tree_icon_leaf;


        private static readonly UnityEditorIcon _d_TreeEditor_AddBranches = BuildIcon("d_TreeEditor.AddBranches");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.AddBranches" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_AddBranches => _d_TreeEditor_AddBranches;


        private static readonly UnityEditorIcon _d_TreeEditor_AddLeaves = BuildIcon("d_TreeEditor.AddLeaves");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.AddLeaves" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_AddLeaves => _d_TreeEditor_AddLeaves;


        private static readonly UnityEditorIcon _d_TreeEditor_Branch_On = BuildIcon("d_TreeEditor.Branch On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Branch On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Branch_On => _d_TreeEditor_Branch_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Branch = BuildIcon("d_TreeEditor.Branch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Branch" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Branch => _d_TreeEditor_Branch;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchFreeHand_On = BuildIcon("d_TreeEditor.BranchFreeHand On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchFreeHand On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchFreeHand_On => _d_TreeEditor_BranchFreeHand_On;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchFreeHand = BuildIcon("d_TreeEditor.BranchFreeHand");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchFreeHand" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchFreeHand => _d_TreeEditor_BranchFreeHand;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchRotate_On = BuildIcon("d_TreeEditor.BranchRotate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchRotate On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchRotate_On => _d_TreeEditor_BranchRotate_On;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchRotate = BuildIcon("d_TreeEditor.BranchRotate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchRotate" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchRotate => _d_TreeEditor_BranchRotate;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchScale_On = BuildIcon("d_TreeEditor.BranchScale On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchScale On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchScale_On => _d_TreeEditor_BranchScale_On;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchScale = BuildIcon("d_TreeEditor.BranchScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchScale" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchScale => _d_TreeEditor_BranchScale;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchTranslate_On = BuildIcon("d_TreeEditor.BranchTranslate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchTranslate On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchTranslate_On => _d_TreeEditor_BranchTranslate_On;


        private static readonly UnityEditorIcon _d_TreeEditor_BranchTranslate = BuildIcon("d_TreeEditor.BranchTranslate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.BranchTranslate" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_BranchTranslate => _d_TreeEditor_BranchTranslate;


        private static readonly UnityEditorIcon _d_TreeEditor_Distribution_On = BuildIcon("d_TreeEditor.Distribution On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Distribution On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Distribution_On => _d_TreeEditor_Distribution_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Distribution = BuildIcon("d_TreeEditor.Distribution");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Distribution" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Distribution => _d_TreeEditor_Distribution;


        private static readonly UnityEditorIcon _d_TreeEditor_Duplicate = BuildIcon("d_TreeEditor.Duplicate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Duplicate" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Duplicate => _d_TreeEditor_Duplicate;


        private static readonly UnityEditorIcon _d_TreeEditor_Geometry_On = BuildIcon("d_TreeEditor.Geometry On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Geometry On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Geometry_On => _d_TreeEditor_Geometry_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Geometry = BuildIcon("d_TreeEditor.Geometry");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Geometry" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Geometry => _d_TreeEditor_Geometry;


        private static readonly UnityEditorIcon _d_TreeEditor_Leaf_On = BuildIcon("d_TreeEditor.Leaf On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Leaf On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Leaf_On => _d_TreeEditor_Leaf_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Leaf = BuildIcon("d_TreeEditor.Leaf");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Leaf" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Leaf => _d_TreeEditor_Leaf;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafFreeHand_On = BuildIcon("d_TreeEditor.LeafFreeHand On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafFreeHand On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafFreeHand_On => _d_TreeEditor_LeafFreeHand_On;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafFreeHand = BuildIcon("d_TreeEditor.LeafFreeHand");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafFreeHand" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafFreeHand => _d_TreeEditor_LeafFreeHand;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafRotate_On = BuildIcon("d_TreeEditor.LeafRotate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafRotate On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafRotate_On => _d_TreeEditor_LeafRotate_On;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafRotate = BuildIcon("d_TreeEditor.LeafRotate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafRotate" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafRotate => _d_TreeEditor_LeafRotate;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafScale_On = BuildIcon("d_TreeEditor.LeafScale On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafScale On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafScale_On => _d_TreeEditor_LeafScale_On;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafScale = BuildIcon("d_TreeEditor.LeafScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafScale" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafScale => _d_TreeEditor_LeafScale;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafTranslate_On = BuildIcon("d_TreeEditor.LeafTranslate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafTranslate On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafTranslate_On => _d_TreeEditor_LeafTranslate_On;


        private static readonly UnityEditorIcon _d_TreeEditor_LeafTranslate = BuildIcon("d_TreeEditor.LeafTranslate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.LeafTranslate" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_LeafTranslate => _d_TreeEditor_LeafTranslate;


        private static readonly UnityEditorIcon _d_TreeEditor_Material_On = BuildIcon("d_TreeEditor.Material On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Material On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Material_On => _d_TreeEditor_Material_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Material = BuildIcon("d_TreeEditor.Material");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Material" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Material => _d_TreeEditor_Material;


        private static readonly UnityEditorIcon _d_TreeEditor_Refresh = BuildIcon("d_TreeEditor.Refresh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Refresh" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Refresh => _d_TreeEditor_Refresh;


        private static readonly UnityEditorIcon _d_TreeEditor_Trash = BuildIcon("d_TreeEditor.Trash");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Trash" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Trash => _d_TreeEditor_Trash;


        private static readonly UnityEditorIcon _d_TreeEditor_Wind_On = BuildIcon("d_TreeEditor.Wind On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Wind On" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Wind_On => _d_TreeEditor_Wind_On;


        private static readonly UnityEditorIcon _d_TreeEditor_Wind = BuildIcon("d_TreeEditor.Wind");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TreeEditor.Wind" icon.</summary>
        public static UnityEditorIcon d_TreeEditor_Wind => _d_TreeEditor_Wind;


        private static readonly UnityEditorIcon _d_UnityEditor_AnimationWindow = BuildIcon("d_UnityEditor.AnimationWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.AnimationWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_AnimationWindow => _d_UnityEditor_AnimationWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_AnimationWindow2x = BuildIcon("d_UnityEditor.AnimationWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.AnimationWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_AnimationWindow2x => _d_UnityEditor_AnimationWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_ConsoleWindow = BuildIcon("d_UnityEditor.ConsoleWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.ConsoleWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_ConsoleWindow => _d_UnityEditor_ConsoleWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_ConsoleWindow2x = BuildIcon("d_UnityEditor.ConsoleWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.ConsoleWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_ConsoleWindow2x => _d_UnityEditor_ConsoleWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_DebugInspectorWindow = BuildIcon("d_UnityEditor.DebugInspectorWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.DebugInspectorWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_DebugInspectorWindow => _d_UnityEditor_DebugInspectorWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_FindDependencies = BuildIcon("d_UnityEditor.FindDependencies");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.FindDependencies" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_FindDependencies => _d_UnityEditor_FindDependencies;


        private static readonly UnityEditorIcon _d_UnityEditor_GameView = BuildIcon("d_UnityEditor.GameView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.GameView" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_GameView => _d_UnityEditor_GameView;


        private static readonly UnityEditorIcon _d_UnityEditor_GameView2x = BuildIcon("d_UnityEditor.GameView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.GameView@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_GameView2x => _d_UnityEditor_GameView2x;


        private static readonly UnityEditorIcon _d_UnityEditor_Graphs_AnimatorControllerTool = BuildIcon("d_UnityEditor.Graphs.AnimatorControllerTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.Graphs.AnimatorControllerTool" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_Graphs_AnimatorControllerTool => _d_UnityEditor_Graphs_AnimatorControllerTool;


        private static readonly UnityEditorIcon _d_UnityEditor_Graphs_AnimatorControllerTool2x = BuildIcon("d_UnityEditor.Graphs.AnimatorControllerTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.Graphs.AnimatorControllerTool@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_Graphs_AnimatorControllerTool2x => _d_UnityEditor_Graphs_AnimatorControllerTool2x;


        private static readonly UnityEditorIcon _d_UnityEditor_HierarchyWindow = BuildIcon("d_UnityEditor.HierarchyWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.HierarchyWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_HierarchyWindow => _d_UnityEditor_HierarchyWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_InspectorWindow = BuildIcon("d_UnityEditor.InspectorWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.InspectorWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_InspectorWindow => _d_UnityEditor_InspectorWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_InspectorWindow2x = BuildIcon("d_UnityEditor.InspectorWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.InspectorWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_InspectorWindow2x => _d_UnityEditor_InspectorWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_ProfilerWindow = BuildIcon("d_UnityEditor.ProfilerWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.ProfilerWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_ProfilerWindow => _d_UnityEditor_ProfilerWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_ProfilerWindow2x = BuildIcon("d_UnityEditor.ProfilerWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.ProfilerWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_ProfilerWindow2x => _d_UnityEditor_ProfilerWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_SceneHierarchyWindow = BuildIcon("d_UnityEditor.SceneHierarchyWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.SceneHierarchyWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_SceneHierarchyWindow => _d_UnityEditor_SceneHierarchyWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_SceneHierarchyWindow2x = BuildIcon("d_UnityEditor.SceneHierarchyWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.SceneHierarchyWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_SceneHierarchyWindow2x => _d_UnityEditor_SceneHierarchyWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_SceneView = BuildIcon("d_UnityEditor.SceneView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.SceneView" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_SceneView => _d_UnityEditor_SceneView;


        private static readonly UnityEditorIcon _d_UnityEditor_SceneView2x = BuildIcon("d_UnityEditor.SceneView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.SceneView@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_SceneView2x => _d_UnityEditor_SceneView2x;


        private static readonly UnityEditorIcon _d_UnityEditor_Timeline_TimelineWindow = BuildIcon("d_UnityEditor.Timeline.TimelineWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.Timeline.TimelineWindow" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_Timeline_TimelineWindow => _d_UnityEditor_Timeline_TimelineWindow;


        private static readonly UnityEditorIcon _d_UnityEditor_Timeline_TimelineWindow2x = BuildIcon("d_UnityEditor.Timeline.TimelineWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.Timeline.TimelineWindow@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_Timeline_TimelineWindow2x => _d_UnityEditor_Timeline_TimelineWindow2x;


        private static readonly UnityEditorIcon _d_UnityEditor_VersionControl = BuildIcon("d_UnityEditor.VersionControl");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.VersionControl" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_VersionControl => _d_UnityEditor_VersionControl;


        private static readonly UnityEditorIcon _d_UnityEditor_VersionControl2x = BuildIcon("d_UnityEditor.VersionControl@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityEditor.VersionControl@2x" icon.</summary>
        public static UnityEditorIcon d_UnityEditor_VersionControl2x => _d_UnityEditor_VersionControl2x;


        private static readonly UnityEditorIcon _d_UnityLogo = BuildIcon("d_UnityLogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_UnityLogo" icon.</summary>
        public static UnityEditorIcon d_UnityLogo => _d_UnityLogo;


        private static readonly UnityEditorIcon _d_Unlinked = BuildIcon("d_Unlinked");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Unlinked" icon.</summary>
        public static UnityEditorIcon d_Unlinked => _d_Unlinked;


        private static readonly UnityEditorIcon _d_Unlinked2x = BuildIcon("d_Unlinked@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Unlinked@2x" icon.</summary>
        public static UnityEditorIcon d_Unlinked2x => _d_Unlinked2x;


        private static readonly UnityEditorIcon _d_Valid = BuildIcon("d_Valid");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Valid" icon.</summary>
        public static UnityEditorIcon d_Valid => _d_Valid;


        private static readonly UnityEditorIcon _d_Valid2x = BuildIcon("d_Valid@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Valid@2x" icon.</summary>
        public static UnityEditorIcon d_Valid2x => _d_Valid2x;


        private static readonly UnityEditorIcon _d_VerticalSplit = BuildIcon("d_VerticalSplit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VerticalSplit" icon.</summary>
        public static UnityEditorIcon d_VerticalSplit => _d_VerticalSplit;


        private static readonly UnityEditorIcon _d_ViewToolMove_On = BuildIcon("d_ViewToolMove On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolMove On" icon.</summary>
        public static UnityEditorIcon d_ViewToolMove_On => _d_ViewToolMove_On;


        private static readonly UnityEditorIcon _d_ViewToolMove_On2x = BuildIcon("d_ViewToolMove On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolMove On@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolMove_On2x => _d_ViewToolMove_On2x;


        private static readonly UnityEditorIcon _d_ViewToolMove = BuildIcon("d_ViewToolMove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolMove" icon.</summary>
        public static UnityEditorIcon d_ViewToolMove => _d_ViewToolMove;


        private static readonly UnityEditorIcon _d_ViewToolMove2x = BuildIcon("d_ViewToolMove@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolMove@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolMove2x => _d_ViewToolMove2x;


        private static readonly UnityEditorIcon _d_ViewToolOrbit_On = BuildIcon("d_ViewToolOrbit On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolOrbit On" icon.</summary>
        public static UnityEditorIcon d_ViewToolOrbit_On => _d_ViewToolOrbit_On;


        private static readonly UnityEditorIcon _d_ViewToolOrbit_On2x = BuildIcon("d_ViewToolOrbit On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolOrbit On@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolOrbit_On2x => _d_ViewToolOrbit_On2x;


        private static readonly UnityEditorIcon _d_ViewToolOrbit = BuildIcon("d_ViewToolOrbit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolOrbit" icon.</summary>
        public static UnityEditorIcon d_ViewToolOrbit => _d_ViewToolOrbit;


        private static readonly UnityEditorIcon _d_ViewToolOrbit2x = BuildIcon("d_ViewToolOrbit@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolOrbit@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolOrbit2x => _d_ViewToolOrbit2x;


        private static readonly UnityEditorIcon _d_ViewToolZoom_On = BuildIcon("d_ViewToolZoom On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolZoom On" icon.</summary>
        public static UnityEditorIcon d_ViewToolZoom_On => _d_ViewToolZoom_On;


        private static readonly UnityEditorIcon _d_ViewToolZoom_On2x = BuildIcon("d_ViewToolZoom On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolZoom On@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolZoom_On2x => _d_ViewToolZoom_On2x;


        private static readonly UnityEditorIcon _d_ViewToolZoom = BuildIcon("d_ViewToolZoom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolZoom" icon.</summary>
        public static UnityEditorIcon d_ViewToolZoom => _d_ViewToolZoom;


        private static readonly UnityEditorIcon _d_ViewToolZoom2x = BuildIcon("d_ViewToolZoom@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ViewToolZoom@2x" icon.</summary>
        public static UnityEditorIcon d_ViewToolZoom2x => _d_ViewToolZoom2x;


        private static readonly UnityEditorIcon _d_VisibilityOff = BuildIcon("d_VisibilityOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisibilityOff" icon.</summary>
        public static UnityEditorIcon d_VisibilityOff => _d_VisibilityOff;


        private static readonly UnityEditorIcon _d_VisibilityOn = BuildIcon("d_VisibilityOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisibilityOn" icon.</summary>
        public static UnityEditorIcon d_VisibilityOn => _d_VisibilityOn;


        private static readonly UnityEditorIcon _d_VUMeterTextureHorizontal = BuildIcon("d_VUMeterTextureHorizontal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VUMeterTextureHorizontal" icon.</summary>
        public static UnityEditorIcon d_VUMeterTextureHorizontal => _d_VUMeterTextureHorizontal;


        private static readonly UnityEditorIcon _d_VUMeterTextureVertical = BuildIcon("d_VUMeterTextureVertical");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VUMeterTextureVertical" icon.</summary>
        public static UnityEditorIcon d_VUMeterTextureVertical => _d_VUMeterTextureVertical;


        private static readonly UnityEditorIcon _d_WaitSpin00 = BuildIcon("d_WaitSpin00");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin00" icon.</summary>
        public static UnityEditorIcon d_WaitSpin00 => _d_WaitSpin00;


        private static readonly UnityEditorIcon _d_WaitSpin01 = BuildIcon("d_WaitSpin01");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin01" icon.</summary>
        public static UnityEditorIcon d_WaitSpin01 => _d_WaitSpin01;


        private static readonly UnityEditorIcon _d_WaitSpin02 = BuildIcon("d_WaitSpin02");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin02" icon.</summary>
        public static UnityEditorIcon d_WaitSpin02 => _d_WaitSpin02;


        private static readonly UnityEditorIcon _d_WaitSpin03 = BuildIcon("d_WaitSpin03");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin03" icon.</summary>
        public static UnityEditorIcon d_WaitSpin03 => _d_WaitSpin03;


        private static readonly UnityEditorIcon _d_WaitSpin04 = BuildIcon("d_WaitSpin04");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin04" icon.</summary>
        public static UnityEditorIcon d_WaitSpin04 => _d_WaitSpin04;


        private static readonly UnityEditorIcon _d_WaitSpin05 = BuildIcon("d_WaitSpin05");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin05" icon.</summary>
        public static UnityEditorIcon d_WaitSpin05 => _d_WaitSpin05;


        private static readonly UnityEditorIcon _d_WaitSpin06 = BuildIcon("d_WaitSpin06");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin06" icon.</summary>
        public static UnityEditorIcon d_WaitSpin06 => _d_WaitSpin06;


        private static readonly UnityEditorIcon _d_WaitSpin07 = BuildIcon("d_WaitSpin07");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin07" icon.</summary>
        public static UnityEditorIcon d_WaitSpin07 => _d_WaitSpin07;


        private static readonly UnityEditorIcon _d_WaitSpin08 = BuildIcon("d_WaitSpin08");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin08" icon.</summary>
        public static UnityEditorIcon d_WaitSpin08 => _d_WaitSpin08;


        private static readonly UnityEditorIcon _d_WaitSpin09 = BuildIcon("d_WaitSpin09");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin09" icon.</summary>
        public static UnityEditorIcon d_WaitSpin09 => _d_WaitSpin09;


        private static readonly UnityEditorIcon _d_WaitSpin10 = BuildIcon("d_WaitSpin10");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin10" icon.</summary>
        public static UnityEditorIcon d_WaitSpin10 => _d_WaitSpin10;


        private static readonly UnityEditorIcon _d_WaitSpin11 = BuildIcon("d_WaitSpin11");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WaitSpin11" icon.</summary>
        public static UnityEditorIcon d_WaitSpin11 => _d_WaitSpin11;


        private static readonly UnityEditorIcon _d_WelcomeScreen_AssetStoreLogo = BuildIcon("d_WelcomeScreen.AssetStoreLogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WelcomeScreen.AssetStoreLogo" icon.</summary>
        public static UnityEditorIcon d_WelcomeScreen_AssetStoreLogo => _d_WelcomeScreen_AssetStoreLogo;


        private static readonly UnityEditorIcon _d_winbtn_graph = BuildIcon("d_winbtn_graph");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_graph" icon.</summary>
        public static UnityEditorIcon d_winbtn_graph => _d_winbtn_graph;


        private static readonly UnityEditorIcon _d_winbtn_graph_close_h = BuildIcon("d_winbtn_graph_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_graph_close_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_graph_close_h => _d_winbtn_graph_close_h;


        private static readonly UnityEditorIcon _d_winbtn_graph_max_h = BuildIcon("d_winbtn_graph_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_graph_max_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_graph_max_h => _d_winbtn_graph_max_h;


        private static readonly UnityEditorIcon _d_winbtn_graph_min_h = BuildIcon("d_winbtn_graph_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_graph_min_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_graph_min_h => _d_winbtn_graph_min_h;


        private static readonly UnityEditorIcon _d_winbtn_mac_close = BuildIcon("d_winbtn_mac_close");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close => _d_winbtn_mac_close;


        private static readonly UnityEditorIcon _d_winbtn_mac_close2x = BuildIcon("d_winbtn_mac_close@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close2x => _d_winbtn_mac_close2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_close_a = BuildIcon("d_winbtn_mac_close_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close_a => _d_winbtn_mac_close_a;


        private static readonly UnityEditorIcon _d_winbtn_mac_close_a2x = BuildIcon("d_winbtn_mac_close_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close_a2x => _d_winbtn_mac_close_a2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_close_h = BuildIcon("d_winbtn_mac_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close_h => _d_winbtn_mac_close_h;


        private static readonly UnityEditorIcon _d_winbtn_mac_close_h2x = BuildIcon("d_winbtn_mac_close_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_close_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_close_h2x => _d_winbtn_mac_close_h2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_inact = BuildIcon("d_winbtn_mac_inact");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_inact" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_inact => _d_winbtn_mac_inact;


        private static readonly UnityEditorIcon _d_winbtn_mac_max = BuildIcon("d_winbtn_mac_max");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max => _d_winbtn_mac_max;


        private static readonly UnityEditorIcon _d_winbtn_mac_max2x = BuildIcon("d_winbtn_mac_max@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max2x => _d_winbtn_mac_max2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_max_a = BuildIcon("d_winbtn_mac_max_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max_a => _d_winbtn_mac_max_a;


        private static readonly UnityEditorIcon _d_winbtn_mac_max_a2x = BuildIcon("d_winbtn_mac_max_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max_a2x => _d_winbtn_mac_max_a2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_max_h = BuildIcon("d_winbtn_mac_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max_h => _d_winbtn_mac_max_h;


        private static readonly UnityEditorIcon _d_winbtn_mac_max_h2x = BuildIcon("d_winbtn_mac_max_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_max_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_max_h2x => _d_winbtn_mac_max_h2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_min = BuildIcon("d_winbtn_mac_min");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min => _d_winbtn_mac_min;


        private static readonly UnityEditorIcon _d_winbtn_mac_min2x = BuildIcon("d_winbtn_mac_min@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min2x => _d_winbtn_mac_min2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_min_a = BuildIcon("d_winbtn_mac_min_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min_a => _d_winbtn_mac_min_a;


        private static readonly UnityEditorIcon _d_winbtn_mac_min_a2x = BuildIcon("d_winbtn_mac_min_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min_a2x => _d_winbtn_mac_min_a2x;


        private static readonly UnityEditorIcon _d_winbtn_mac_min_h = BuildIcon("d_winbtn_mac_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min_h => _d_winbtn_mac_min_h;


        private static readonly UnityEditorIcon _d_winbtn_mac_min_h2x = BuildIcon("d_winbtn_mac_min_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_mac_min_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_mac_min_h2x => _d_winbtn_mac_min_h2x;


        private static readonly UnityEditorIcon _d_winbtn_win_close = BuildIcon("d_winbtn_win_close");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close => _d_winbtn_win_close;


        private static readonly UnityEditorIcon _d_winbtn_win_close2x = BuildIcon("d_winbtn_win_close@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close2x => _d_winbtn_win_close2x;


        private static readonly UnityEditorIcon _d_winbtn_win_close_a = BuildIcon("d_winbtn_win_close_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close_a => _d_winbtn_win_close_a;


        private static readonly UnityEditorIcon _d_winbtn_win_close_a2x = BuildIcon("d_winbtn_win_close_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close_a2x => _d_winbtn_win_close_a2x;


        private static readonly UnityEditorIcon _d_winbtn_win_close_h = BuildIcon("d_winbtn_win_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close_h => _d_winbtn_win_close_h;


        private static readonly UnityEditorIcon _d_winbtn_win_close_h2x = BuildIcon("d_winbtn_win_close_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_close_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_close_h2x => _d_winbtn_win_close_h2x;


        private static readonly UnityEditorIcon _d_winbtn_win_max = BuildIcon("d_winbtn_win_max");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max => _d_winbtn_win_max;


        private static readonly UnityEditorIcon _d_winbtn_win_max2x = BuildIcon("d_winbtn_win_max@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max2x => _d_winbtn_win_max2x;


        private static readonly UnityEditorIcon _d_winbtn_win_max_a = BuildIcon("d_winbtn_win_max_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max_a => _d_winbtn_win_max_a;


        private static readonly UnityEditorIcon _d_winbtn_win_max_a2x = BuildIcon("d_winbtn_win_max_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max_a2x => _d_winbtn_win_max_a2x;


        private static readonly UnityEditorIcon _d_winbtn_win_max_h = BuildIcon("d_winbtn_win_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max_h => _d_winbtn_win_max_h;


        private static readonly UnityEditorIcon _d_winbtn_win_max_h2x = BuildIcon("d_winbtn_win_max_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_max_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_max_h2x => _d_winbtn_win_max_h2x;


        private static readonly UnityEditorIcon _d_winbtn_win_min = BuildIcon("d_winbtn_win_min");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_min" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_min => _d_winbtn_win_min;


        private static readonly UnityEditorIcon _d_winbtn_win_min_a = BuildIcon("d_winbtn_win_min_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_min_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_min_a => _d_winbtn_win_min_a;


        private static readonly UnityEditorIcon _d_winbtn_win_min_h = BuildIcon("d_winbtn_win_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_min_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_min_h => _d_winbtn_win_min_h;


        private static readonly UnityEditorIcon _d_winbtn_win_rest = BuildIcon("d_winbtn_win_rest");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_rest" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_rest => _d_winbtn_win_rest;


        private static readonly UnityEditorIcon _d_winbtn_win_rest_a = BuildIcon("d_winbtn_win_rest_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_rest_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_rest_a => _d_winbtn_win_rest_a;


        private static readonly UnityEditorIcon _d_winbtn_win_rest_h = BuildIcon("d_winbtn_win_rest_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_rest_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_rest_h => _d_winbtn_win_rest_h;


        private static readonly UnityEditorIcon _d_winbtn_win_restore = BuildIcon("d_winbtn_win_restore");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore => _d_winbtn_win_restore;


        private static readonly UnityEditorIcon _d_winbtn_win_restore2x = BuildIcon("d_winbtn_win_restore@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore2x => _d_winbtn_win_restore2x;


        private static readonly UnityEditorIcon _d_winbtn_win_restore_a = BuildIcon("d_winbtn_win_restore_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore_a" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore_a => _d_winbtn_win_restore_a;


        private static readonly UnityEditorIcon _d_winbtn_win_restore_a2x = BuildIcon("d_winbtn_win_restore_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore_a@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore_a2x => _d_winbtn_win_restore_a2x;


        private static readonly UnityEditorIcon _d_winbtn_win_restore_h = BuildIcon("d_winbtn_win_restore_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore_h" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore_h => _d_winbtn_win_restore_h;


        private static readonly UnityEditorIcon _d_winbtn_win_restore_h2x = BuildIcon("d_winbtn_win_restore_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_winbtn_win_restore_h@2x" icon.</summary>
        public static UnityEditorIcon d_winbtn_win_restore_h2x => _d_winbtn_win_restore_h2x;


        private static readonly UnityEditorIcon _DebuggerAttached = BuildIcon("DebuggerAttached");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerAttached" icon.</summary>
        public static UnityEditorIcon DebuggerAttached => _DebuggerAttached;


        private static readonly UnityEditorIcon _DebuggerAttached2x = BuildIcon("DebuggerAttached@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerAttached@2x" icon.</summary>
        public static UnityEditorIcon DebuggerAttached2x => _DebuggerAttached2x;


        private static readonly UnityEditorIcon _DebuggerDisabled = BuildIcon("DebuggerDisabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerDisabled" icon.</summary>
        public static UnityEditorIcon DebuggerDisabled => _DebuggerDisabled;


        private static readonly UnityEditorIcon _DebuggerDisabled2x = BuildIcon("DebuggerDisabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerDisabled@2x" icon.</summary>
        public static UnityEditorIcon DebuggerDisabled2x => _DebuggerDisabled2x;


        private static readonly UnityEditorIcon _DebuggerEnabled = BuildIcon("DebuggerEnabled");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerEnabled" icon.</summary>
        public static UnityEditorIcon DebuggerEnabled => _DebuggerEnabled;


        private static readonly UnityEditorIcon _DebuggerEnabled2x = BuildIcon("DebuggerEnabled@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DebuggerEnabled@2x" icon.</summary>
        public static UnityEditorIcon DebuggerEnabled2x => _DebuggerEnabled2x;


        private static readonly UnityEditorIcon _DefaultSorting = BuildIcon("DefaultSorting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DefaultSorting" icon.</summary>
        public static UnityEditorIcon DefaultSorting => _DefaultSorting;


        private static readonly UnityEditorIcon _DefaultSorting2x = BuildIcon("DefaultSorting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DefaultSorting@2x" icon.</summary>
        public static UnityEditorIcon DefaultSorting2x => _DefaultSorting2x;


        private static readonly UnityEditorIcon _EditCollider = BuildIcon("EditCollider");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EditCollider" icon.</summary>
        public static UnityEditorIcon EditCollider => _EditCollider;


        private static readonly UnityEditorIcon _editcollision_16 = BuildIcon("editcollision_16");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editcollision_16" icon.</summary>
        public static UnityEditorIcon editcollision_16 => _editcollision_16;


        private static readonly UnityEditorIcon _editcollision_162x = BuildIcon("editcollision_16@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editcollision_16@2x" icon.</summary>
        public static UnityEditorIcon editcollision_162x => _editcollision_162x;


        private static readonly UnityEditorIcon _editcollision_32 = BuildIcon("editcollision_32");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editcollision_32" icon.</summary>
        public static UnityEditorIcon editcollision_32 => _editcollision_32;


        private static readonly UnityEditorIcon _editconstraints_16 = BuildIcon("editconstraints_16");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editconstraints_16" icon.</summary>
        public static UnityEditorIcon editconstraints_16 => _editconstraints_16;


        private static readonly UnityEditorIcon _editconstraints_162x = BuildIcon("editconstraints_16@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editconstraints_16@2x" icon.</summary>
        public static UnityEditorIcon editconstraints_162x => _editconstraints_162x;


        private static readonly UnityEditorIcon _editconstraints_32 = BuildIcon("editconstraints_32");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editconstraints_32" icon.</summary>
        public static UnityEditorIcon editconstraints_32 => _editconstraints_32;


        private static readonly UnityEditorIcon _editicon_sml = BuildIcon("editicon.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "editicon.sml" icon.</summary>
        public static UnityEditorIcon editicon_sml => _editicon_sml;


        private static readonly UnityEditorIcon _endButton_On = BuildIcon("endButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "endButton-On" icon.</summary>
        public static UnityEditorIcon endButton_On => _endButton_On;


        private static readonly UnityEditorIcon _endButton = BuildIcon("endButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "endButton" icon.</summary>
        public static UnityEditorIcon endButton => _endButton;


        private static readonly UnityEditorIcon _Exposure = BuildIcon("Exposure");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Exposure" icon.</summary>
        public static UnityEditorIcon Exposure => _Exposure;


        private static readonly UnityEditorIcon _Exposure2x = BuildIcon("Exposure@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Exposure@2x" icon.</summary>
        public static UnityEditorIcon Exposure2x => _Exposure2x;


        private static readonly UnityEditorIcon _eyeDropper_Large = BuildIcon("eyeDropper.Large");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "eyeDropper.Large" icon.</summary>
        public static UnityEditorIcon eyeDropper_Large => _eyeDropper_Large;


        private static readonly UnityEditorIcon _eyeDropper_Large2x = BuildIcon("eyeDropper.Large@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "eyeDropper.Large@2x" icon.</summary>
        public static UnityEditorIcon eyeDropper_Large2x => _eyeDropper_Large2x;


        private static readonly UnityEditorIcon _eyeDropper_sml = BuildIcon("eyeDropper.sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "eyeDropper.sml" icon.</summary>
        public static UnityEditorIcon eyeDropper_sml => _eyeDropper_sml;


        private static readonly UnityEditorIcon _Favorite = BuildIcon("Favorite");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Favorite" icon.</summary>
        public static UnityEditorIcon Favorite => _Favorite;


        private static readonly UnityEditorIcon _Favorite2x = BuildIcon("Favorite@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Favorite@2x" icon.</summary>
        public static UnityEditorIcon Favorite2x => _Favorite2x;


        private static readonly UnityEditorIcon _FilterByLabel = BuildIcon("FilterByLabel");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterByLabel" icon.</summary>
        public static UnityEditorIcon FilterByLabel => _FilterByLabel;


        private static readonly UnityEditorIcon _FilterByLabel2x = BuildIcon("FilterByLabel@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterByLabel@2x" icon.</summary>
        public static UnityEditorIcon FilterByLabel2x => _FilterByLabel2x;


        private static readonly UnityEditorIcon _FilterByType = BuildIcon("FilterByType");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterByType" icon.</summary>
        public static UnityEditorIcon FilterByType => _FilterByType;


        private static readonly UnityEditorIcon _FilterByType2x = BuildIcon("FilterByType@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterByType@2x" icon.</summary>
        public static UnityEditorIcon FilterByType2x => _FilterByType2x;


        private static readonly UnityEditorIcon _FilterSelectedOnly = BuildIcon("FilterSelectedOnly");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterSelectedOnly" icon.</summary>
        public static UnityEditorIcon FilterSelectedOnly => _FilterSelectedOnly;


        private static readonly UnityEditorIcon _FilterSelectedOnly2x = BuildIcon("FilterSelectedOnly@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FilterSelectedOnly@2x" icon.</summary>
        public static UnityEditorIcon FilterSelectedOnly2x => _FilterSelectedOnly2x;


        private static readonly UnityEditorIcon _forward = BuildIcon("forward");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "forward" icon.</summary>
        public static UnityEditorIcon forward => _forward;


        private static readonly UnityEditorIcon _forward2x = BuildIcon("forward@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "forward@2x" icon.</summary>
        public static UnityEditorIcon forward2x => _forward2x;


        private static readonly UnityEditorIcon _FrameCapture = BuildIcon("FrameCapture");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FrameCapture" icon.</summary>
        public static UnityEditorIcon FrameCapture => _FrameCapture;


        private static readonly UnityEditorIcon _FrameCapture2x = BuildIcon("FrameCapture@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FrameCapture@2x" icon.</summary>
        public static UnityEditorIcon FrameCapture2x => _FrameCapture2x;


        private static readonly UnityEditorIcon _GEAR = BuildIcon("GEAR");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GEAR" icon.</summary>
        public static UnityEditorIcon GEAR => _GEAR;


        private static readonly UnityEditorIcon _Grid_BoxTool = BuildIcon("Grid.BoxTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.BoxTool" icon.</summary>
        public static UnityEditorIcon Grid_BoxTool => _Grid_BoxTool;


        private static readonly UnityEditorIcon _Grid_BoxTool2x = BuildIcon("Grid.BoxTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.BoxTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_BoxTool2x => _Grid_BoxTool2x;


        private static readonly UnityEditorIcon _Grid_Default = BuildIcon("Grid.Default");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.Default" icon.</summary>
        public static UnityEditorIcon Grid_Default => _Grid_Default;


        private static readonly UnityEditorIcon _Grid_Default2x = BuildIcon("Grid.Default@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.Default@2x" icon.</summary>
        public static UnityEditorIcon Grid_Default2x => _Grid_Default2x;


        private static readonly UnityEditorIcon _Grid_EraserTool = BuildIcon("Grid.EraserTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.EraserTool" icon.</summary>
        public static UnityEditorIcon Grid_EraserTool => _Grid_EraserTool;


        private static readonly UnityEditorIcon _Grid_EraserTool2x = BuildIcon("Grid.EraserTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.EraserTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_EraserTool2x => _Grid_EraserTool2x;


        private static readonly UnityEditorIcon _Grid_FillTool = BuildIcon("Grid.FillTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.FillTool" icon.</summary>
        public static UnityEditorIcon Grid_FillTool => _Grid_FillTool;


        private static readonly UnityEditorIcon _Grid_FillTool2x = BuildIcon("Grid.FillTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.FillTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_FillTool2x => _Grid_FillTool2x;


        private static readonly UnityEditorIcon _Grid_MoveTool = BuildIcon("Grid.MoveTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.MoveTool" icon.</summary>
        public static UnityEditorIcon Grid_MoveTool => _Grid_MoveTool;


        private static readonly UnityEditorIcon _Grid_MoveTool2x = BuildIcon("Grid.MoveTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.MoveTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_MoveTool2x => _Grid_MoveTool2x;


        private static readonly UnityEditorIcon _Grid_PaintTool = BuildIcon("Grid.PaintTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.PaintTool" icon.</summary>
        public static UnityEditorIcon Grid_PaintTool => _Grid_PaintTool;


        private static readonly UnityEditorIcon _Grid_PaintTool2x = BuildIcon("Grid.PaintTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.PaintTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_PaintTool2x => _Grid_PaintTool2x;


        private static readonly UnityEditorIcon _Grid_PickingTool = BuildIcon("Grid.PickingTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.PickingTool" icon.</summary>
        public static UnityEditorIcon Grid_PickingTool => _Grid_PickingTool;


        private static readonly UnityEditorIcon _Grid_PickingTool2x = BuildIcon("Grid.PickingTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid.PickingTool@2x" icon.</summary>
        public static UnityEditorIcon Grid_PickingTool2x => _Grid_PickingTool2x;


        private static readonly UnityEditorIcon _Groove = BuildIcon("Groove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Groove" icon.</summary>
        public static UnityEditorIcon Groove => _Groove;


        private static readonly UnityEditorIcon _align_horizontally = BuildIcon("align_horizontally");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally" icon.</summary>
        public static UnityEditorIcon align_horizontally => _align_horizontally;


        private static readonly UnityEditorIcon _align_horizontally_center = BuildIcon("align_horizontally_center");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_center" icon.</summary>
        public static UnityEditorIcon align_horizontally_center => _align_horizontally_center;


        private static readonly UnityEditorIcon _align_horizontally_center_active = BuildIcon("align_horizontally_center_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_center_active" icon.</summary>
        public static UnityEditorIcon align_horizontally_center_active => _align_horizontally_center_active;


        private static readonly UnityEditorIcon _align_horizontally_left = BuildIcon("align_horizontally_left");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_left" icon.</summary>
        public static UnityEditorIcon align_horizontally_left => _align_horizontally_left;


        private static readonly UnityEditorIcon _align_horizontally_left_active = BuildIcon("align_horizontally_left_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_left_active" icon.</summary>
        public static UnityEditorIcon align_horizontally_left_active => _align_horizontally_left_active;


        private static readonly UnityEditorIcon _align_horizontally_right = BuildIcon("align_horizontally_right");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_right" icon.</summary>
        public static UnityEditorIcon align_horizontally_right => _align_horizontally_right;


        private static readonly UnityEditorIcon _align_horizontally_right_active = BuildIcon("align_horizontally_right_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_horizontally_right_active" icon.</summary>
        public static UnityEditorIcon align_horizontally_right_active => _align_horizontally_right_active;


        private static readonly UnityEditorIcon _align_vertically = BuildIcon("align_vertically");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically" icon.</summary>
        public static UnityEditorIcon align_vertically => _align_vertically;


        private static readonly UnityEditorIcon _align_vertically_bottom = BuildIcon("align_vertically_bottom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_bottom" icon.</summary>
        public static UnityEditorIcon align_vertically_bottom => _align_vertically_bottom;


        private static readonly UnityEditorIcon _align_vertically_bottom_active = BuildIcon("align_vertically_bottom_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_bottom_active" icon.</summary>
        public static UnityEditorIcon align_vertically_bottom_active => _align_vertically_bottom_active;


        private static readonly UnityEditorIcon _align_vertically_center = BuildIcon("align_vertically_center");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_center" icon.</summary>
        public static UnityEditorIcon align_vertically_center => _align_vertically_center;


        private static readonly UnityEditorIcon _align_vertically_center_active = BuildIcon("align_vertically_center_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_center_active" icon.</summary>
        public static UnityEditorIcon align_vertically_center_active => _align_vertically_center_active;


        private static readonly UnityEditorIcon _align_vertically_top = BuildIcon("align_vertically_top");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_top" icon.</summary>
        public static UnityEditorIcon align_vertically_top => _align_vertically_top;


        private static readonly UnityEditorIcon _align_vertically_top_active = BuildIcon("align_vertically_top_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "align_vertically_top_active" icon.</summary>
        public static UnityEditorIcon align_vertically_top_active => _align_vertically_top_active;


        private static readonly UnityEditorIcon _d_align_horizontally = BuildIcon("d_align_horizontally");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally" icon.</summary>
        public static UnityEditorIcon d_align_horizontally => _d_align_horizontally;


        private static readonly UnityEditorIcon _d_align_horizontally_center = BuildIcon("d_align_horizontally_center");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_center" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_center => _d_align_horizontally_center;


        private static readonly UnityEditorIcon _d_align_horizontally_center_active = BuildIcon("d_align_horizontally_center_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_center_active" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_center_active => _d_align_horizontally_center_active;


        private static readonly UnityEditorIcon _d_align_horizontally_left = BuildIcon("d_align_horizontally_left");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_left" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_left => _d_align_horizontally_left;


        private static readonly UnityEditorIcon _d_align_horizontally_left_active = BuildIcon("d_align_horizontally_left_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_left_active" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_left_active => _d_align_horizontally_left_active;


        private static readonly UnityEditorIcon _d_align_horizontally_right = BuildIcon("d_align_horizontally_right");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_right" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_right => _d_align_horizontally_right;


        private static readonly UnityEditorIcon _d_align_horizontally_right_active = BuildIcon("d_align_horizontally_right_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_horizontally_right_active" icon.</summary>
        public static UnityEditorIcon d_align_horizontally_right_active => _d_align_horizontally_right_active;


        private static readonly UnityEditorIcon _d_align_vertically = BuildIcon("d_align_vertically");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically" icon.</summary>
        public static UnityEditorIcon d_align_vertically => _d_align_vertically;


        private static readonly UnityEditorIcon _d_align_vertically_bottom = BuildIcon("d_align_vertically_bottom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_bottom" icon.</summary>
        public static UnityEditorIcon d_align_vertically_bottom => _d_align_vertically_bottom;


        private static readonly UnityEditorIcon _d_align_vertically_bottom_active = BuildIcon("d_align_vertically_bottom_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_bottom_active" icon.</summary>
        public static UnityEditorIcon d_align_vertically_bottom_active => _d_align_vertically_bottom_active;


        private static readonly UnityEditorIcon _d_align_vertically_center = BuildIcon("d_align_vertically_center");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_center" icon.</summary>
        public static UnityEditorIcon d_align_vertically_center => _d_align_vertically_center;


        private static readonly UnityEditorIcon _d_align_vertically_center_active = BuildIcon("d_align_vertically_center_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_center_active" icon.</summary>
        public static UnityEditorIcon d_align_vertically_center_active => _d_align_vertically_center_active;


        private static readonly UnityEditorIcon _d_align_vertically_top = BuildIcon("d_align_vertically_top");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_top" icon.</summary>
        public static UnityEditorIcon d_align_vertically_top => _d_align_vertically_top;


        private static readonly UnityEditorIcon _d_align_vertically_top_active = BuildIcon("d_align_vertically_top_active");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_align_vertically_top_active" icon.</summary>
        public static UnityEditorIcon d_align_vertically_top_active => _d_align_vertically_top_active;


        private static readonly UnityEditorIcon _HorizontalSplit = BuildIcon("HorizontalSplit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HorizontalSplit" icon.</summary>
        public static UnityEditorIcon HorizontalSplit => _HorizontalSplit;


        private static readonly UnityEditorIcon _icon_dropdown = BuildIcon("icon dropdown");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "icon dropdown" icon.</summary>
        public static UnityEditorIcon icon_dropdown => _icon_dropdown;


        private static readonly UnityEditorIcon _icon_dropdown2x = BuildIcon("icon dropdown@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "icon dropdown@2x" icon.</summary>
        public static UnityEditorIcon icon_dropdown2x => _icon_dropdown2x;


        private static readonly UnityEditorIcon _Import = BuildIcon("Import");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Import" icon.</summary>
        public static UnityEditorIcon Import => _Import;


        private static readonly UnityEditorIcon _Import2x = BuildIcon("Import@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Import@2x" icon.</summary>
        public static UnityEditorIcon Import2x => _Import2x;


        private static readonly UnityEditorIcon _InspectorLock = BuildIcon("InspectorLock");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "InspectorLock" icon.</summary>
        public static UnityEditorIcon InspectorLock => _InspectorLock;


        private static readonly UnityEditorIcon _Invalid = BuildIcon("Invalid");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Invalid" icon.</summary>
        public static UnityEditorIcon Invalid => _Invalid;


        private static readonly UnityEditorIcon _Invalid2x = BuildIcon("Invalid@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Invalid@2x" icon.</summary>
        public static UnityEditorIcon Invalid2x => _Invalid2x;


        private static readonly UnityEditorIcon _JointAngularLimits = BuildIcon("JointAngularLimits");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "JointAngularLimits" icon.</summary>
        public static UnityEditorIcon JointAngularLimits => _JointAngularLimits;


        private static readonly UnityEditorIcon _KnobCShape = BuildIcon("KnobCShape");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "KnobCShape" icon.</summary>
        public static UnityEditorIcon KnobCShape => _KnobCShape;


        private static readonly UnityEditorIcon _KnobCShapeMini = BuildIcon("KnobCShapeMini");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "KnobCShapeMini" icon.</summary>
        public static UnityEditorIcon KnobCShapeMini => _KnobCShapeMini;


        private static readonly UnityEditorIcon _leftBracket = BuildIcon("leftBracket");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "leftBracket" icon.</summary>
        public static UnityEditorIcon leftBracket => _leftBracket;


        private static readonly UnityEditorIcon _Lighting = BuildIcon("Lighting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Lighting" icon.</summary>
        public static UnityEditorIcon Lighting => _Lighting;


        private static readonly UnityEditorIcon _Lighting2x = BuildIcon("Lighting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Lighting@2x" icon.</summary>
        public static UnityEditorIcon Lighting2x => _Lighting2x;


        private static readonly UnityEditorIcon _LightmapEditor_WindowTitle = BuildIcon("LightmapEditor.WindowTitle");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightmapEditor.WindowTitle" icon.</summary>
        public static UnityEditorIcon LightmapEditor_WindowTitle => _LightmapEditor_WindowTitle;


        private static readonly UnityEditorIcon _LightmapEditor_WindowTitle2x = BuildIcon("LightmapEditor.WindowTitle@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightmapEditor.WindowTitle@2x" icon.</summary>
        public static UnityEditorIcon LightmapEditor_WindowTitle2x => _LightmapEditor_WindowTitle2x;


        private static readonly UnityEditorIcon _Lightmapping = BuildIcon("Lightmapping");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Lightmapping" icon.</summary>
        public static UnityEditorIcon Lightmapping => _Lightmapping;


        private static readonly UnityEditorIcon _d_greenLight = BuildIcon("d_greenLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_greenLight" icon.</summary>
        public static UnityEditorIcon d_greenLight => _d_greenLight;


        private static readonly UnityEditorIcon _d_lightOff = BuildIcon("d_lightOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_lightOff" icon.</summary>
        public static UnityEditorIcon d_lightOff => _d_lightOff;


        private static readonly UnityEditorIcon _d_lightRim = BuildIcon("d_lightRim");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_lightRim" icon.</summary>
        public static UnityEditorIcon d_lightRim => _d_lightRim;


        private static readonly UnityEditorIcon _d_orangeLight = BuildIcon("d_orangeLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_orangeLight" icon.</summary>
        public static UnityEditorIcon d_orangeLight => _d_orangeLight;


        private static readonly UnityEditorIcon _d_redLight = BuildIcon("d_redLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_redLight" icon.</summary>
        public static UnityEditorIcon d_redLight => _d_redLight;


        private static readonly UnityEditorIcon _greenLight = BuildIcon("greenLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "greenLight" icon.</summary>
        public static UnityEditorIcon greenLight => _greenLight;


        private static readonly UnityEditorIcon _lightOff = BuildIcon("lightOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "lightOff" icon.</summary>
        public static UnityEditorIcon lightOff => _lightOff;


        private static readonly UnityEditorIcon _lightRim = BuildIcon("lightRim");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "lightRim" icon.</summary>
        public static UnityEditorIcon lightRim => _lightRim;


        private static readonly UnityEditorIcon _orangeLight = BuildIcon("orangeLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "orangeLight" icon.</summary>
        public static UnityEditorIcon orangeLight => _orangeLight;


        private static readonly UnityEditorIcon _redLight = BuildIcon("redLight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "redLight" icon.</summary>
        public static UnityEditorIcon redLight => _redLight;


        private static readonly UnityEditorIcon _Linked = BuildIcon("Linked");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Linked" icon.</summary>
        public static UnityEditorIcon Linked => _Linked;


        private static readonly UnityEditorIcon _Linked2x = BuildIcon("Linked@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Linked@2x" icon.</summary>
        public static UnityEditorIcon Linked2x => _Linked2x;


        private static readonly UnityEditorIcon _LockIcon_On = BuildIcon("LockIcon-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LockIcon-On" icon.</summary>
        public static UnityEditorIcon LockIcon_On => _LockIcon_On;


        private static readonly UnityEditorIcon _LockIcon = BuildIcon("LockIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LockIcon" icon.</summary>
        public static UnityEditorIcon LockIcon => _LockIcon;


        private static readonly UnityEditorIcon _loop = BuildIcon("loop");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "loop" icon.</summary>
        public static UnityEditorIcon loop => _loop;


        private static readonly UnityEditorIcon _MainStageView = BuildIcon("MainStageView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MainStageView" icon.</summary>
        public static UnityEditorIcon MainStageView => _MainStageView;


        private static readonly UnityEditorIcon _MainStageView2x = BuildIcon("MainStageView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MainStageView@2x" icon.</summary>
        public static UnityEditorIcon MainStageView2x => _MainStageView2x;


        private static readonly UnityEditorIcon _Mirror = BuildIcon("Mirror");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Mirror" icon.</summary>
        public static UnityEditorIcon Mirror => _Mirror;


        private static readonly UnityEditorIcon _monologo = BuildIcon("monologo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "monologo" icon.</summary>
        public static UnityEditorIcon monologo => _monologo;


        private static readonly UnityEditorIcon _MoreOptions = BuildIcon("MoreOptions");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoreOptions" icon.</summary>
        public static UnityEditorIcon MoreOptions => _MoreOptions;


        private static readonly UnityEditorIcon _MoreOptions2x = BuildIcon("MoreOptions@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoreOptions@2x" icon.</summary>
        public static UnityEditorIcon MoreOptions2x => _MoreOptions2x;


        private static readonly UnityEditorIcon _MoveTool_on = BuildIcon("MoveTool on");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoveTool on" icon.</summary>
        public static UnityEditorIcon MoveTool_on => _MoveTool_on;


        private static readonly UnityEditorIcon _MoveTool_On2x = BuildIcon("MoveTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoveTool On@2x" icon.</summary>
        public static UnityEditorIcon MoveTool_On2x => _MoveTool_On2x;


        private static readonly UnityEditorIcon _MoveTool = BuildIcon("MoveTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoveTool" icon.</summary>
        public static UnityEditorIcon MoveTool => _MoveTool;


        private static readonly UnityEditorIcon _MoveTool2x = BuildIcon("MoveTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MoveTool@2x" icon.</summary>
        public static UnityEditorIcon MoveTool2x => _MoveTool2x;


        private static readonly UnityEditorIcon _Navigation = BuildIcon("Navigation");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Navigation" icon.</summary>
        public static UnityEditorIcon Navigation => _Navigation;


        private static readonly UnityEditorIcon _Occlusion = BuildIcon("Occlusion");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Occlusion" icon.</summary>
        public static UnityEditorIcon Occlusion => _Occlusion;


        private static readonly UnityEditorIcon _Occlusion2x = BuildIcon("Occlusion@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Occlusion@2x" icon.</summary>
        public static UnityEditorIcon Occlusion2x => _Occlusion2x;


        private static readonly UnityEditorIcon _Package_Manager = BuildIcon("Package Manager");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Package Manager" icon.</summary>
        public static UnityEditorIcon Package_Manager => _Package_Manager;


        private static readonly UnityEditorIcon _Package_Manager2x = BuildIcon("Package Manager@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Package Manager@2x" icon.</summary>
        public static UnityEditorIcon Package_Manager2x => _Package_Manager2x;


        private static readonly UnityEditorIcon _PackageBadgeDelete = BuildIcon("PackageBadgeDelete");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PackageBadgeDelete" icon.</summary>
        public static UnityEditorIcon PackageBadgeDelete => _PackageBadgeDelete;


        private static readonly UnityEditorIcon _PackageBadgeNew = BuildIcon("PackageBadgeNew");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PackageBadgeNew" icon.</summary>
        public static UnityEditorIcon PackageBadgeNew => _PackageBadgeNew;


        private static readonly UnityEditorIcon _Add_Available = BuildIcon("Add-Available");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Add-Available" icon.</summary>
        public static UnityEditorIcon Add_Available => _Add_Available;


        private static readonly UnityEditorIcon _Add_Available2x = BuildIcon("Add-Available@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Add-Available@2x" icon.</summary>
        public static UnityEditorIcon Add_Available2x => _Add_Available2x;


        private static readonly UnityEditorIcon _Custom = BuildIcon("Custom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Custom" icon.</summary>
        public static UnityEditorIcon Custom => _Custom;


        private static readonly UnityEditorIcon _Custom2x = BuildIcon("Custom@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Custom@2x" icon.</summary>
        public static UnityEditorIcon Custom2x => _Custom2x;


        private static readonly UnityEditorIcon _Download_Available = BuildIcon("Download-Available");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Download-Available" icon.</summary>
        public static UnityEditorIcon Download_Available => _Download_Available;


        private static readonly UnityEditorIcon _Download_Available2x = BuildIcon("Download-Available@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Download-Available@2x" icon.</summary>
        public static UnityEditorIcon Download_Available2x => _Download_Available2x;


        private static readonly UnityEditorIcon _Error = BuildIcon("Error");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Error" icon.</summary>
        public static UnityEditorIcon Error => _Error;


        private static readonly UnityEditorIcon _Error2x = BuildIcon("Error@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Error@2x" icon.</summary>
        public static UnityEditorIcon Error2x => _Error2x;


        private static readonly UnityEditorIcon _Import_Available = BuildIcon("Import-Available");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Import-Available" icon.</summary>
        public static UnityEditorIcon Import_Available => _Import_Available;


        private static readonly UnityEditorIcon _Import_Available2x = BuildIcon("Import-Available@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Import-Available@2x" icon.</summary>
        public static UnityEditorIcon Import_Available2x => _Import_Available2x;


        private static readonly UnityEditorIcon _Installed = BuildIcon("Installed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Installed" icon.</summary>
        public static UnityEditorIcon Installed => _Installed;


        private static readonly UnityEditorIcon _Installed2x = BuildIcon("Installed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Installed@2x" icon.</summary>
        public static UnityEditorIcon Installed2x => _Installed2x;


        private static readonly UnityEditorIcon _Loading = BuildIcon("Loading");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Loading" icon.</summary>
        public static UnityEditorIcon Loading => _Loading;


        private static readonly UnityEditorIcon _Loading2x = BuildIcon("Loading@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Loading@2x" icon.</summary>
        public static UnityEditorIcon Loading2x => _Loading2x;


        private static readonly UnityEditorIcon _Refresh = BuildIcon("Refresh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Refresh" icon.</summary>
        public static UnityEditorIcon Refresh => _Refresh;


        private static readonly UnityEditorIcon _Refresh2x = BuildIcon("Refresh@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Refresh@2x" icon.</summary>
        public static UnityEditorIcon Refresh2x => _Refresh2x;


        private static readonly UnityEditorIcon _Update_Available = BuildIcon("Update-Available");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Update-Available" icon.</summary>
        public static UnityEditorIcon Update_Available => _Update_Available;


        private static readonly UnityEditorIcon _Update_Available2x = BuildIcon("Update-Available@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Update-Available@2x" icon.</summary>
        public static UnityEditorIcon Update_Available2x => _Update_Available2x;


        private static readonly UnityEditorIcon _Warning = BuildIcon("Warning");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Warning" icon.</summary>
        public static UnityEditorIcon Warning => _Warning;


        private static readonly UnityEditorIcon _Warning2x = BuildIcon("Warning@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Warning@2x" icon.</summary>
        public static UnityEditorIcon Warning2x => _Warning2x;


        private static readonly UnityEditorIcon _Particle_Effect = BuildIcon("Particle Effect");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Particle Effect" icon.</summary>
        public static UnityEditorIcon Particle_Effect => _Particle_Effect;


        private static readonly UnityEditorIcon _ParticleShapeTool_On = BuildIcon("ParticleShapeTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool On" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool_On => _ParticleShapeTool_On;


        private static readonly UnityEditorIcon _ParticleShapeTool_On2x = BuildIcon("ParticleShapeTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool On@2x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool_On2x => _ParticleShapeTool_On2x;


        private static readonly UnityEditorIcon _ParticleShapeTool_On3x = BuildIcon("ParticleShapeTool On@3x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool On@3x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool_On3x => _ParticleShapeTool_On3x;


        private static readonly UnityEditorIcon _ParticleShapeTool_On4x = BuildIcon("ParticleShapeTool On@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool On@4x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool_On4x => _ParticleShapeTool_On4x;


        private static readonly UnityEditorIcon _ParticleShapeTool = BuildIcon("ParticleShapeTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool => _ParticleShapeTool;


        private static readonly UnityEditorIcon _ParticleShapeTool2x = BuildIcon("ParticleShapeTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool@2x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool2x => _ParticleShapeTool2x;


        private static readonly UnityEditorIcon _ParticleShapeTool3x = BuildIcon("ParticleShapeTool@3x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool@3x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool3x => _ParticleShapeTool3x;


        private static readonly UnityEditorIcon _ParticleShapeTool4x = BuildIcon("ParticleShapeTool@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleShapeTool@4x" icon.</summary>
        public static UnityEditorIcon ParticleShapeTool4x => _ParticleShapeTool4x;


        private static readonly UnityEditorIcon _PauseButton_On = BuildIcon("PauseButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PauseButton On" icon.</summary>
        public static UnityEditorIcon PauseButton_On => _PauseButton_On;


        private static readonly UnityEditorIcon _PauseButton_On2x = BuildIcon("PauseButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PauseButton On@2x" icon.</summary>
        public static UnityEditorIcon PauseButton_On2x => _PauseButton_On2x;


        private static readonly UnityEditorIcon _PauseButton = BuildIcon("PauseButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PauseButton" icon.</summary>
        public static UnityEditorIcon PauseButton => _PauseButton;


        private static readonly UnityEditorIcon _PauseButton2x = BuildIcon("PauseButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PauseButton@2x" icon.</summary>
        public static UnityEditorIcon PauseButton2x => _PauseButton2x;


        private static readonly UnityEditorIcon _PlayButton_On = BuildIcon("PlayButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButton On" icon.</summary>
        public static UnityEditorIcon PlayButton_On => _PlayButton_On;


        private static readonly UnityEditorIcon _PlayButton_On2x = BuildIcon("PlayButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButton On@2x" icon.</summary>
        public static UnityEditorIcon PlayButton_On2x => _PlayButton_On2x;


        private static readonly UnityEditorIcon _PlayButton = BuildIcon("PlayButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButton" icon.</summary>
        public static UnityEditorIcon PlayButton => _PlayButton;


        private static readonly UnityEditorIcon _PlayButton2x = BuildIcon("PlayButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButton@2x" icon.</summary>
        public static UnityEditorIcon PlayButton2x => _PlayButton2x;


        private static readonly UnityEditorIcon _PlayButtonProfile_On = BuildIcon("PlayButtonProfile On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButtonProfile On" icon.</summary>
        public static UnityEditorIcon PlayButtonProfile_On => _PlayButtonProfile_On;


        private static readonly UnityEditorIcon _PlayButtonProfile = BuildIcon("PlayButtonProfile");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayButtonProfile" icon.</summary>
        public static UnityEditorIcon PlayButtonProfile => _PlayButtonProfile;


        private static readonly UnityEditorIcon _playLoopOff = BuildIcon("playLoopOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "playLoopOff" icon.</summary>
        public static UnityEditorIcon playLoopOff => _playLoopOff;


        private static readonly UnityEditorIcon _playLoopOn = BuildIcon("playLoopOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "playLoopOn" icon.</summary>
        public static UnityEditorIcon playLoopOn => _playLoopOn;


        private static readonly UnityEditorIcon _playSpeed = BuildIcon("playSpeed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "playSpeed" icon.</summary>
        public static UnityEditorIcon playSpeed => _playSpeed;


        private static readonly UnityEditorIcon _preAudioAutoPlayOff = BuildIcon("preAudioAutoPlayOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioAutoPlayOff" icon.</summary>
        public static UnityEditorIcon preAudioAutoPlayOff => _preAudioAutoPlayOff;


        private static readonly UnityEditorIcon _preAudioAutoPlayOff2x = BuildIcon("preAudioAutoPlayOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioAutoPlayOff@2x" icon.</summary>
        public static UnityEditorIcon preAudioAutoPlayOff2x => _preAudioAutoPlayOff2x;


        private static readonly UnityEditorIcon _preAudioAutoPlayOn = BuildIcon("preAudioAutoPlayOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioAutoPlayOn" icon.</summary>
        public static UnityEditorIcon preAudioAutoPlayOn => _preAudioAutoPlayOn;


        private static readonly UnityEditorIcon _preAudioLoopOff = BuildIcon("preAudioLoopOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioLoopOff" icon.</summary>
        public static UnityEditorIcon preAudioLoopOff => _preAudioLoopOff;


        private static readonly UnityEditorIcon _preAudioLoopOff2x = BuildIcon("preAudioLoopOff@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioLoopOff@2x" icon.</summary>
        public static UnityEditorIcon preAudioLoopOff2x => _preAudioLoopOff2x;


        private static readonly UnityEditorIcon _preAudioLoopOn = BuildIcon("preAudioLoopOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioLoopOn" icon.</summary>
        public static UnityEditorIcon preAudioLoopOn => _preAudioLoopOn;


        private static readonly UnityEditorIcon _preAudioPlayOff = BuildIcon("preAudioPlayOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioPlayOff" icon.</summary>
        public static UnityEditorIcon preAudioPlayOff => _preAudioPlayOff;


        private static readonly UnityEditorIcon _preAudioPlayOn = BuildIcon("preAudioPlayOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "preAudioPlayOn" icon.</summary>
        public static UnityEditorIcon preAudioPlayOn => _preAudioPlayOn;


        private static readonly UnityEditorIcon _PreMatCube = BuildIcon("PreMatCube");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatCube" icon.</summary>
        public static UnityEditorIcon PreMatCube => _PreMatCube;


        private static readonly UnityEditorIcon _PreMatCube2x = BuildIcon("PreMatCube@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatCube@2x" icon.</summary>
        public static UnityEditorIcon PreMatCube2x => _PreMatCube2x;


        private static readonly UnityEditorIcon _PreMatCylinder = BuildIcon("PreMatCylinder");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatCylinder" icon.</summary>
        public static UnityEditorIcon PreMatCylinder => _PreMatCylinder;


        private static readonly UnityEditorIcon _PreMatCylinder2x = BuildIcon("PreMatCylinder@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatCylinder@2x" icon.</summary>
        public static UnityEditorIcon PreMatCylinder2x => _PreMatCylinder2x;


        private static readonly UnityEditorIcon _PreMatLight0 = BuildIcon("PreMatLight0");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatLight0" icon.</summary>
        public static UnityEditorIcon PreMatLight0 => _PreMatLight0;


        private static readonly UnityEditorIcon _PreMatLight02x = BuildIcon("PreMatLight0@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatLight0@2x" icon.</summary>
        public static UnityEditorIcon PreMatLight02x => _PreMatLight02x;


        private static readonly UnityEditorIcon _PreMatLight1 = BuildIcon("PreMatLight1");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatLight1" icon.</summary>
        public static UnityEditorIcon PreMatLight1 => _PreMatLight1;


        private static readonly UnityEditorIcon _PreMatLight12x = BuildIcon("PreMatLight1@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatLight1@2x" icon.</summary>
        public static UnityEditorIcon PreMatLight12x => _PreMatLight12x;


        private static readonly UnityEditorIcon _PreMatQuad = BuildIcon("PreMatQuad");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatQuad" icon.</summary>
        public static UnityEditorIcon PreMatQuad => _PreMatQuad;


        private static readonly UnityEditorIcon _PreMatQuad2x = BuildIcon("PreMatQuad@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatQuad@2x" icon.</summary>
        public static UnityEditorIcon PreMatQuad2x => _PreMatQuad2x;


        private static readonly UnityEditorIcon _PreMatSphere = BuildIcon("PreMatSphere");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatSphere" icon.</summary>
        public static UnityEditorIcon PreMatSphere => _PreMatSphere;


        private static readonly UnityEditorIcon _PreMatSphere2x = BuildIcon("PreMatSphere@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatSphere@2x" icon.</summary>
        public static UnityEditorIcon PreMatSphere2x => _PreMatSphere2x;


        private static readonly UnityEditorIcon _PreMatTorus = BuildIcon("PreMatTorus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatTorus" icon.</summary>
        public static UnityEditorIcon PreMatTorus => _PreMatTorus;


        private static readonly UnityEditorIcon _PreMatTorus2x = BuildIcon("PreMatTorus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreMatTorus@2x" icon.</summary>
        public static UnityEditorIcon PreMatTorus2x => _PreMatTorus2x;


        private static readonly UnityEditorIcon _Preset_Context = BuildIcon("Preset.Context");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Preset.Context" icon.</summary>
        public static UnityEditorIcon Preset_Context => _Preset_Context;


        private static readonly UnityEditorIcon _Preset_Context2x = BuildIcon("Preset.Context@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Preset.Context@2x" icon.</summary>
        public static UnityEditorIcon Preset_Context2x => _Preset_Context2x;


        private static readonly UnityEditorIcon _PreTexA = BuildIcon("PreTexA");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexA" icon.</summary>
        public static UnityEditorIcon PreTexA => _PreTexA;


        private static readonly UnityEditorIcon _PreTexA2x = BuildIcon("PreTexA@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexA@2x" icon.</summary>
        public static UnityEditorIcon PreTexA2x => _PreTexA2x;


        private static readonly UnityEditorIcon _PreTexB = BuildIcon("PreTexB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexB" icon.</summary>
        public static UnityEditorIcon PreTexB => _PreTexB;


        private static readonly UnityEditorIcon _PreTexB2x = BuildIcon("PreTexB@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexB@2x" icon.</summary>
        public static UnityEditorIcon PreTexB2x => _PreTexB2x;


        private static readonly UnityEditorIcon _PreTexG = BuildIcon("PreTexG");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexG" icon.</summary>
        public static UnityEditorIcon PreTexG => _PreTexG;


        private static readonly UnityEditorIcon _PreTexG2x = BuildIcon("PreTexG@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexG@2x" icon.</summary>
        public static UnityEditorIcon PreTexG2x => _PreTexG2x;


        private static readonly UnityEditorIcon _PreTexR = BuildIcon("PreTexR");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexR" icon.</summary>
        public static UnityEditorIcon PreTexR => _PreTexR;


        private static readonly UnityEditorIcon _PreTexR2x = BuildIcon("PreTexR@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexR@2x" icon.</summary>
        public static UnityEditorIcon PreTexR2x => _PreTexR2x;


        private static readonly UnityEditorIcon _PreTexRGB = BuildIcon("PreTexRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexRGB" icon.</summary>
        public static UnityEditorIcon PreTexRGB => _PreTexRGB;


        private static readonly UnityEditorIcon _PreTexRGB2x = BuildIcon("PreTexRGB@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTexRGB@2x" icon.</summary>
        public static UnityEditorIcon PreTexRGB2x => _PreTexRGB2x;


        private static readonly UnityEditorIcon _PreTextureAlpha = BuildIcon("PreTextureAlpha");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureAlpha" icon.</summary>
        public static UnityEditorIcon PreTextureAlpha => _PreTextureAlpha;


        private static readonly UnityEditorIcon _PreTextureArrayFirstSlice = BuildIcon("PreTextureArrayFirstSlice");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureArrayFirstSlice" icon.</summary>
        public static UnityEditorIcon PreTextureArrayFirstSlice => _PreTextureArrayFirstSlice;


        private static readonly UnityEditorIcon _PreTextureArrayLastSlice = BuildIcon("PreTextureArrayLastSlice");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureArrayLastSlice" icon.</summary>
        public static UnityEditorIcon PreTextureArrayLastSlice => _PreTextureArrayLastSlice;


        private static readonly UnityEditorIcon _PreTextureMipMapHigh = BuildIcon("PreTextureMipMapHigh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureMipMapHigh" icon.</summary>
        public static UnityEditorIcon PreTextureMipMapHigh => _PreTextureMipMapHigh;


        private static readonly UnityEditorIcon _PreTextureMipMapLow = BuildIcon("PreTextureMipMapLow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureMipMapLow" icon.</summary>
        public static UnityEditorIcon PreTextureMipMapLow => _PreTextureMipMapLow;


        private static readonly UnityEditorIcon _PreTextureRGB = BuildIcon("PreTextureRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreTextureRGB" icon.</summary>
        public static UnityEditorIcon PreTextureRGB => _PreTextureRGB;


        private static readonly UnityEditorIcon _PreviewPackageInUse = BuildIcon("PreviewPackageInUse");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreviewPackageInUse" icon.</summary>
        public static UnityEditorIcon PreviewPackageInUse => _PreviewPackageInUse;


        private static readonly UnityEditorIcon _PreviewPackageInUse2x = BuildIcon("PreviewPackageInUse@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PreviewPackageInUse@2x" icon.</summary>
        public static UnityEditorIcon PreviewPackageInUse2x => _PreviewPackageInUse2x;


        private static readonly UnityEditorIcon _AreaLight_Gizmo = BuildIcon("AreaLight Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AreaLight Gizmo" icon.</summary>
        public static UnityEditorIcon AreaLight_Gizmo => _AreaLight_Gizmo;


        private static readonly UnityEditorIcon _AreaLight_Icon = BuildIcon("AreaLight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AreaLight Icon" icon.</summary>
        public static UnityEditorIcon AreaLight_Icon => _AreaLight_Icon;


        private static readonly UnityEditorIcon _Assembly_Icon = BuildIcon("Assembly Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Assembly Icon" icon.</summary>
        public static UnityEditorIcon Assembly_Icon => _Assembly_Icon;


        private static readonly UnityEditorIcon _AssetStore_Icon = BuildIcon("AssetStore Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AssetStore Icon" icon.</summary>
        public static UnityEditorIcon AssetStore_Icon => _AssetStore_Icon;


        private static readonly UnityEditorIcon _AudioMixerView_Icon = BuildIcon("AudioMixerView Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioMixerView Icon" icon.</summary>
        public static UnityEditorIcon AudioMixerView_Icon => _AudioMixerView_Icon;


        private static readonly UnityEditorIcon _AudioSource_Gizmo = BuildIcon("AudioSource Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioSource Gizmo" icon.</summary>
        public static UnityEditorIcon AudioSource_Gizmo => _AudioSource_Gizmo;


        private static readonly UnityEditorIcon _boo_Script_Icon = BuildIcon("boo Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "boo Script Icon" icon.</summary>
        public static UnityEditorIcon boo_Script_Icon => _boo_Script_Icon;


        private static readonly UnityEditorIcon _Camera_Gizmo = BuildIcon("Camera Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Camera Gizmo" icon.</summary>
        public static UnityEditorIcon Camera_Gizmo => _Camera_Gizmo;


        private static readonly UnityEditorIcon _CGProgram_Icon = BuildIcon("CGProgram Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CGProgram Icon" icon.</summary>
        public static UnityEditorIcon CGProgram_Icon => _CGProgram_Icon;


        private static readonly UnityEditorIcon _ChorusFilter_Icon = BuildIcon("ChorusFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ChorusFilter Icon" icon.</summary>
        public static UnityEditorIcon ChorusFilter_Icon => _ChorusFilter_Icon;


        private static readonly UnityEditorIcon _CollabChanges_Icon = BuildIcon("CollabChanges Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabChanges Icon" icon.</summary>
        public static UnityEditorIcon CollabChanges_Icon => _CollabChanges_Icon;


        private static readonly UnityEditorIcon _CollabChangesConflict_Icon = BuildIcon("CollabChangesConflict Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabChangesConflict Icon" icon.</summary>
        public static UnityEditorIcon CollabChangesConflict_Icon => _CollabChangesConflict_Icon;


        private static readonly UnityEditorIcon _CollabChangesDeleted_Icon = BuildIcon("CollabChangesDeleted Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabChangesDeleted Icon" icon.</summary>
        public static UnityEditorIcon CollabChangesDeleted_Icon => _CollabChangesDeleted_Icon;


        private static readonly UnityEditorIcon _CollabConflict_Icon = BuildIcon("CollabConflict Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabConflict Icon" icon.</summary>
        public static UnityEditorIcon CollabConflict_Icon => _CollabConflict_Icon;


        private static readonly UnityEditorIcon _CollabCreate_Icon = BuildIcon("CollabCreate Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabCreate Icon" icon.</summary>
        public static UnityEditorIcon CollabCreate_Icon => _CollabCreate_Icon;


        private static readonly UnityEditorIcon _CollabDeleted_Icon = BuildIcon("CollabDeleted Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabDeleted Icon" icon.</summary>
        public static UnityEditorIcon CollabDeleted_Icon => _CollabDeleted_Icon;


        private static readonly UnityEditorIcon _CollabEdit_Icon = BuildIcon("CollabEdit Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabEdit Icon" icon.</summary>
        public static UnityEditorIcon CollabEdit_Icon => _CollabEdit_Icon;


        private static readonly UnityEditorIcon _CollabExclude_Icon = BuildIcon("CollabExclude Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabExclude Icon" icon.</summary>
        public static UnityEditorIcon CollabExclude_Icon => _CollabExclude_Icon;


        private static readonly UnityEditorIcon _CollabMoved_Icon = BuildIcon("CollabMoved Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CollabMoved Icon" icon.</summary>
        public static UnityEditorIcon CollabMoved_Icon => _CollabMoved_Icon;


        private static readonly UnityEditorIcon _cs_Script_Icon = BuildIcon("cs Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "cs Script Icon" icon.</summary>
        public static UnityEditorIcon cs_Script_Icon => _cs_Script_Icon;


        private static readonly UnityEditorIcon _d_AreaLight_Icon = BuildIcon("d_AreaLight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AreaLight Icon" icon.</summary>
        public static UnityEditorIcon d_AreaLight_Icon => _d_AreaLight_Icon;


        private static readonly UnityEditorIcon _d_Assembly_Icon = BuildIcon("d_Assembly Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Assembly Icon" icon.</summary>
        public static UnityEditorIcon d_Assembly_Icon => _d_Assembly_Icon;


        private static readonly UnityEditorIcon _d_AssetStore_Icon = BuildIcon("d_AssetStore Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AssetStore Icon" icon.</summary>
        public static UnityEditorIcon d_AssetStore_Icon => _d_AssetStore_Icon;


        private static readonly UnityEditorIcon _d_AudioMixerView_Icon = BuildIcon("d_AudioMixerView Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioMixerView Icon" icon.</summary>
        public static UnityEditorIcon d_AudioMixerView_Icon => _d_AudioMixerView_Icon;


        private static readonly UnityEditorIcon _d_boo_Script_Icon = BuildIcon("d_boo Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_boo Script Icon" icon.</summary>
        public static UnityEditorIcon d_boo_Script_Icon => _d_boo_Script_Icon;


        private static readonly UnityEditorIcon _d_CGProgram_Icon = BuildIcon("d_CGProgram Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CGProgram Icon" icon.</summary>
        public static UnityEditorIcon d_CGProgram_Icon => _d_CGProgram_Icon;


        private static readonly UnityEditorIcon _d_CollabChanges_Icon = BuildIcon("d_CollabChanges Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabChanges Icon" icon.</summary>
        public static UnityEditorIcon d_CollabChanges_Icon => _d_CollabChanges_Icon;


        private static readonly UnityEditorIcon _d_CollabChangesConflict_Icon = BuildIcon("d_CollabChangesConflict Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabChangesConflict Icon" icon.</summary>
        public static UnityEditorIcon d_CollabChangesConflict_Icon => _d_CollabChangesConflict_Icon;


        private static readonly UnityEditorIcon _d_CollabChangesDeleted_Icon = BuildIcon("d_CollabChangesDeleted Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabChangesDeleted Icon" icon.</summary>
        public static UnityEditorIcon d_CollabChangesDeleted_Icon => _d_CollabChangesDeleted_Icon;


        private static readonly UnityEditorIcon _d_CollabConflict_Icon = BuildIcon("d_CollabConflict Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabConflict Icon" icon.</summary>
        public static UnityEditorIcon d_CollabConflict_Icon => _d_CollabConflict_Icon;


        private static readonly UnityEditorIcon _d_CollabCreate_Icon = BuildIcon("d_CollabCreate Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabCreate Icon" icon.</summary>
        public static UnityEditorIcon d_CollabCreate_Icon => _d_CollabCreate_Icon;


        private static readonly UnityEditorIcon _d_CollabDeleted_Icon = BuildIcon("d_CollabDeleted Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabDeleted Icon" icon.</summary>
        public static UnityEditorIcon d_CollabDeleted_Icon => _d_CollabDeleted_Icon;


        private static readonly UnityEditorIcon _d_CollabEdit_Icon = BuildIcon("d_CollabEdit Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabEdit Icon" icon.</summary>
        public static UnityEditorIcon d_CollabEdit_Icon => _d_CollabEdit_Icon;


        private static readonly UnityEditorIcon _d_CollabExclude_Icon = BuildIcon("d_CollabExclude Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabExclude Icon" icon.</summary>
        public static UnityEditorIcon d_CollabExclude_Icon => _d_CollabExclude_Icon;


        private static readonly UnityEditorIcon _d_CollabMoved_Icon = BuildIcon("d_CollabMoved Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CollabMoved Icon" icon.</summary>
        public static UnityEditorIcon d_CollabMoved_Icon => _d_CollabMoved_Icon;


        private static readonly UnityEditorIcon _d_cs_Script_Icon = BuildIcon("d_cs Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_cs Script Icon" icon.</summary>
        public static UnityEditorIcon d_cs_Script_Icon => _d_cs_Script_Icon;


        private static readonly UnityEditorIcon _d_DirectionalLight_Icon = BuildIcon("d_DirectionalLight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DirectionalLight Icon" icon.</summary>
        public static UnityEditorIcon d_DirectionalLight_Icon => _d_DirectionalLight_Icon;


        private static readonly UnityEditorIcon _d_Favorite_Icon = BuildIcon("d_Favorite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Favorite Icon" icon.</summary>
        public static UnityEditorIcon d_Favorite_Icon => _d_Favorite_Icon;


        private static readonly UnityEditorIcon _d_Favorite_On_Icon = BuildIcon("d_Favorite On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Favorite On Icon" icon.</summary>
        public static UnityEditorIcon d_Favorite_On_Icon => _d_Favorite_On_Icon;


        private static readonly UnityEditorIcon _d_Folder_Icon = BuildIcon("d_Folder Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Folder Icon" icon.</summary>
        public static UnityEditorIcon d_Folder_Icon => _d_Folder_Icon;


        private static readonly UnityEditorIcon _d_FolderEmpty_Icon = BuildIcon("d_FolderEmpty Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FolderEmpty Icon" icon.</summary>
        public static UnityEditorIcon d_FolderEmpty_Icon => _d_FolderEmpty_Icon;


        private static readonly UnityEditorIcon _d_FolderEmpty_On_Icon = BuildIcon("d_FolderEmpty On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FolderEmpty On Icon" icon.</summary>
        public static UnityEditorIcon d_FolderEmpty_On_Icon => _d_FolderEmpty_On_Icon;


        private static readonly UnityEditorIcon _d_FolderFavorite_Icon = BuildIcon("d_FolderFavorite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FolderFavorite Icon" icon.</summary>
        public static UnityEditorIcon d_FolderFavorite_Icon => _d_FolderFavorite_Icon;


        private static readonly UnityEditorIcon _d_FolderFavorite_On_Icon = BuildIcon("d_FolderFavorite On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FolderFavorite On Icon" icon.</summary>
        public static UnityEditorIcon d_FolderFavorite_On_Icon => _d_FolderFavorite_On_Icon;


        private static readonly UnityEditorIcon _d_FolderOpened_Icon = BuildIcon("d_FolderOpened Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FolderOpened Icon" icon.</summary>
        public static UnityEditorIcon d_FolderOpened_Icon => _d_FolderOpened_Icon;


        private static readonly UnityEditorIcon _d_GridLayoutGroup_Icon = BuildIcon("d_GridLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon d_GridLayoutGroup_Icon => _d_GridLayoutGroup_Icon;


        private static readonly UnityEditorIcon _d_HorizontalLayoutGroup_Icon = BuildIcon("d_HorizontalLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_HorizontalLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon d_HorizontalLayoutGroup_Icon => _d_HorizontalLayoutGroup_Icon;


        private static readonly UnityEditorIcon _d_Js_Script_Icon = BuildIcon("d_Js Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Js Script Icon" icon.</summary>
        public static UnityEditorIcon d_Js_Script_Icon => _d_Js_Script_Icon;


        private static readonly UnityEditorIcon _d_LightingDataAssetParent_Icon = BuildIcon("d_LightingDataAssetParent Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightingDataAssetParent Icon" icon.</summary>
        public static UnityEditorIcon d_LightingDataAssetParent_Icon => _d_LightingDataAssetParent_Icon;


        private static readonly UnityEditorIcon _d_Microphone_Icon = BuildIcon("d_Microphone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Microphone Icon" icon.</summary>
        public static UnityEditorIcon d_Microphone_Icon => _d_Microphone_Icon;


        private static readonly UnityEditorIcon _d_Prefab_Icon = BuildIcon("d_Prefab Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Prefab Icon" icon.</summary>
        public static UnityEditorIcon d_Prefab_Icon => _d_Prefab_Icon;


        private static readonly UnityEditorIcon _d_Prefab_On_Icon = BuildIcon("d_Prefab On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Prefab On Icon" icon.</summary>
        public static UnityEditorIcon d_Prefab_On_Icon => _d_Prefab_On_Icon;


        private static readonly UnityEditorIcon _d_PrefabModel_Icon = BuildIcon("d_PrefabModel Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PrefabModel Icon" icon.</summary>
        public static UnityEditorIcon d_PrefabModel_Icon => _d_PrefabModel_Icon;


        private static readonly UnityEditorIcon _d_PrefabModel_On_Icon = BuildIcon("d_PrefabModel On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PrefabModel On Icon" icon.</summary>
        public static UnityEditorIcon d_PrefabModel_On_Icon => _d_PrefabModel_On_Icon;


        private static readonly UnityEditorIcon _d_PrefabVariant_Icon = BuildIcon("d_PrefabVariant Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PrefabVariant Icon" icon.</summary>
        public static UnityEditorIcon d_PrefabVariant_Icon => _d_PrefabVariant_Icon;


        private static readonly UnityEditorIcon _d_PrefabVariant_On_Icon = BuildIcon("d_PrefabVariant On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PrefabVariant On Icon" icon.</summary>
        public static UnityEditorIcon d_PrefabVariant_On_Icon => _d_PrefabVariant_On_Icon;


        private static readonly UnityEditorIcon _d_RaycastCollider_Icon = BuildIcon("d_RaycastCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RaycastCollider Icon" icon.</summary>
        public static UnityEditorIcon d_RaycastCollider_Icon => _d_RaycastCollider_Icon;


        private static readonly UnityEditorIcon _d_Search_Icon = BuildIcon("d_Search Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Search Icon" icon.</summary>
        public static UnityEditorIcon d_Search_Icon => _d_Search_Icon;


        private static readonly UnityEditorIcon _d_Spotlight_Icon = BuildIcon("d_Spotlight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Spotlight Icon" icon.</summary>
        public static UnityEditorIcon d_Spotlight_Icon => _d_Spotlight_Icon;


        private static readonly UnityEditorIcon _d_VerticalLayoutGroup_Icon = BuildIcon("d_VerticalLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VerticalLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon d_VerticalLayoutGroup_Icon => _d_VerticalLayoutGroup_Icon;


        private static readonly UnityEditorIcon _DefaultSlate_Icon = BuildIcon("DefaultSlate Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DefaultSlate Icon" icon.</summary>
        public static UnityEditorIcon DefaultSlate_Icon => _DefaultSlate_Icon;


        private static readonly UnityEditorIcon _DirectionalLight_Gizmo = BuildIcon("DirectionalLight Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DirectionalLight Gizmo" icon.</summary>
        public static UnityEditorIcon DirectionalLight_Gizmo => _DirectionalLight_Gizmo;


        private static readonly UnityEditorIcon _DirectionalLight_Icon = BuildIcon("DirectionalLight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DirectionalLight Icon" icon.</summary>
        public static UnityEditorIcon DirectionalLight_Icon => _DirectionalLight_Icon;


        private static readonly UnityEditorIcon _DiscLight_Icon = BuildIcon("DiscLight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DiscLight Icon" icon.</summary>
        public static UnityEditorIcon DiscLight_Icon => _DiscLight_Icon;


        private static readonly UnityEditorIcon _dll_Script_Icon = BuildIcon("dll Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "dll Script Icon" icon.</summary>
        public static UnityEditorIcon dll_Script_Icon => _dll_Script_Icon;


        private static readonly UnityEditorIcon _EchoFilter_Icon = BuildIcon("EchoFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EchoFilter Icon" icon.</summary>
        public static UnityEditorIcon EchoFilter_Icon => _EchoFilter_Icon;


        private static readonly UnityEditorIcon _Favorite_Icon = BuildIcon("Favorite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Favorite Icon" icon.</summary>
        public static UnityEditorIcon Favorite_Icon => _Favorite_Icon;


        private static readonly UnityEditorIcon _Favorite_On_Icon = BuildIcon("Favorite On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Favorite On Icon" icon.</summary>
        public static UnityEditorIcon Favorite_On_Icon => _Favorite_On_Icon;


        private static readonly UnityEditorIcon _Folder_Icon = BuildIcon("Folder Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Folder Icon" icon.</summary>
        public static UnityEditorIcon Folder_Icon => _Folder_Icon;


        private static readonly UnityEditorIcon _Folder_On_Icon = BuildIcon("Folder On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Folder On Icon" icon.</summary>
        public static UnityEditorIcon Folder_On_Icon => _Folder_On_Icon;


        private static readonly UnityEditorIcon _FolderEmpty_Icon = BuildIcon("FolderEmpty Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderEmpty Icon" icon.</summary>
        public static UnityEditorIcon FolderEmpty_Icon => _FolderEmpty_Icon;


        private static readonly UnityEditorIcon _FolderEmpty_On_Icon = BuildIcon("FolderEmpty On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderEmpty On Icon" icon.</summary>
        public static UnityEditorIcon FolderEmpty_On_Icon => _FolderEmpty_On_Icon;


        private static readonly UnityEditorIcon _FolderFavorite_Icon = BuildIcon("FolderFavorite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderFavorite Icon" icon.</summary>
        public static UnityEditorIcon FolderFavorite_Icon => _FolderFavorite_Icon;


        private static readonly UnityEditorIcon _FolderFavorite_On_Icon = BuildIcon("FolderFavorite On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderFavorite On Icon" icon.</summary>
        public static UnityEditorIcon FolderFavorite_On_Icon => _FolderFavorite_On_Icon;


        private static readonly UnityEditorIcon _FolderOpened_Icon = BuildIcon("FolderOpened Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderOpened Icon" icon.</summary>
        public static UnityEditorIcon FolderOpened_Icon => _FolderOpened_Icon;


        private static readonly UnityEditorIcon _FolderOpened_On_Icon = BuildIcon("FolderOpened On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FolderOpened On Icon" icon.</summary>
        public static UnityEditorIcon FolderOpened_On_Icon => _FolderOpened_On_Icon;


        private static readonly UnityEditorIcon _GameManager_Icon = BuildIcon("GameManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GameManager Icon" icon.</summary>
        public static UnityEditorIcon GameManager_Icon => _GameManager_Icon;


        private static readonly UnityEditorIcon _GridBrush_Icon = BuildIcon("GridBrush Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridBrush Icon" icon.</summary>
        public static UnityEditorIcon GridBrush_Icon => _GridBrush_Icon;


        private static readonly UnityEditorIcon _HighPassFilter_Icon = BuildIcon("HighPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HighPassFilter Icon" icon.</summary>
        public static UnityEditorIcon HighPassFilter_Icon => _HighPassFilter_Icon;


        private static readonly UnityEditorIcon _HorizontalLayoutGroup_Icon = BuildIcon("HorizontalLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HorizontalLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon HorizontalLayoutGroup_Icon => _HorizontalLayoutGroup_Icon;


        private static readonly UnityEditorIcon _Js_Script_Icon = BuildIcon("Js Script Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Js Script Icon" icon.</summary>
        public static UnityEditorIcon Js_Script_Icon => _Js_Script_Icon;


        private static readonly UnityEditorIcon _LensFlare_Gizmo = BuildIcon("LensFlare Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LensFlare Gizmo" icon.</summary>
        public static UnityEditorIcon LensFlare_Gizmo => _LensFlare_Gizmo;


        private static readonly UnityEditorIcon _LightingDataAssetParent_Icon = BuildIcon("LightingDataAssetParent Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightingDataAssetParent Icon" icon.</summary>
        public static UnityEditorIcon LightingDataAssetParent_Icon => _LightingDataAssetParent_Icon;


        private static readonly UnityEditorIcon _LightProbeGroup_Gizmo = BuildIcon("LightProbeGroup Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightProbeGroup Gizmo" icon.</summary>
        public static UnityEditorIcon LightProbeGroup_Gizmo => _LightProbeGroup_Gizmo;


        private static readonly UnityEditorIcon _LightProbeProxyVolume_Gizmo = BuildIcon("LightProbeProxyVolume Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightProbeProxyVolume Gizmo" icon.</summary>
        public static UnityEditorIcon LightProbeProxyVolume_Gizmo => _LightProbeProxyVolume_Gizmo;


        private static readonly UnityEditorIcon _LowPassFilter_Icon = BuildIcon("LowPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LowPassFilter Icon" icon.</summary>
        public static UnityEditorIcon LowPassFilter_Icon => _LowPassFilter_Icon;


        private static readonly UnityEditorIcon _Main_Light_Gizmo = BuildIcon("Main Light Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Main Light Gizmo" icon.</summary>
        public static UnityEditorIcon Main_Light_Gizmo => _Main_Light_Gizmo;


        private static readonly UnityEditorIcon _MetaFile_Icon = BuildIcon("MetaFile Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MetaFile Icon" icon.</summary>
        public static UnityEditorIcon MetaFile_Icon => _MetaFile_Icon;


        private static readonly UnityEditorIcon _Microphone_Icon = BuildIcon("Microphone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Microphone Icon" icon.</summary>
        public static UnityEditorIcon Microphone_Icon => _Microphone_Icon;


        private static readonly UnityEditorIcon _MuscleClip_Icon = BuildIcon("MuscleClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MuscleClip Icon" icon.</summary>
        public static UnityEditorIcon MuscleClip_Icon => _MuscleClip_Icon;


        private static readonly UnityEditorIcon _ParticleSystem_Gizmo = BuildIcon("ParticleSystem Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleSystem Gizmo" icon.</summary>
        public static UnityEditorIcon ParticleSystem_Gizmo => _ParticleSystem_Gizmo;


        private static readonly UnityEditorIcon _ParticleSystemForceField_Gizmo = BuildIcon("ParticleSystemForceField Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleSystemForceField Gizmo" icon.</summary>
        public static UnityEditorIcon ParticleSystemForceField_Gizmo => _ParticleSystemForceField_Gizmo;


        private static readonly UnityEditorIcon _PointLight_Gizmo = BuildIcon("PointLight Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PointLight Gizmo" icon.</summary>
        public static UnityEditorIcon PointLight_Gizmo => _PointLight_Gizmo;


        private static readonly UnityEditorIcon _Prefab_Icon = BuildIcon("Prefab Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Prefab Icon" icon.</summary>
        public static UnityEditorIcon Prefab_Icon => _Prefab_Icon;


        private static readonly UnityEditorIcon _Prefab_On_Icon = BuildIcon("Prefab On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Prefab On Icon" icon.</summary>
        public static UnityEditorIcon Prefab_On_Icon => _Prefab_On_Icon;


        private static readonly UnityEditorIcon _PrefabModel_Icon = BuildIcon("PrefabModel Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabModel Icon" icon.</summary>
        public static UnityEditorIcon PrefabModel_Icon => _PrefabModel_Icon;


        private static readonly UnityEditorIcon _PrefabModel_On_Icon = BuildIcon("PrefabModel On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabModel On Icon" icon.</summary>
        public static UnityEditorIcon PrefabModel_On_Icon => _PrefabModel_On_Icon;


        private static readonly UnityEditorIcon _PrefabOverlayAdded_Icon = BuildIcon("PrefabOverlayAdded Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabOverlayAdded Icon" icon.</summary>
        public static UnityEditorIcon PrefabOverlayAdded_Icon => _PrefabOverlayAdded_Icon;


        private static readonly UnityEditorIcon _PrefabOverlayModified_Icon = BuildIcon("PrefabOverlayModified Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabOverlayModified Icon" icon.</summary>
        public static UnityEditorIcon PrefabOverlayModified_Icon => _PrefabOverlayModified_Icon;


        private static readonly UnityEditorIcon _PrefabOverlayRemoved_Icon = BuildIcon("PrefabOverlayRemoved Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabOverlayRemoved Icon" icon.</summary>
        public static UnityEditorIcon PrefabOverlayRemoved_Icon => _PrefabOverlayRemoved_Icon;


        private static readonly UnityEditorIcon _PrefabVariant_Icon = BuildIcon("PrefabVariant Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabVariant Icon" icon.</summary>
        public static UnityEditorIcon PrefabVariant_Icon => _PrefabVariant_Icon;


        private static readonly UnityEditorIcon _PrefabVariant_On_Icon = BuildIcon("PrefabVariant On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PrefabVariant On Icon" icon.</summary>
        public static UnityEditorIcon PrefabVariant_On_Icon => _PrefabVariant_On_Icon;


        private static readonly UnityEditorIcon _Projector_Gizmo = BuildIcon("Projector Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Projector Gizmo" icon.</summary>
        public static UnityEditorIcon Projector_Gizmo => _Projector_Gizmo;


        private static readonly UnityEditorIcon _RaycastCollider_Icon = BuildIcon("RaycastCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RaycastCollider Icon" icon.</summary>
        public static UnityEditorIcon RaycastCollider_Icon => _RaycastCollider_Icon;


        private static readonly UnityEditorIcon _ReflectionProbe_Gizmo = BuildIcon("ReflectionProbe Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ReflectionProbe Gizmo" icon.</summary>
        public static UnityEditorIcon ReflectionProbe_Gizmo => _ReflectionProbe_Gizmo;


        private static readonly UnityEditorIcon _ReverbFilter_Icon = BuildIcon("ReverbFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ReverbFilter Icon" icon.</summary>
        public static UnityEditorIcon ReverbFilter_Icon => _ReverbFilter_Icon;


        private static readonly UnityEditorIcon _SceneSet_Icon = BuildIcon("SceneSet Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneSet Icon" icon.</summary>
        public static UnityEditorIcon SceneSet_Icon => _SceneSet_Icon;


        private static readonly UnityEditorIcon _Search_Icon = BuildIcon("Search Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Search Icon" icon.</summary>
        public static UnityEditorIcon Search_Icon => _Search_Icon;


        private static readonly UnityEditorIcon _Search_On_Icon = BuildIcon("Search On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Search On Icon" icon.</summary>
        public static UnityEditorIcon Search_On_Icon => _Search_On_Icon;


        private static readonly UnityEditorIcon _SoftlockProjectBrowser_Icon = BuildIcon("SoftlockProjectBrowser Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SoftlockProjectBrowser Icon" icon.</summary>
        public static UnityEditorIcon SoftlockProjectBrowser_Icon => _SoftlockProjectBrowser_Icon;


        private static readonly UnityEditorIcon _SpeedTreeModel_Icon = BuildIcon("SpeedTreeModel Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpeedTreeModel Icon" icon.</summary>
        public static UnityEditorIcon SpeedTreeModel_Icon => _SpeedTreeModel_Icon;


        private static readonly UnityEditorIcon _SpotLight_Gizmo = BuildIcon("SpotLight Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpotLight Gizmo" icon.</summary>
        public static UnityEditorIcon SpotLight_Gizmo => _SpotLight_Gizmo;


        private static readonly UnityEditorIcon _Spotlight_Icon = BuildIcon("Spotlight Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Spotlight Icon" icon.</summary>
        public static UnityEditorIcon Spotlight_Icon => _Spotlight_Icon;


        private static readonly UnityEditorIcon _SpriteCollider_Icon = BuildIcon("SpriteCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteCollider Icon" icon.</summary>
        public static UnityEditorIcon SpriteCollider_Icon => _SpriteCollider_Icon;


        private static readonly UnityEditorIcon _sv_icon_dot0_pix16_gizmo = BuildIcon("sv_icon_dot0_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot0_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot0_pix16_gizmo => _sv_icon_dot0_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot10_pix16_gizmo = BuildIcon("sv_icon_dot10_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot10_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot10_pix16_gizmo => _sv_icon_dot10_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot11_pix16_gizmo = BuildIcon("sv_icon_dot11_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot11_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot11_pix16_gizmo => _sv_icon_dot11_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot12_pix16_gizmo = BuildIcon("sv_icon_dot12_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot12_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot12_pix16_gizmo => _sv_icon_dot12_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot13_pix16_gizmo = BuildIcon("sv_icon_dot13_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot13_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot13_pix16_gizmo => _sv_icon_dot13_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot14_pix16_gizmo = BuildIcon("sv_icon_dot14_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot14_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot14_pix16_gizmo => _sv_icon_dot14_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot15_pix16_gizmo = BuildIcon("sv_icon_dot15_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot15_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot15_pix16_gizmo => _sv_icon_dot15_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot1_pix16_gizmo = BuildIcon("sv_icon_dot1_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot1_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot1_pix16_gizmo => _sv_icon_dot1_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot2_pix16_gizmo = BuildIcon("sv_icon_dot2_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot2_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot2_pix16_gizmo => _sv_icon_dot2_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot3_pix16_gizmo = BuildIcon("sv_icon_dot3_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot3_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot3_pix16_gizmo => _sv_icon_dot3_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot4_pix16_gizmo = BuildIcon("sv_icon_dot4_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot4_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot4_pix16_gizmo => _sv_icon_dot4_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot5_pix16_gizmo = BuildIcon("sv_icon_dot5_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot5_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot5_pix16_gizmo => _sv_icon_dot5_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot6_pix16_gizmo = BuildIcon("sv_icon_dot6_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot6_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot6_pix16_gizmo => _sv_icon_dot6_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot7_pix16_gizmo = BuildIcon("sv_icon_dot7_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot7_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot7_pix16_gizmo => _sv_icon_dot7_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot8_pix16_gizmo = BuildIcon("sv_icon_dot8_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot8_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot8_pix16_gizmo => _sv_icon_dot8_pix16_gizmo;


        private static readonly UnityEditorIcon _sv_icon_dot9_pix16_gizmo = BuildIcon("sv_icon_dot9_pix16_gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot9_pix16_gizmo" icon.</summary>
        public static UnityEditorIcon sv_icon_dot9_pix16_gizmo => _sv_icon_dot9_pix16_gizmo;


        private static readonly UnityEditorIcon _AnimatorController_Icon = BuildIcon("AnimatorController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorController Icon" icon.</summary>
        public static UnityEditorIcon AnimatorController_Icon => _AnimatorController_Icon;


        private static readonly UnityEditorIcon _AnimatorController_On_Icon = BuildIcon("AnimatorController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorController On Icon" icon.</summary>
        public static UnityEditorIcon AnimatorController_On_Icon => _AnimatorController_On_Icon;


        private static readonly UnityEditorIcon _AnimatorState_Icon = BuildIcon("AnimatorState Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorState Icon" icon.</summary>
        public static UnityEditorIcon AnimatorState_Icon => _AnimatorState_Icon;


        private static readonly UnityEditorIcon _AnimatorStateMachine_Icon = BuildIcon("AnimatorStateMachine Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorStateMachine Icon" icon.</summary>
        public static UnityEditorIcon AnimatorStateMachine_Icon => _AnimatorStateMachine_Icon;


        private static readonly UnityEditorIcon _AnimatorStateTransition_Icon = BuildIcon("AnimatorStateTransition Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorStateTransition Icon" icon.</summary>
        public static UnityEditorIcon AnimatorStateTransition_Icon => _AnimatorStateTransition_Icon;


        private static readonly UnityEditorIcon _BlendTree_Icon = BuildIcon("BlendTree Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BlendTree Icon" icon.</summary>
        public static UnityEditorIcon BlendTree_Icon => _BlendTree_Icon;


        private static readonly UnityEditorIcon _d_AnimatorController_Icon = BuildIcon("d_AnimatorController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorController Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorController_Icon => _d_AnimatorController_Icon;


        private static readonly UnityEditorIcon _d_AnimatorController_On_Icon = BuildIcon("d_AnimatorController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorController On Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorController_On_Icon => _d_AnimatorController_On_Icon;


        private static readonly UnityEditorIcon _d_AnimatorState_Icon = BuildIcon("d_AnimatorState Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorState Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorState_Icon => _d_AnimatorState_Icon;


        private static readonly UnityEditorIcon _d_AnimatorStateMachine_Icon = BuildIcon("d_AnimatorStateMachine Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorStateMachine Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorStateMachine_Icon => _d_AnimatorStateMachine_Icon;


        private static readonly UnityEditorIcon _d_AnimatorStateTransition_Icon = BuildIcon("d_AnimatorStateTransition Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorStateTransition Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorStateTransition_Icon => _d_AnimatorStateTransition_Icon;


        private static readonly UnityEditorIcon _d_BlendTree_Icon = BuildIcon("d_BlendTree Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BlendTree Icon" icon.</summary>
        public static UnityEditorIcon d_BlendTree_Icon => _d_BlendTree_Icon;


        private static readonly UnityEditorIcon _AnimationWindowEvent_Icon = BuildIcon("AnimationWindowEvent Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimationWindowEvent Icon" icon.</summary>
        public static UnityEditorIcon AnimationWindowEvent_Icon => _AnimationWindowEvent_Icon;


        private static readonly UnityEditorIcon _AudioMixerController_Icon = BuildIcon("AudioMixerController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioMixerController Icon" icon.</summary>
        public static UnityEditorIcon AudioMixerController_Icon => _AudioMixerController_Icon;


        private static readonly UnityEditorIcon _AudioMixerController_On_Icon = BuildIcon("AudioMixerController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioMixerController On Icon" icon.</summary>
        public static UnityEditorIcon AudioMixerController_On_Icon => _AudioMixerController_On_Icon;


        private static readonly UnityEditorIcon _d_AudioMixerController_Icon = BuildIcon("d_AudioMixerController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioMixerController Icon" icon.</summary>
        public static UnityEditorIcon d_AudioMixerController_Icon => _d_AudioMixerController_Icon;


        private static readonly UnityEditorIcon _d_AudioMixerController_On_Icon = BuildIcon("d_AudioMixerController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioMixerController On Icon" icon.</summary>
        public static UnityEditorIcon d_AudioMixerController_On_Icon => _d_AudioMixerController_On_Icon;


        private static readonly UnityEditorIcon _AudioImporter_Icon = BuildIcon("AudioImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioImporter Icon" icon.</summary>
        public static UnityEditorIcon AudioImporter_Icon => _AudioImporter_Icon;


        private static readonly UnityEditorIcon _d_AudioImporter_Icon = BuildIcon("d_AudioImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioImporter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioImporter_Icon => _d_AudioImporter_Icon;


        private static readonly UnityEditorIcon _d_DefaultAsset_Icon = BuildIcon("d_DefaultAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DefaultAsset Icon" icon.</summary>
        public static UnityEditorIcon d_DefaultAsset_Icon => _d_DefaultAsset_Icon;


        private static readonly UnityEditorIcon _d_IHVImageFormatImporter_Icon = BuildIcon("d_IHVImageFormatImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_IHVImageFormatImporter Icon" icon.</summary>
        public static UnityEditorIcon d_IHVImageFormatImporter_Icon => _d_IHVImageFormatImporter_Icon;


        private static readonly UnityEditorIcon _d_LightingDataAsset_Icon = BuildIcon("d_LightingDataAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightingDataAsset Icon" icon.</summary>
        public static UnityEditorIcon d_LightingDataAsset_Icon => _d_LightingDataAsset_Icon;


        private static readonly UnityEditorIcon _d_LightmapParameters_Icon = BuildIcon("d_LightmapParameters Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightmapParameters Icon" icon.</summary>
        public static UnityEditorIcon d_LightmapParameters_Icon => _d_LightmapParameters_Icon;


        private static readonly UnityEditorIcon _d_LightmapParameters_On_Icon = BuildIcon("d_LightmapParameters On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightmapParameters On Icon" icon.</summary>
        public static UnityEditorIcon d_LightmapParameters_On_Icon => _d_LightmapParameters_On_Icon;


        private static readonly UnityEditorIcon _d_ModelImporter_Icon = BuildIcon("d_ModelImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ModelImporter Icon" icon.</summary>
        public static UnityEditorIcon d_ModelImporter_Icon => _d_ModelImporter_Icon;


        private static readonly UnityEditorIcon _d_SceneAsset_Icon = BuildIcon("d_SceneAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneAsset Icon" icon.</summary>
        public static UnityEditorIcon d_SceneAsset_Icon => _d_SceneAsset_Icon;


        private static readonly UnityEditorIcon _d_ShaderImporter_Icon = BuildIcon("d_ShaderImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ShaderImporter Icon" icon.</summary>
        public static UnityEditorIcon d_ShaderImporter_Icon => _d_ShaderImporter_Icon;


        private static readonly UnityEditorIcon _d_TextScriptImporter_Icon = BuildIcon("d_TextScriptImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TextScriptImporter Icon" icon.</summary>
        public static UnityEditorIcon d_TextScriptImporter_Icon => _d_TextScriptImporter_Icon;


        private static readonly UnityEditorIcon _d_TextureImporter_Icon = BuildIcon("d_TextureImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TextureImporter Icon" icon.</summary>
        public static UnityEditorIcon d_TextureImporter_Icon => _d_TextureImporter_Icon;


        private static readonly UnityEditorIcon _d_TrueTypeFontImporter_Icon = BuildIcon("d_TrueTypeFontImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TrueTypeFontImporter Icon" icon.</summary>
        public static UnityEditorIcon d_TrueTypeFontImporter_Icon => _d_TrueTypeFontImporter_Icon;


        private static readonly UnityEditorIcon _DefaultAsset_Icon = BuildIcon("DefaultAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DefaultAsset Icon" icon.</summary>
        public static UnityEditorIcon DefaultAsset_Icon => _DefaultAsset_Icon;


        private static readonly UnityEditorIcon _EditorSettings_Icon = BuildIcon("EditorSettings Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EditorSettings Icon" icon.</summary>
        public static UnityEditorIcon EditorSettings_Icon => _EditorSettings_Icon;


        private static readonly UnityEditorIcon _AnyStateNode_Icon = BuildIcon("AnyStateNode Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnyStateNode Icon" icon.</summary>
        public static UnityEditorIcon AnyStateNode_Icon => _AnyStateNode_Icon;


        private static readonly UnityEditorIcon _d_AnyStateNode_Icon = BuildIcon("d_AnyStateNode Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnyStateNode Icon" icon.</summary>
        public static UnityEditorIcon d_AnyStateNode_Icon => _d_AnyStateNode_Icon;


        private static readonly UnityEditorIcon _HumanTemplate_Icon = BuildIcon("HumanTemplate Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HumanTemplate Icon" icon.</summary>
        public static UnityEditorIcon HumanTemplate_Icon => _HumanTemplate_Icon;


        private static readonly UnityEditorIcon _IHVImageFormatImporter_Icon = BuildIcon("IHVImageFormatImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "IHVImageFormatImporter Icon" icon.</summary>
        public static UnityEditorIcon IHVImageFormatImporter_Icon => _IHVImageFormatImporter_Icon;


        private static readonly UnityEditorIcon _LightingDataAsset_Icon = BuildIcon("LightingDataAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightingDataAsset Icon" icon.</summary>
        public static UnityEditorIcon LightingDataAsset_Icon => _LightingDataAsset_Icon;


        private static readonly UnityEditorIcon _LightmapParameters_Icon = BuildIcon("LightmapParameters Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightmapParameters Icon" icon.</summary>
        public static UnityEditorIcon LightmapParameters_Icon => _LightmapParameters_Icon;


        private static readonly UnityEditorIcon _LightmapParameters_On_Icon = BuildIcon("LightmapParameters On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightmapParameters On Icon" icon.</summary>
        public static UnityEditorIcon LightmapParameters_On_Icon => _LightmapParameters_On_Icon;


        private static readonly UnityEditorIcon _ModelImporter_Icon = BuildIcon("ModelImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ModelImporter Icon" icon.</summary>
        public static UnityEditorIcon ModelImporter_Icon => _ModelImporter_Icon;


        private static readonly UnityEditorIcon _Preset_Icon = BuildIcon("Preset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Preset Icon" icon.</summary>
        public static UnityEditorIcon Preset_Icon => _Preset_Icon;


        private static readonly UnityEditorIcon _SceneAsset_Icon = BuildIcon("SceneAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneAsset Icon" icon.</summary>
        public static UnityEditorIcon SceneAsset_Icon => _SceneAsset_Icon;


        private static readonly UnityEditorIcon _SceneAsset_On_Icon = BuildIcon("SceneAsset On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneAsset On Icon" icon.</summary>
        public static UnityEditorIcon SceneAsset_On_Icon => _SceneAsset_On_Icon;


        private static readonly UnityEditorIcon _SceneTemplateAsset_Icon = BuildIcon("SceneTemplateAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneTemplateAsset Icon" icon.</summary>
        public static UnityEditorIcon SceneTemplateAsset_Icon => _SceneTemplateAsset_Icon;


        private static readonly UnityEditorIcon _ShaderImporter_Icon = BuildIcon("ShaderImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ShaderImporter Icon" icon.</summary>
        public static UnityEditorIcon ShaderImporter_Icon => _ShaderImporter_Icon;


        private static readonly UnityEditorIcon _SpeedTreeImporter_Icon = BuildIcon("SpeedTreeImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpeedTreeImporter Icon" icon.</summary>
        public static UnityEditorIcon SpeedTreeImporter_Icon => _SpeedTreeImporter_Icon;


        private static readonly UnityEditorIcon _SubstanceArchive_Icon = BuildIcon("SubstanceArchive Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SubstanceArchive Icon" icon.</summary>
        public static UnityEditorIcon SubstanceArchive_Icon => _SubstanceArchive_Icon;


        private static readonly UnityEditorIcon _TextScriptImporter_Icon = BuildIcon("TextScriptImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TextScriptImporter Icon" icon.</summary>
        public static UnityEditorIcon TextScriptImporter_Icon => _TextScriptImporter_Icon;


        private static readonly UnityEditorIcon _TextureImporter_Icon = BuildIcon("TextureImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TextureImporter Icon" icon.</summary>
        public static UnityEditorIcon TextureImporter_Icon => _TextureImporter_Icon;


        private static readonly UnityEditorIcon _TrueTypeFontImporter_Icon = BuildIcon("TrueTypeFontImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TrueTypeFontImporter Icon" icon.</summary>
        public static UnityEditorIcon TrueTypeFontImporter_Icon => _TrueTypeFontImporter_Icon;


        private static readonly UnityEditorIcon _d_SpriteAtlasAsset_Icon = BuildIcon("d_SpriteAtlasAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteAtlasAsset Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteAtlasAsset_Icon => _d_SpriteAtlasAsset_Icon;


        private static readonly UnityEditorIcon _d_SpriteAtlasImporter_Icon = BuildIcon("d_SpriteAtlasImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteAtlasImporter Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteAtlasImporter_Icon => _d_SpriteAtlasImporter_Icon;


        private static readonly UnityEditorIcon _SpriteAtlasAsset_Icon = BuildIcon("SpriteAtlasAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteAtlasAsset Icon" icon.</summary>
        public static UnityEditorIcon SpriteAtlasAsset_Icon => _SpriteAtlasAsset_Icon;


        private static readonly UnityEditorIcon _SpriteAtlasImporter_Icon = BuildIcon("SpriteAtlasImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteAtlasImporter Icon" icon.</summary>
        public static UnityEditorIcon SpriteAtlasImporter_Icon => _SpriteAtlasImporter_Icon;


        private static readonly UnityEditorIcon _d_VisualEffectSubgraphBlock_Icon = BuildIcon("d_VisualEffectSubgraphBlock Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisualEffectSubgraphBlock Icon" icon.</summary>
        public static UnityEditorIcon d_VisualEffectSubgraphBlock_Icon => _d_VisualEffectSubgraphBlock_Icon;


        private static readonly UnityEditorIcon _d_VisualEffectSubgraphOperator_Icon = BuildIcon("d_VisualEffectSubgraphOperator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisualEffectSubgraphOperator Icon" icon.</summary>
        public static UnityEditorIcon d_VisualEffectSubgraphOperator_Icon => _d_VisualEffectSubgraphOperator_Icon;


        private static readonly UnityEditorIcon _VisualEffectSubgraphBlock_Icon = BuildIcon("VisualEffectSubgraphBlock Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualEffectSubgraphBlock Icon" icon.</summary>
        public static UnityEditorIcon VisualEffectSubgraphBlock_Icon => _VisualEffectSubgraphBlock_Icon;


        private static readonly UnityEditorIcon _VisualEffectSubgraphOperator_Icon = BuildIcon("VisualEffectSubgraphOperator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualEffectSubgraphOperator Icon" icon.</summary>
        public static UnityEditorIcon VisualEffectSubgraphOperator_Icon => _VisualEffectSubgraphOperator_Icon;


        private static readonly UnityEditorIcon _VideoClipImporter_Icon = BuildIcon("VideoClipImporter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VideoClipImporter Icon" icon.</summary>
        public static UnityEditorIcon VideoClipImporter_Icon => _VideoClipImporter_Icon;


        private static readonly UnityEditorIcon _AssemblyDefinitionAsset_Icon = BuildIcon("AssemblyDefinitionAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AssemblyDefinitionAsset Icon" icon.</summary>
        public static UnityEditorIcon AssemblyDefinitionAsset_Icon => _AssemblyDefinitionAsset_Icon;


        private static readonly UnityEditorIcon _AssemblyDefinitionReferenceAsset_Icon = BuildIcon("AssemblyDefinitionReferenceAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AssemblyDefinitionReferenceAsset Icon" icon.</summary>
        public static UnityEditorIcon AssemblyDefinitionReferenceAsset_Icon => _AssemblyDefinitionReferenceAsset_Icon;


        private static readonly UnityEditorIcon _d_AssemblyDefinitionAsset_Icon = BuildIcon("d_AssemblyDefinitionAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AssemblyDefinitionAsset Icon" icon.</summary>
        public static UnityEditorIcon d_AssemblyDefinitionAsset_Icon => _d_AssemblyDefinitionAsset_Icon;


        private static readonly UnityEditorIcon _d_AssemblyDefinitionReferenceAsset_Icon = BuildIcon("d_AssemblyDefinitionReferenceAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AssemblyDefinitionReferenceAsset Icon" icon.</summary>
        public static UnityEditorIcon d_AssemblyDefinitionReferenceAsset_Icon => _d_AssemblyDefinitionReferenceAsset_Icon;


        private static readonly UnityEditorIcon _d_NavMeshAgent_Icon = BuildIcon("d_NavMeshAgent Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NavMeshAgent Icon" icon.</summary>
        public static UnityEditorIcon d_NavMeshAgent_Icon => _d_NavMeshAgent_Icon;


        private static readonly UnityEditorIcon _d_NavMeshData_Icon = BuildIcon("d_NavMeshData Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NavMeshData Icon" icon.</summary>
        public static UnityEditorIcon d_NavMeshData_Icon => _d_NavMeshData_Icon;


        private static readonly UnityEditorIcon _d_NavMeshObstacle_Icon = BuildIcon("d_NavMeshObstacle Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NavMeshObstacle Icon" icon.</summary>
        public static UnityEditorIcon d_NavMeshObstacle_Icon => _d_NavMeshObstacle_Icon;


        private static readonly UnityEditorIcon _d_OffMeshLink_Icon = BuildIcon("d_OffMeshLink Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_OffMeshLink Icon" icon.</summary>
        public static UnityEditorIcon d_OffMeshLink_Icon => _d_OffMeshLink_Icon;


        private static readonly UnityEditorIcon _NavMeshAgent_Icon = BuildIcon("NavMeshAgent Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NavMeshAgent Icon" icon.</summary>
        public static UnityEditorIcon NavMeshAgent_Icon => _NavMeshAgent_Icon;


        private static readonly UnityEditorIcon _NavMeshData_Icon = BuildIcon("NavMeshData Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NavMeshData Icon" icon.</summary>
        public static UnityEditorIcon NavMeshData_Icon => _NavMeshData_Icon;


        private static readonly UnityEditorIcon _NavMeshObstacle_Icon = BuildIcon("NavMeshObstacle Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NavMeshObstacle Icon" icon.</summary>
        public static UnityEditorIcon NavMeshObstacle_Icon => _NavMeshObstacle_Icon;


        private static readonly UnityEditorIcon _OffMeshLink_Icon = BuildIcon("OffMeshLink Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "OffMeshLink Icon" icon.</summary>
        public static UnityEditorIcon OffMeshLink_Icon => _OffMeshLink_Icon;


        private static readonly UnityEditorIcon _AnalyticsTracker_Icon = BuildIcon("AnalyticsTracker Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnalyticsTracker Icon" icon.</summary>
        public static UnityEditorIcon AnalyticsTracker_Icon => _AnalyticsTracker_Icon;


        private static readonly UnityEditorIcon _d_AnalyticsTracker_Icon = BuildIcon("d_AnalyticsTracker Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnalyticsTracker Icon" icon.</summary>
        public static UnityEditorIcon d_AnalyticsTracker_Icon => _d_AnalyticsTracker_Icon;


        private static readonly UnityEditorIcon _Animation_Icon = BuildIcon("Animation Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animation Icon" icon.</summary>
        public static UnityEditorIcon Animation_Icon => _Animation_Icon;


        private static readonly UnityEditorIcon _AnimationClip_Icon = BuildIcon("AnimationClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimationClip Icon" icon.</summary>
        public static UnityEditorIcon AnimationClip_Icon => _AnimationClip_Icon;


        private static readonly UnityEditorIcon _AnimationClip_On_Icon = BuildIcon("AnimationClip On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimationClip On Icon" icon.</summary>
        public static UnityEditorIcon AnimationClip_On_Icon => _AnimationClip_On_Icon;


        private static readonly UnityEditorIcon _AimConstraint_Icon = BuildIcon("AimConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AimConstraint Icon" icon.</summary>
        public static UnityEditorIcon AimConstraint_Icon => _AimConstraint_Icon;


        private static readonly UnityEditorIcon _d_AimConstraint_Icon = BuildIcon("d_AimConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AimConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_AimConstraint_Icon => _d_AimConstraint_Icon;


        private static readonly UnityEditorIcon _d_LookAtConstraint_Icon = BuildIcon("d_LookAtConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LookAtConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_LookAtConstraint_Icon => _d_LookAtConstraint_Icon;


        private static readonly UnityEditorIcon _d_ParentConstraint_Icon = BuildIcon("d_ParentConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParentConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_ParentConstraint_Icon => _d_ParentConstraint_Icon;


        private static readonly UnityEditorIcon _d_PositionConstraint_Icon = BuildIcon("d_PositionConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PositionConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_PositionConstraint_Icon => _d_PositionConstraint_Icon;


        private static readonly UnityEditorIcon _d_RotationConstraint_Icon = BuildIcon("d_RotationConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RotationConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_RotationConstraint_Icon => _d_RotationConstraint_Icon;


        private static readonly UnityEditorIcon _d_ScaleConstraint_Icon = BuildIcon("d_ScaleConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScaleConstraint Icon" icon.</summary>
        public static UnityEditorIcon d_ScaleConstraint_Icon => _d_ScaleConstraint_Icon;


        private static readonly UnityEditorIcon _LookAtConstraint_Icon = BuildIcon("LookAtConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LookAtConstraint Icon" icon.</summary>
        public static UnityEditorIcon LookAtConstraint_Icon => _LookAtConstraint_Icon;


        private static readonly UnityEditorIcon _ParentConstraint_Icon = BuildIcon("ParentConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParentConstraint Icon" icon.</summary>
        public static UnityEditorIcon ParentConstraint_Icon => _ParentConstraint_Icon;


        private static readonly UnityEditorIcon _PositionConstraint_Icon = BuildIcon("PositionConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PositionConstraint Icon" icon.</summary>
        public static UnityEditorIcon PositionConstraint_Icon => _PositionConstraint_Icon;


        private static readonly UnityEditorIcon _RotationConstraint_Icon = BuildIcon("RotationConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotationConstraint Icon" icon.</summary>
        public static UnityEditorIcon RotationConstraint_Icon => _RotationConstraint_Icon;


        private static readonly UnityEditorIcon _ScaleConstraint_Icon = BuildIcon("ScaleConstraint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScaleConstraint Icon" icon.</summary>
        public static UnityEditorIcon ScaleConstraint_Icon => _ScaleConstraint_Icon;


        private static readonly UnityEditorIcon _Animator_Icon = BuildIcon("Animator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Animator Icon" icon.</summary>
        public static UnityEditorIcon Animator_Icon => _Animator_Icon;


        private static readonly UnityEditorIcon _AnimatorOverrideController_Icon = BuildIcon("AnimatorOverrideController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorOverrideController Icon" icon.</summary>
        public static UnityEditorIcon AnimatorOverrideController_Icon => _AnimatorOverrideController_Icon;


        private static readonly UnityEditorIcon _AnimatorOverrideController_On_Icon = BuildIcon("AnimatorOverrideController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AnimatorOverrideController On Icon" icon.</summary>
        public static UnityEditorIcon AnimatorOverrideController_On_Icon => _AnimatorOverrideController_On_Icon;


        private static readonly UnityEditorIcon _AreaEffector2D_Icon = BuildIcon("AreaEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AreaEffector2D Icon" icon.</summary>
        public static UnityEditorIcon AreaEffector2D_Icon => _AreaEffector2D_Icon;


        private static readonly UnityEditorIcon _ArticulationBody_Icon = BuildIcon("ArticulationBody Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ArticulationBody Icon" icon.</summary>
        public static UnityEditorIcon ArticulationBody_Icon => _ArticulationBody_Icon;


        private static readonly UnityEditorIcon _AudioMixerGroup_Icon = BuildIcon("AudioMixerGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioMixerGroup Icon" icon.</summary>
        public static UnityEditorIcon AudioMixerGroup_Icon => _AudioMixerGroup_Icon;


        private static readonly UnityEditorIcon _AudioMixerSnapshot_Icon = BuildIcon("AudioMixerSnapshot Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioMixerSnapshot Icon" icon.</summary>
        public static UnityEditorIcon AudioMixerSnapshot_Icon => _AudioMixerSnapshot_Icon;


        private static readonly UnityEditorIcon _AudioSpatializerMicrosoft_Icon = BuildIcon("AudioSpatializerMicrosoft Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioSpatializerMicrosoft Icon" icon.</summary>
        public static UnityEditorIcon AudioSpatializerMicrosoft_Icon => _AudioSpatializerMicrosoft_Icon;


        private static readonly UnityEditorIcon _d_AudioMixerGroup_Icon = BuildIcon("d_AudioMixerGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioMixerGroup Icon" icon.</summary>
        public static UnityEditorIcon d_AudioMixerGroup_Icon => _d_AudioMixerGroup_Icon;


        private static readonly UnityEditorIcon _d_AudioMixerSnapshot_Icon = BuildIcon("d_AudioMixerSnapshot Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioMixerSnapshot Icon" icon.</summary>
        public static UnityEditorIcon d_AudioMixerSnapshot_Icon => _d_AudioMixerSnapshot_Icon;


        private static readonly UnityEditorIcon _d_AudioSpatializerMicrosoft_Icon = BuildIcon("d_AudioSpatializerMicrosoft Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioSpatializerMicrosoft Icon" icon.</summary>
        public static UnityEditorIcon d_AudioSpatializerMicrosoft_Icon => _d_AudioSpatializerMicrosoft_Icon;


        private static readonly UnityEditorIcon _AudioChorusFilter_Icon = BuildIcon("AudioChorusFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioChorusFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioChorusFilter_Icon => _AudioChorusFilter_Icon;


        private static readonly UnityEditorIcon _AudioClip_Icon = BuildIcon("AudioClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioClip Icon" icon.</summary>
        public static UnityEditorIcon AudioClip_Icon => _AudioClip_Icon;


        private static readonly UnityEditorIcon _AudioClip_On_Icon = BuildIcon("AudioClip On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioClip On Icon" icon.</summary>
        public static UnityEditorIcon AudioClip_On_Icon => _AudioClip_On_Icon;


        private static readonly UnityEditorIcon _AudioDistortionFilter_Icon = BuildIcon("AudioDistortionFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioDistortionFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioDistortionFilter_Icon => _AudioDistortionFilter_Icon;


        private static readonly UnityEditorIcon _AudioEchoFilter_Icon = BuildIcon("AudioEchoFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioEchoFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioEchoFilter_Icon => _AudioEchoFilter_Icon;


        private static readonly UnityEditorIcon _AudioHighPassFilter_Icon = BuildIcon("AudioHighPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioHighPassFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioHighPassFilter_Icon => _AudioHighPassFilter_Icon;


        private static readonly UnityEditorIcon _AudioListener_Icon = BuildIcon("AudioListener Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioListener Icon" icon.</summary>
        public static UnityEditorIcon AudioListener_Icon => _AudioListener_Icon;


        private static readonly UnityEditorIcon _AudioLowPassFilter_Icon = BuildIcon("AudioLowPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioLowPassFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioLowPassFilter_Icon => _AudioLowPassFilter_Icon;


        private static readonly UnityEditorIcon _AudioReverbFilter_Icon = BuildIcon("AudioReverbFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioReverbFilter Icon" icon.</summary>
        public static UnityEditorIcon AudioReverbFilter_Icon => _AudioReverbFilter_Icon;


        private static readonly UnityEditorIcon _AudioReverbZone_Icon = BuildIcon("AudioReverbZone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioReverbZone Icon" icon.</summary>
        public static UnityEditorIcon AudioReverbZone_Icon => _AudioReverbZone_Icon;


        private static readonly UnityEditorIcon _AudioSource_Icon = BuildIcon("AudioSource Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AudioSource Icon" icon.</summary>
        public static UnityEditorIcon AudioSource_Icon => _AudioSource_Icon;


        private static readonly UnityEditorIcon _Avatar_Icon = BuildIcon("Avatar Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Avatar Icon" icon.</summary>
        public static UnityEditorIcon Avatar_Icon => _Avatar_Icon;


        private static readonly UnityEditorIcon _AvatarMask_Icon = BuildIcon("AvatarMask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarMask Icon" icon.</summary>
        public static UnityEditorIcon AvatarMask_Icon => _AvatarMask_Icon;


        private static readonly UnityEditorIcon _AvatarMask_On_Icon = BuildIcon("AvatarMask On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AvatarMask On Icon" icon.</summary>
        public static UnityEditorIcon AvatarMask_On_Icon => _AvatarMask_On_Icon;


        private static readonly UnityEditorIcon _BillboardAsset_Icon = BuildIcon("BillboardAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BillboardAsset Icon" icon.</summary>
        public static UnityEditorIcon BillboardAsset_Icon => _BillboardAsset_Icon;


        private static readonly UnityEditorIcon _BillboardRenderer_Icon = BuildIcon("BillboardRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BillboardRenderer Icon" icon.</summary>
        public static UnityEditorIcon BillboardRenderer_Icon => _BillboardRenderer_Icon;


        private static readonly UnityEditorIcon _BoxCollider_Icon = BuildIcon("BoxCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BoxCollider Icon" icon.</summary>
        public static UnityEditorIcon BoxCollider_Icon => _BoxCollider_Icon;


        private static readonly UnityEditorIcon _BoxCollider2D_Icon = BuildIcon("BoxCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BoxCollider2D Icon" icon.</summary>
        public static UnityEditorIcon BoxCollider2D_Icon => _BoxCollider2D_Icon;


        private static readonly UnityEditorIcon _BuoyancyEffector2D_Icon = BuildIcon("BuoyancyEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "BuoyancyEffector2D Icon" icon.</summary>
        public static UnityEditorIcon BuoyancyEffector2D_Icon => _BuoyancyEffector2D_Icon;


        private static readonly UnityEditorIcon _Camera_Icon = BuildIcon("Camera Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Camera Icon" icon.</summary>
        public static UnityEditorIcon Camera_Icon => _Camera_Icon;


        private static readonly UnityEditorIcon _Canvas_Icon = BuildIcon("Canvas Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Canvas Icon" icon.</summary>
        public static UnityEditorIcon Canvas_Icon => _Canvas_Icon;


        private static readonly UnityEditorIcon _CanvasGroup_Icon = BuildIcon("CanvasGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CanvasGroup Icon" icon.</summary>
        public static UnityEditorIcon CanvasGroup_Icon => _CanvasGroup_Icon;


        private static readonly UnityEditorIcon _CanvasRenderer_Icon = BuildIcon("CanvasRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CanvasRenderer Icon" icon.</summary>
        public static UnityEditorIcon CanvasRenderer_Icon => _CanvasRenderer_Icon;


        private static readonly UnityEditorIcon _CapsuleCollider_Icon = BuildIcon("CapsuleCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CapsuleCollider Icon" icon.</summary>
        public static UnityEditorIcon CapsuleCollider_Icon => _CapsuleCollider_Icon;


        private static readonly UnityEditorIcon _CapsuleCollider2D_Icon = BuildIcon("CapsuleCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CapsuleCollider2D Icon" icon.</summary>
        public static UnityEditorIcon CapsuleCollider2D_Icon => _CapsuleCollider2D_Icon;


        private static readonly UnityEditorIcon _CharacterController_Icon = BuildIcon("CharacterController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CharacterController Icon" icon.</summary>
        public static UnityEditorIcon CharacterController_Icon => _CharacterController_Icon;


        private static readonly UnityEditorIcon _CharacterJoint_Icon = BuildIcon("CharacterJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CharacterJoint Icon" icon.</summary>
        public static UnityEditorIcon CharacterJoint_Icon => _CharacterJoint_Icon;


        private static readonly UnityEditorIcon _CircleCollider2D_Icon = BuildIcon("CircleCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CircleCollider2D Icon" icon.</summary>
        public static UnityEditorIcon CircleCollider2D_Icon => _CircleCollider2D_Icon;


        private static readonly UnityEditorIcon _Cloth_Icon = BuildIcon("Cloth Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Cloth Icon" icon.</summary>
        public static UnityEditorIcon Cloth_Icon => _Cloth_Icon;


        private static readonly UnityEditorIcon _CompositeCollider2D_Icon = BuildIcon("CompositeCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CompositeCollider2D Icon" icon.</summary>
        public static UnityEditorIcon CompositeCollider2D_Icon => _CompositeCollider2D_Icon;


        private static readonly UnityEditorIcon _ComputeShader_Icon = BuildIcon("ComputeShader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ComputeShader Icon" icon.</summary>
        public static UnityEditorIcon ComputeShader_Icon => _ComputeShader_Icon;


        private static readonly UnityEditorIcon _ConfigurableJoint_Icon = BuildIcon("ConfigurableJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ConfigurableJoint Icon" icon.</summary>
        public static UnityEditorIcon ConfigurableJoint_Icon => _ConfigurableJoint_Icon;


        private static readonly UnityEditorIcon _ConstantForce_Icon = BuildIcon("ConstantForce Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ConstantForce Icon" icon.</summary>
        public static UnityEditorIcon ConstantForce_Icon => _ConstantForce_Icon;


        private static readonly UnityEditorIcon _ConstantForce2D_Icon = BuildIcon("ConstantForce2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ConstantForce2D Icon" icon.</summary>
        public static UnityEditorIcon ConstantForce2D_Icon => _ConstantForce2D_Icon;


        private static readonly UnityEditorIcon _Cubemap_Icon = BuildIcon("Cubemap Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Cubemap Icon" icon.</summary>
        public static UnityEditorIcon Cubemap_Icon => _Cubemap_Icon;


        private static readonly UnityEditorIcon _d_Animation_Icon = BuildIcon("d_Animation Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animation Icon" icon.</summary>
        public static UnityEditorIcon d_Animation_Icon => _d_Animation_Icon;


        private static readonly UnityEditorIcon _d_AnimationClip_Icon = BuildIcon("d_AnimationClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimationClip Icon" icon.</summary>
        public static UnityEditorIcon d_AnimationClip_Icon => _d_AnimationClip_Icon;


        private static readonly UnityEditorIcon _d_AnimationClip_On_Icon = BuildIcon("d_AnimationClip On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimationClip On Icon" icon.</summary>
        public static UnityEditorIcon d_AnimationClip_On_Icon => _d_AnimationClip_On_Icon;


        private static readonly UnityEditorIcon _d_Animator_Icon = BuildIcon("d_Animator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Animator Icon" icon.</summary>
        public static UnityEditorIcon d_Animator_Icon => _d_Animator_Icon;


        private static readonly UnityEditorIcon _d_AnimatorOverrideController_Icon = BuildIcon("d_AnimatorOverrideController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorOverrideController Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorOverrideController_Icon => _d_AnimatorOverrideController_Icon;


        private static readonly UnityEditorIcon _d_AnimatorOverrideController_On_Icon = BuildIcon("d_AnimatorOverrideController On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AnimatorOverrideController On Icon" icon.</summary>
        public static UnityEditorIcon d_AnimatorOverrideController_On_Icon => _d_AnimatorOverrideController_On_Icon;


        private static readonly UnityEditorIcon _d_AreaEffector2D_Icon = BuildIcon("d_AreaEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AreaEffector2D Icon" icon.</summary>
        public static UnityEditorIcon d_AreaEffector2D_Icon => _d_AreaEffector2D_Icon;


        private static readonly UnityEditorIcon _d_ArticulationBody_Icon = BuildIcon("d_ArticulationBody Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ArticulationBody Icon" icon.</summary>
        public static UnityEditorIcon d_ArticulationBody_Icon => _d_ArticulationBody_Icon;


        private static readonly UnityEditorIcon _d_AudioChorusFilter_Icon = BuildIcon("d_AudioChorusFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioChorusFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioChorusFilter_Icon => _d_AudioChorusFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioClip_Icon = BuildIcon("d_AudioClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioClip Icon" icon.</summary>
        public static UnityEditorIcon d_AudioClip_Icon => _d_AudioClip_Icon;


        private static readonly UnityEditorIcon _d_AudioClip_On_Icon = BuildIcon("d_AudioClip On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioClip On Icon" icon.</summary>
        public static UnityEditorIcon d_AudioClip_On_Icon => _d_AudioClip_On_Icon;


        private static readonly UnityEditorIcon _d_AudioDistortionFilter_Icon = BuildIcon("d_AudioDistortionFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioDistortionFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioDistortionFilter_Icon => _d_AudioDistortionFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioEchoFilter_Icon = BuildIcon("d_AudioEchoFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioEchoFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioEchoFilter_Icon => _d_AudioEchoFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioHighPassFilter_Icon = BuildIcon("d_AudioHighPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioHighPassFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioHighPassFilter_Icon => _d_AudioHighPassFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioListener_Icon = BuildIcon("d_AudioListener Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioListener Icon" icon.</summary>
        public static UnityEditorIcon d_AudioListener_Icon => _d_AudioListener_Icon;


        private static readonly UnityEditorIcon _d_AudioLowPassFilter_Icon = BuildIcon("d_AudioLowPassFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioLowPassFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioLowPassFilter_Icon => _d_AudioLowPassFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioReverbFilter_Icon = BuildIcon("d_AudioReverbFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioReverbFilter Icon" icon.</summary>
        public static UnityEditorIcon d_AudioReverbFilter_Icon => _d_AudioReverbFilter_Icon;


        private static readonly UnityEditorIcon _d_AudioReverbZone_Icon = BuildIcon("d_AudioReverbZone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioReverbZone Icon" icon.</summary>
        public static UnityEditorIcon d_AudioReverbZone_Icon => _d_AudioReverbZone_Icon;


        private static readonly UnityEditorIcon _d_AudioSource_Icon = BuildIcon("d_AudioSource Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AudioSource Icon" icon.</summary>
        public static UnityEditorIcon d_AudioSource_Icon => _d_AudioSource_Icon;


        private static readonly UnityEditorIcon _d_Avatar_Icon = BuildIcon("d_Avatar Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Avatar Icon" icon.</summary>
        public static UnityEditorIcon d_Avatar_Icon => _d_Avatar_Icon;


        private static readonly UnityEditorIcon _d_AvatarMask_Icon = BuildIcon("d_AvatarMask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarMask Icon" icon.</summary>
        public static UnityEditorIcon d_AvatarMask_Icon => _d_AvatarMask_Icon;


        private static readonly UnityEditorIcon _d_AvatarMask_On_Icon = BuildIcon("d_AvatarMask On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AvatarMask On Icon" icon.</summary>
        public static UnityEditorIcon d_AvatarMask_On_Icon => _d_AvatarMask_On_Icon;


        private static readonly UnityEditorIcon _d_BillboardAsset_Icon = BuildIcon("d_BillboardAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BillboardAsset Icon" icon.</summary>
        public static UnityEditorIcon d_BillboardAsset_Icon => _d_BillboardAsset_Icon;


        private static readonly UnityEditorIcon _d_BillboardRenderer_Icon = BuildIcon("d_BillboardRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BillboardRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_BillboardRenderer_Icon => _d_BillboardRenderer_Icon;


        private static readonly UnityEditorIcon _d_BoxCollider_Icon = BuildIcon("d_BoxCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BoxCollider Icon" icon.</summary>
        public static UnityEditorIcon d_BoxCollider_Icon => _d_BoxCollider_Icon;


        private static readonly UnityEditorIcon _d_BoxCollider2D_Icon = BuildIcon("d_BoxCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BoxCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_BoxCollider2D_Icon => _d_BoxCollider2D_Icon;


        private static readonly UnityEditorIcon _d_BuoyancyEffector2D_Icon = BuildIcon("d_BuoyancyEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_BuoyancyEffector2D Icon" icon.</summary>
        public static UnityEditorIcon d_BuoyancyEffector2D_Icon => _d_BuoyancyEffector2D_Icon;


        private static readonly UnityEditorIcon _d_Camera_Icon = BuildIcon("d_Camera Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Camera Icon" icon.</summary>
        public static UnityEditorIcon d_Camera_Icon => _d_Camera_Icon;


        private static readonly UnityEditorIcon _d_Canvas_Icon = BuildIcon("d_Canvas Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Canvas Icon" icon.</summary>
        public static UnityEditorIcon d_Canvas_Icon => _d_Canvas_Icon;


        private static readonly UnityEditorIcon _d_CanvasGroup_Icon = BuildIcon("d_CanvasGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CanvasGroup Icon" icon.</summary>
        public static UnityEditorIcon d_CanvasGroup_Icon => _d_CanvasGroup_Icon;


        private static readonly UnityEditorIcon _d_CanvasRenderer_Icon = BuildIcon("d_CanvasRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CanvasRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_CanvasRenderer_Icon => _d_CanvasRenderer_Icon;


        private static readonly UnityEditorIcon _d_CapsuleCollider_Icon = BuildIcon("d_CapsuleCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CapsuleCollider Icon" icon.</summary>
        public static UnityEditorIcon d_CapsuleCollider_Icon => _d_CapsuleCollider_Icon;


        private static readonly UnityEditorIcon _d_CapsuleCollider2D_Icon = BuildIcon("d_CapsuleCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CapsuleCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_CapsuleCollider2D_Icon => _d_CapsuleCollider2D_Icon;


        private static readonly UnityEditorIcon _d_CharacterController_Icon = BuildIcon("d_CharacterController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CharacterController Icon" icon.</summary>
        public static UnityEditorIcon d_CharacterController_Icon => _d_CharacterController_Icon;


        private static readonly UnityEditorIcon _d_CharacterJoint_Icon = BuildIcon("d_CharacterJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CharacterJoint Icon" icon.</summary>
        public static UnityEditorIcon d_CharacterJoint_Icon => _d_CharacterJoint_Icon;


        private static readonly UnityEditorIcon _d_CircleCollider2D_Icon = BuildIcon("d_CircleCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CircleCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_CircleCollider2D_Icon => _d_CircleCollider2D_Icon;


        private static readonly UnityEditorIcon _d_Cloth_Icon = BuildIcon("d_Cloth Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Cloth Icon" icon.</summary>
        public static UnityEditorIcon d_Cloth_Icon => _d_Cloth_Icon;


        private static readonly UnityEditorIcon _d_CompositeCollider2D_Icon = BuildIcon("d_CompositeCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CompositeCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_CompositeCollider2D_Icon => _d_CompositeCollider2D_Icon;


        private static readonly UnityEditorIcon _d_ComputeShader_Icon = BuildIcon("d_ComputeShader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ComputeShader Icon" icon.</summary>
        public static UnityEditorIcon d_ComputeShader_Icon => _d_ComputeShader_Icon;


        private static readonly UnityEditorIcon _d_ConfigurableJoint_Icon = BuildIcon("d_ConfigurableJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ConfigurableJoint Icon" icon.</summary>
        public static UnityEditorIcon d_ConfigurableJoint_Icon => _d_ConfigurableJoint_Icon;


        private static readonly UnityEditorIcon _d_ConstantForce_Icon = BuildIcon("d_ConstantForce Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ConstantForce Icon" icon.</summary>
        public static UnityEditorIcon d_ConstantForce_Icon => _d_ConstantForce_Icon;


        private static readonly UnityEditorIcon _d_ConstantForce2D_Icon = BuildIcon("d_ConstantForce2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ConstantForce2D Icon" icon.</summary>
        public static UnityEditorIcon d_ConstantForce2D_Icon => _d_ConstantForce2D_Icon;


        private static readonly UnityEditorIcon _d_Cubemap_Icon = BuildIcon("d_Cubemap Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Cubemap Icon" icon.</summary>
        public static UnityEditorIcon d_Cubemap_Icon => _d_Cubemap_Icon;


        private static readonly UnityEditorIcon _d_DistanceJoint2D_Icon = BuildIcon("d_DistanceJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DistanceJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_DistanceJoint2D_Icon => _d_DistanceJoint2D_Icon;


        private static readonly UnityEditorIcon _d_EdgeCollider2D_Icon = BuildIcon("d_EdgeCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_EdgeCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_EdgeCollider2D_Icon => _d_EdgeCollider2D_Icon;


        private static readonly UnityEditorIcon _d_FixedJoint_Icon = BuildIcon("d_FixedJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FixedJoint Icon" icon.</summary>
        public static UnityEditorIcon d_FixedJoint_Icon => _d_FixedJoint_Icon;


        private static readonly UnityEditorIcon _d_Flare_Icon = BuildIcon("d_Flare Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Flare Icon" icon.</summary>
        public static UnityEditorIcon d_Flare_Icon => _d_Flare_Icon;


        private static readonly UnityEditorIcon _d_Flare_On_Icon = BuildIcon("d_Flare On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Flare On Icon" icon.</summary>
        public static UnityEditorIcon d_Flare_On_Icon => _d_Flare_On_Icon;


        private static readonly UnityEditorIcon _d_FlareLayer_Icon = BuildIcon("d_FlareLayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FlareLayer Icon" icon.</summary>
        public static UnityEditorIcon d_FlareLayer_Icon => _d_FlareLayer_Icon;


        private static readonly UnityEditorIcon _d_Font_Icon = BuildIcon("d_Font Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Font Icon" icon.</summary>
        public static UnityEditorIcon d_Font_Icon => _d_Font_Icon;


        private static readonly UnityEditorIcon _d_FrictionJoint2D_Icon = BuildIcon("d_FrictionJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FrictionJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_FrictionJoint2D_Icon => _d_FrictionJoint2D_Icon;


        private static readonly UnityEditorIcon _d_GameObject_Icon = BuildIcon("d_GameObject Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GameObject Icon" icon.</summary>
        public static UnityEditorIcon d_GameObject_Icon => _d_GameObject_Icon;


        private static readonly UnityEditorIcon _d_Grid_Icon = BuildIcon("d_Grid Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Grid Icon" icon.</summary>
        public static UnityEditorIcon d_Grid_Icon => _d_Grid_Icon;


        private static readonly UnityEditorIcon _d_GUISkin_Icon = BuildIcon("d_GUISkin Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GUISkin Icon" icon.</summary>
        public static UnityEditorIcon d_GUISkin_Icon => _d_GUISkin_Icon;


        private static readonly UnityEditorIcon _d_GUISkin_On_Icon = BuildIcon("d_GUISkin On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GUISkin On Icon" icon.</summary>
        public static UnityEditorIcon d_GUISkin_On_Icon => _d_GUISkin_On_Icon;


        private static readonly UnityEditorIcon _d_Halo_Icon = BuildIcon("d_Halo Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Halo Icon" icon.</summary>
        public static UnityEditorIcon d_Halo_Icon => _d_Halo_Icon;


        private static readonly UnityEditorIcon _d_HingeJoint_Icon = BuildIcon("d_HingeJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_HingeJoint Icon" icon.</summary>
        public static UnityEditorIcon d_HingeJoint_Icon => _d_HingeJoint_Icon;


        private static readonly UnityEditorIcon _d_HingeJoint2D_Icon = BuildIcon("d_HingeJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_HingeJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_HingeJoint2D_Icon => _d_HingeJoint2D_Icon;


        private static readonly UnityEditorIcon _d_Light_Icon = BuildIcon("d_Light Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Light Icon" icon.</summary>
        public static UnityEditorIcon d_Light_Icon => _d_Light_Icon;


        private static readonly UnityEditorIcon _d_LightingSettings_Icon = BuildIcon("d_LightingSettings Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightingSettings Icon" icon.</summary>
        public static UnityEditorIcon d_LightingSettings_Icon => _d_LightingSettings_Icon;


        private static readonly UnityEditorIcon _d_LightProbeGroup_Icon = BuildIcon("d_LightProbeGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightProbeGroup Icon" icon.</summary>
        public static UnityEditorIcon d_LightProbeGroup_Icon => _d_LightProbeGroup_Icon;


        private static readonly UnityEditorIcon _d_LightProbeProxyVolume_Icon = BuildIcon("d_LightProbeProxyVolume Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightProbeProxyVolume Icon" icon.</summary>
        public static UnityEditorIcon d_LightProbeProxyVolume_Icon => _d_LightProbeProxyVolume_Icon;


        private static readonly UnityEditorIcon _d_LightProbes_Icon = BuildIcon("d_LightProbes Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LightProbes Icon" icon.</summary>
        public static UnityEditorIcon d_LightProbes_Icon => _d_LightProbes_Icon;


        private static readonly UnityEditorIcon _d_LineRenderer_Icon = BuildIcon("d_LineRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LineRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_LineRenderer_Icon => _d_LineRenderer_Icon;


        private static readonly UnityEditorIcon _d_LODGroup_Icon = BuildIcon("d_LODGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LODGroup Icon" icon.</summary>
        public static UnityEditorIcon d_LODGroup_Icon => _d_LODGroup_Icon;


        private static readonly UnityEditorIcon _d_Material_Icon = BuildIcon("d_Material Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Material Icon" icon.</summary>
        public static UnityEditorIcon d_Material_Icon => _d_Material_Icon;


        private static readonly UnityEditorIcon _d_Material_On_Icon = BuildIcon("d_Material On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Material On Icon" icon.</summary>
        public static UnityEditorIcon d_Material_On_Icon => _d_Material_On_Icon;


        private static readonly UnityEditorIcon _d_Mesh_Icon = BuildIcon("d_Mesh Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Mesh Icon" icon.</summary>
        public static UnityEditorIcon d_Mesh_Icon => _d_Mesh_Icon;


        private static readonly UnityEditorIcon _d_MeshCollider_Icon = BuildIcon("d_MeshCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MeshCollider Icon" icon.</summary>
        public static UnityEditorIcon d_MeshCollider_Icon => _d_MeshCollider_Icon;


        private static readonly UnityEditorIcon _d_MeshFilter_Icon = BuildIcon("d_MeshFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MeshFilter Icon" icon.</summary>
        public static UnityEditorIcon d_MeshFilter_Icon => _d_MeshFilter_Icon;


        private static readonly UnityEditorIcon _d_MeshRenderer_Icon = BuildIcon("d_MeshRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_MeshRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_MeshRenderer_Icon => _d_MeshRenderer_Icon;


        private static readonly UnityEditorIcon _d_Motion_Icon = BuildIcon("d_Motion Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Motion Icon" icon.</summary>
        public static UnityEditorIcon d_Motion_Icon => _d_Motion_Icon;


        private static readonly UnityEditorIcon _d_OcclusionArea_Icon = BuildIcon("d_OcclusionArea Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_OcclusionArea Icon" icon.</summary>
        public static UnityEditorIcon d_OcclusionArea_Icon => _d_OcclusionArea_Icon;


        private static readonly UnityEditorIcon _d_OcclusionPortal_Icon = BuildIcon("d_OcclusionPortal Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_OcclusionPortal Icon" icon.</summary>
        public static UnityEditorIcon d_OcclusionPortal_Icon => _d_OcclusionPortal_Icon;


        private static readonly UnityEditorIcon _d_ParticleSystem_Icon = BuildIcon("d_ParticleSystem Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleSystem Icon" icon.</summary>
        public static UnityEditorIcon d_ParticleSystem_Icon => _d_ParticleSystem_Icon;


        private static readonly UnityEditorIcon _d_ParticleSystemForceField_Icon = BuildIcon("d_ParticleSystemForceField Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ParticleSystemForceField Icon" icon.</summary>
        public static UnityEditorIcon d_ParticleSystemForceField_Icon => _d_ParticleSystemForceField_Icon;


        private static readonly UnityEditorIcon _d_PhysicMaterial_Icon = BuildIcon("d_PhysicMaterial Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicMaterial Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicMaterial_Icon => _d_PhysicMaterial_Icon;


        private static readonly UnityEditorIcon _d_PhysicMaterial_On_Icon = BuildIcon("d_PhysicMaterial On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicMaterial On Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicMaterial_On_Icon => _d_PhysicMaterial_On_Icon;


        private static readonly UnityEditorIcon _d_PhysicsMaterial2D_Icon = BuildIcon("d_PhysicsMaterial2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicsMaterial2D Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicsMaterial2D_Icon => _d_PhysicsMaterial2D_Icon;


        private static readonly UnityEditorIcon _d_PhysicsMaterial2D_On_Icon = BuildIcon("d_PhysicsMaterial2D On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicsMaterial2D On Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicsMaterial2D_On_Icon => _d_PhysicsMaterial2D_On_Icon;


        private static readonly UnityEditorIcon _d_PlatformEffector2D_Icon = BuildIcon("d_PlatformEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlatformEffector2D Icon" icon.</summary>
        public static UnityEditorIcon d_PlatformEffector2D_Icon => _d_PlatformEffector2D_Icon;


        private static readonly UnityEditorIcon _d_PointEffector2D_Icon = BuildIcon("d_PointEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PointEffector2D Icon" icon.</summary>
        public static UnityEditorIcon d_PointEffector2D_Icon => _d_PointEffector2D_Icon;


        private static readonly UnityEditorIcon _d_PolygonCollider2D_Icon = BuildIcon("d_PolygonCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PolygonCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_PolygonCollider2D_Icon => _d_PolygonCollider2D_Icon;


        private static readonly UnityEditorIcon _d_ProceduralMaterial_Icon = BuildIcon("d_ProceduralMaterial Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ProceduralMaterial Icon" icon.</summary>
        public static UnityEditorIcon d_ProceduralMaterial_Icon => _d_ProceduralMaterial_Icon;


        private static readonly UnityEditorIcon _d_Projector_Icon = BuildIcon("d_Projector Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Projector Icon" icon.</summary>
        public static UnityEditorIcon d_Projector_Icon => _d_Projector_Icon;


        private static readonly UnityEditorIcon _d_RayTracingShader_Icon = BuildIcon("d_RayTracingShader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RayTracingShader Icon" icon.</summary>
        public static UnityEditorIcon d_RayTracingShader_Icon => _d_RayTracingShader_Icon;


        private static readonly UnityEditorIcon _d_RectTransform_Icon = BuildIcon("d_RectTransform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectTransform Icon" icon.</summary>
        public static UnityEditorIcon d_RectTransform_Icon => _d_RectTransform_Icon;


        private static readonly UnityEditorIcon _d_ReflectionProbe_Icon = BuildIcon("d_ReflectionProbe Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ReflectionProbe Icon" icon.</summary>
        public static UnityEditorIcon d_ReflectionProbe_Icon => _d_ReflectionProbe_Icon;


        private static readonly UnityEditorIcon _d_RelativeJoint2D_Icon = BuildIcon("d_RelativeJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RelativeJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_RelativeJoint2D_Icon => _d_RelativeJoint2D_Icon;


        private static readonly UnityEditorIcon _d_RenderTexture_Icon = BuildIcon("d_RenderTexture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RenderTexture Icon" icon.</summary>
        public static UnityEditorIcon d_RenderTexture_Icon => _d_RenderTexture_Icon;


        private static readonly UnityEditorIcon _d_RenderTexture_On_Icon = BuildIcon("d_RenderTexture On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RenderTexture On Icon" icon.</summary>
        public static UnityEditorIcon d_RenderTexture_On_Icon => _d_RenderTexture_On_Icon;


        private static readonly UnityEditorIcon _d_Rigidbody_Icon = BuildIcon("d_Rigidbody Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Rigidbody Icon" icon.</summary>
        public static UnityEditorIcon d_Rigidbody_Icon => _d_Rigidbody_Icon;


        private static readonly UnityEditorIcon _d_Rigidbody2D_Icon = BuildIcon("d_Rigidbody2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Rigidbody2D Icon" icon.</summary>
        public static UnityEditorIcon d_Rigidbody2D_Icon => _d_Rigidbody2D_Icon;


        private static readonly UnityEditorIcon _d_ScriptableObject_Icon = BuildIcon("d_ScriptableObject Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScriptableObject Icon" icon.</summary>
        public static UnityEditorIcon d_ScriptableObject_Icon => _d_ScriptableObject_Icon;


        private static readonly UnityEditorIcon _d_ScriptableObject_On_Icon = BuildIcon("d_ScriptableObject On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScriptableObject On Icon" icon.</summary>
        public static UnityEditorIcon d_ScriptableObject_On_Icon => _d_ScriptableObject_On_Icon;


        private static readonly UnityEditorIcon _d_Shader_Icon = BuildIcon("d_Shader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Shader Icon" icon.</summary>
        public static UnityEditorIcon d_Shader_Icon => _d_Shader_Icon;


        private static readonly UnityEditorIcon _d_ShaderVariantCollection_Icon = BuildIcon("d_ShaderVariantCollection Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ShaderVariantCollection Icon" icon.</summary>
        public static UnityEditorIcon d_ShaderVariantCollection_Icon => _d_ShaderVariantCollection_Icon;


        private static readonly UnityEditorIcon _d_SkinnedMeshRenderer_Icon = BuildIcon("d_SkinnedMeshRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SkinnedMeshRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_SkinnedMeshRenderer_Icon => _d_SkinnedMeshRenderer_Icon;


        private static readonly UnityEditorIcon _d_Skybox_Icon = BuildIcon("d_Skybox Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Skybox Icon" icon.</summary>
        public static UnityEditorIcon d_Skybox_Icon => _d_Skybox_Icon;


        private static readonly UnityEditorIcon _d_SliderJoint2D_Icon = BuildIcon("d_SliderJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SliderJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_SliderJoint2D_Icon => _d_SliderJoint2D_Icon;


        private static readonly UnityEditorIcon _d_SphereCollider_Icon = BuildIcon("d_SphereCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SphereCollider Icon" icon.</summary>
        public static UnityEditorIcon d_SphereCollider_Icon => _d_SphereCollider_Icon;


        private static readonly UnityEditorIcon _d_SpringJoint_Icon = BuildIcon("d_SpringJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpringJoint Icon" icon.</summary>
        public static UnityEditorIcon d_SpringJoint_Icon => _d_SpringJoint_Icon;


        private static readonly UnityEditorIcon _d_SpringJoint2D_Icon = BuildIcon("d_SpringJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpringJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_SpringJoint2D_Icon => _d_SpringJoint2D_Icon;


        private static readonly UnityEditorIcon _d_Sprite_Icon = BuildIcon("d_Sprite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Sprite Icon" icon.</summary>
        public static UnityEditorIcon d_Sprite_Icon => _d_Sprite_Icon;


        private static readonly UnityEditorIcon _d_SpriteMask_Icon = BuildIcon("d_SpriteMask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteMask Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteMask_Icon => _d_SpriteMask_Icon;


        private static readonly UnityEditorIcon _d_SpriteRenderer_Icon = BuildIcon("d_SpriteRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteRenderer_Icon => _d_SpriteRenderer_Icon;


        private static readonly UnityEditorIcon _d_StreamingController_Icon = BuildIcon("d_StreamingController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StreamingController Icon" icon.</summary>
        public static UnityEditorIcon d_StreamingController_Icon => _d_StreamingController_Icon;


        private static readonly UnityEditorIcon _d_SurfaceEffector2D_Icon = BuildIcon("d_SurfaceEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SurfaceEffector2D Icon" icon.</summary>
        public static UnityEditorIcon d_SurfaceEffector2D_Icon => _d_SurfaceEffector2D_Icon;


        private static readonly UnityEditorIcon _d_TargetJoint2D_Icon = BuildIcon("d_TargetJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TargetJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_TargetJoint2D_Icon => _d_TargetJoint2D_Icon;


        private static readonly UnityEditorIcon _d_Terrain_Icon = BuildIcon("d_Terrain Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Terrain Icon" icon.</summary>
        public static UnityEditorIcon d_Terrain_Icon => _d_Terrain_Icon;


        private static readonly UnityEditorIcon _d_TerrainCollider_Icon = BuildIcon("d_TerrainCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainCollider Icon" icon.</summary>
        public static UnityEditorIcon d_TerrainCollider_Icon => _d_TerrainCollider_Icon;


        private static readonly UnityEditorIcon _d_TerrainData_Icon = BuildIcon("d_TerrainData Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TerrainData Icon" icon.</summary>
        public static UnityEditorIcon d_TerrainData_Icon => _d_TerrainData_Icon;


        private static readonly UnityEditorIcon _d_TextAsset_Icon = BuildIcon("d_TextAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TextAsset Icon" icon.</summary>
        public static UnityEditorIcon d_TextAsset_Icon => _d_TextAsset_Icon;


        private static readonly UnityEditorIcon _d_Texture_Icon = BuildIcon("d_Texture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Texture Icon" icon.</summary>
        public static UnityEditorIcon d_Texture_Icon => _d_Texture_Icon;


        private static readonly UnityEditorIcon _d_Texture2D_Icon = BuildIcon("d_Texture2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Texture2D Icon" icon.</summary>
        public static UnityEditorIcon d_Texture2D_Icon => _d_Texture2D_Icon;


        private static readonly UnityEditorIcon _d_TrailRenderer_Icon = BuildIcon("d_TrailRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TrailRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_TrailRenderer_Icon => _d_TrailRenderer_Icon;


        private static readonly UnityEditorIcon _d_Transform_Icon = BuildIcon("d_Transform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Transform Icon" icon.</summary>
        public static UnityEditorIcon d_Transform_Icon => _d_Transform_Icon;


        private static readonly UnityEditorIcon _d_WheelCollider_Icon = BuildIcon("d_WheelCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WheelCollider Icon" icon.</summary>
        public static UnityEditorIcon d_WheelCollider_Icon => _d_WheelCollider_Icon;


        private static readonly UnityEditorIcon _d_WheelJoint2D_Icon = BuildIcon("d_WheelJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WheelJoint2D Icon" icon.</summary>
        public static UnityEditorIcon d_WheelJoint2D_Icon => _d_WheelJoint2D_Icon;


        private static readonly UnityEditorIcon _d_WindZone_Icon = BuildIcon("d_WindZone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_WindZone Icon" icon.</summary>
        public static UnityEditorIcon d_WindZone_Icon => _d_WindZone_Icon;


        private static readonly UnityEditorIcon _DistanceJoint2D_Icon = BuildIcon("DistanceJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DistanceJoint2D Icon" icon.</summary>
        public static UnityEditorIcon DistanceJoint2D_Icon => _DistanceJoint2D_Icon;


        private static readonly UnityEditorIcon _EdgeCollider2D_Icon = BuildIcon("EdgeCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EdgeCollider2D Icon" icon.</summary>
        public static UnityEditorIcon EdgeCollider2D_Icon => _EdgeCollider2D_Icon;


        private static readonly UnityEditorIcon _d_EventSystem_Icon = BuildIcon("d_EventSystem Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_EventSystem Icon" icon.</summary>
        public static UnityEditorIcon d_EventSystem_Icon => _d_EventSystem_Icon;


        private static readonly UnityEditorIcon _d_EventTrigger_Icon = BuildIcon("d_EventTrigger Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_EventTrigger Icon" icon.</summary>
        public static UnityEditorIcon d_EventTrigger_Icon => _d_EventTrigger_Icon;


        private static readonly UnityEditorIcon _d_HoloLensInputModule_Icon = BuildIcon("d_HoloLensInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_HoloLensInputModule Icon" icon.</summary>
        public static UnityEditorIcon d_HoloLensInputModule_Icon => _d_HoloLensInputModule_Icon;


        private static readonly UnityEditorIcon _d_Physics2DRaycaster_Icon = BuildIcon("d_Physics2DRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Physics2DRaycaster Icon" icon.</summary>
        public static UnityEditorIcon d_Physics2DRaycaster_Icon => _d_Physics2DRaycaster_Icon;


        private static readonly UnityEditorIcon _d_PhysicsRaycaster_Icon = BuildIcon("d_PhysicsRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicsRaycaster Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicsRaycaster_Icon => _d_PhysicsRaycaster_Icon;


        private static readonly UnityEditorIcon _d_StandaloneInputModule_Icon = BuildIcon("d_StandaloneInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StandaloneInputModule Icon" icon.</summary>
        public static UnityEditorIcon d_StandaloneInputModule_Icon => _d_StandaloneInputModule_Icon;


        private static readonly UnityEditorIcon _d_TouchInputModule_Icon = BuildIcon("d_TouchInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TouchInputModule Icon" icon.</summary>
        public static UnityEditorIcon d_TouchInputModule_Icon => _d_TouchInputModule_Icon;


        private static readonly UnityEditorIcon _EventSystem_Icon = BuildIcon("EventSystem Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EventSystem Icon" icon.</summary>
        public static UnityEditorIcon EventSystem_Icon => _EventSystem_Icon;


        private static readonly UnityEditorIcon _EventTrigger_Icon = BuildIcon("EventTrigger Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "EventTrigger Icon" icon.</summary>
        public static UnityEditorIcon EventTrigger_Icon => _EventTrigger_Icon;


        private static readonly UnityEditorIcon _HoloLensInputModule_Icon = BuildIcon("HoloLensInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HoloLensInputModule Icon" icon.</summary>
        public static UnityEditorIcon HoloLensInputModule_Icon => _HoloLensInputModule_Icon;


        private static readonly UnityEditorIcon _Physics2DRaycaster_Icon = BuildIcon("Physics2DRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Physics2DRaycaster Icon" icon.</summary>
        public static UnityEditorIcon Physics2DRaycaster_Icon => _Physics2DRaycaster_Icon;


        private static readonly UnityEditorIcon _PhysicsRaycaster_Icon = BuildIcon("PhysicsRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PhysicsRaycaster Icon" icon.</summary>
        public static UnityEditorIcon PhysicsRaycaster_Icon => _PhysicsRaycaster_Icon;


        private static readonly UnityEditorIcon _StandaloneInputModule_Icon = BuildIcon("StandaloneInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StandaloneInputModule Icon" icon.</summary>
        public static UnityEditorIcon StandaloneInputModule_Icon => _StandaloneInputModule_Icon;


        private static readonly UnityEditorIcon _TouchInputModule_Icon = BuildIcon("TouchInputModule Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TouchInputModule Icon" icon.</summary>
        public static UnityEditorIcon TouchInputModule_Icon => _TouchInputModule_Icon;


        private static readonly UnityEditorIcon _d_RaytracingShader_Icon = BuildIcon("d_RaytracingShader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RaytracingShader Icon" icon.</summary>
        public static UnityEditorIcon d_RaytracingShader_Icon => _d_RaytracingShader_Icon;


        private static readonly UnityEditorIcon _RayTracingShader_Icon = BuildIcon("RayTracingShader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RayTracingShader Icon" icon.</summary>
        public static UnityEditorIcon RayTracingShader_Icon => _RayTracingShader_Icon;


        private static readonly UnityEditorIcon _FixedJoint_Icon = BuildIcon("FixedJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FixedJoint Icon" icon.</summary>
        public static UnityEditorIcon FixedJoint_Icon => _FixedJoint_Icon;


        private static readonly UnityEditorIcon _FixedJoint2D_Icon = BuildIcon("FixedJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FixedJoint2D Icon" icon.</summary>
        public static UnityEditorIcon FixedJoint2D_Icon => _FixedJoint2D_Icon;


        private static readonly UnityEditorIcon _Flare_Icon = BuildIcon("Flare Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Flare Icon" icon.</summary>
        public static UnityEditorIcon Flare_Icon => _Flare_Icon;


        private static readonly UnityEditorIcon _Flare_On_Icon = BuildIcon("Flare On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Flare On Icon" icon.</summary>
        public static UnityEditorIcon Flare_On_Icon => _Flare_On_Icon;


        private static readonly UnityEditorIcon _FlareLayer_Icon = BuildIcon("FlareLayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FlareLayer Icon" icon.</summary>
        public static UnityEditorIcon FlareLayer_Icon => _FlareLayer_Icon;


        private static readonly UnityEditorIcon _Font_Icon = BuildIcon("Font Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Font Icon" icon.</summary>
        public static UnityEditorIcon Font_Icon => _Font_Icon;


        private static readonly UnityEditorIcon _Font_On_Icon = BuildIcon("Font On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Font On Icon" icon.</summary>
        public static UnityEditorIcon Font_On_Icon => _Font_On_Icon;


        private static readonly UnityEditorIcon _FrictionJoint2D_Icon = BuildIcon("FrictionJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FrictionJoint2D Icon" icon.</summary>
        public static UnityEditorIcon FrictionJoint2D_Icon => _FrictionJoint2D_Icon;


        private static readonly UnityEditorIcon _GameObject_Icon = BuildIcon("GameObject Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GameObject Icon" icon.</summary>
        public static UnityEditorIcon GameObject_Icon => _GameObject_Icon;


        private static readonly UnityEditorIcon _GameObject_On_Icon = BuildIcon("GameObject On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GameObject On Icon" icon.</summary>
        public static UnityEditorIcon GameObject_On_Icon => _GameObject_On_Icon;


        private static readonly UnityEditorIcon _Grid_Icon = BuildIcon("Grid Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Grid Icon" icon.</summary>
        public static UnityEditorIcon Grid_Icon => _Grid_Icon;


        private static readonly UnityEditorIcon _GUILayer_Icon = BuildIcon("GUILayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GUILayer Icon" icon.</summary>
        public static UnityEditorIcon GUILayer_Icon => _GUILayer_Icon;


        private static readonly UnityEditorIcon _GUISkin_Icon = BuildIcon("GUISkin Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GUISkin Icon" icon.</summary>
        public static UnityEditorIcon GUISkin_Icon => _GUISkin_Icon;


        private static readonly UnityEditorIcon _GUISkin_On_Icon = BuildIcon("GUISkin On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GUISkin On Icon" icon.</summary>
        public static UnityEditorIcon GUISkin_On_Icon => _GUISkin_On_Icon;


        private static readonly UnityEditorIcon _GUIText_Icon = BuildIcon("GUIText Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GUIText Icon" icon.</summary>
        public static UnityEditorIcon GUIText_Icon => _GUIText_Icon;


        private static readonly UnityEditorIcon _GUITexture_Icon = BuildIcon("GUITexture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GUITexture Icon" icon.</summary>
        public static UnityEditorIcon GUITexture_Icon => _GUITexture_Icon;


        private static readonly UnityEditorIcon _Halo_Icon = BuildIcon("Halo Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Halo Icon" icon.</summary>
        public static UnityEditorIcon Halo_Icon => _Halo_Icon;


        private static readonly UnityEditorIcon _HingeJoint_Icon = BuildIcon("HingeJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HingeJoint Icon" icon.</summary>
        public static UnityEditorIcon HingeJoint_Icon => _HingeJoint_Icon;


        private static readonly UnityEditorIcon _HingeJoint2D_Icon = BuildIcon("HingeJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "HingeJoint2D Icon" icon.</summary>
        public static UnityEditorIcon HingeJoint2D_Icon => _HingeJoint2D_Icon;


        private static readonly UnityEditorIcon _LensFlare_Icon = BuildIcon("LensFlare Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LensFlare Icon" icon.</summary>
        public static UnityEditorIcon LensFlare_Icon => _LensFlare_Icon;


        private static readonly UnityEditorIcon _Light_Icon = BuildIcon("Light Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Light Icon" icon.</summary>
        public static UnityEditorIcon Light_Icon => _Light_Icon;


        private static readonly UnityEditorIcon _LightingSettings_Icon = BuildIcon("LightingSettings Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightingSettings Icon" icon.</summary>
        public static UnityEditorIcon LightingSettings_Icon => _LightingSettings_Icon;


        private static readonly UnityEditorIcon _LightProbeGroup_Icon = BuildIcon("LightProbeGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightProbeGroup Icon" icon.</summary>
        public static UnityEditorIcon LightProbeGroup_Icon => _LightProbeGroup_Icon;


        private static readonly UnityEditorIcon _LightProbeProxyVolume_Icon = BuildIcon("LightProbeProxyVolume Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightProbeProxyVolume Icon" icon.</summary>
        public static UnityEditorIcon LightProbeProxyVolume_Icon => _LightProbeProxyVolume_Icon;


        private static readonly UnityEditorIcon _LightProbes_Icon = BuildIcon("LightProbes Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LightProbes Icon" icon.</summary>
        public static UnityEditorIcon LightProbes_Icon => _LightProbes_Icon;


        private static readonly UnityEditorIcon _LineRenderer_Icon = BuildIcon("LineRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LineRenderer Icon" icon.</summary>
        public static UnityEditorIcon LineRenderer_Icon => _LineRenderer_Icon;


        private static readonly UnityEditorIcon _LODGroup_Icon = BuildIcon("LODGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LODGroup Icon" icon.</summary>
        public static UnityEditorIcon LODGroup_Icon => _LODGroup_Icon;


        private static readonly UnityEditorIcon _Material_Icon = BuildIcon("Material Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Material Icon" icon.</summary>
        public static UnityEditorIcon Material_Icon => _Material_Icon;


        private static readonly UnityEditorIcon _Material_On_Icon = BuildIcon("Material On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Material On Icon" icon.</summary>
        public static UnityEditorIcon Material_On_Icon => _Material_On_Icon;


        private static readonly UnityEditorIcon _Mesh_Icon = BuildIcon("Mesh Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Mesh Icon" icon.</summary>
        public static UnityEditorIcon Mesh_Icon => _Mesh_Icon;


        private static readonly UnityEditorIcon _MeshCollider_Icon = BuildIcon("MeshCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MeshCollider Icon" icon.</summary>
        public static UnityEditorIcon MeshCollider_Icon => _MeshCollider_Icon;


        private static readonly UnityEditorIcon _MeshFilter_Icon = BuildIcon("MeshFilter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MeshFilter Icon" icon.</summary>
        public static UnityEditorIcon MeshFilter_Icon => _MeshFilter_Icon;


        private static readonly UnityEditorIcon _MeshRenderer_Icon = BuildIcon("MeshRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MeshRenderer Icon" icon.</summary>
        public static UnityEditorIcon MeshRenderer_Icon => _MeshRenderer_Icon;


        private static readonly UnityEditorIcon _Motion_Icon = BuildIcon("Motion Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Motion Icon" icon.</summary>
        public static UnityEditorIcon Motion_Icon => _Motion_Icon;


        private static readonly UnityEditorIcon _MovieTexture_Icon = BuildIcon("MovieTexture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "MovieTexture Icon" icon.</summary>
        public static UnityEditorIcon MovieTexture_Icon => _MovieTexture_Icon;


        private static readonly UnityEditorIcon _d_NetworkAnimator_Icon = BuildIcon("d_NetworkAnimator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkAnimator Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkAnimator_Icon => _d_NetworkAnimator_Icon;


        private static readonly UnityEditorIcon _d_NetworkDiscovery_Icon = BuildIcon("d_NetworkDiscovery Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkDiscovery Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkDiscovery_Icon => _d_NetworkDiscovery_Icon;


        private static readonly UnityEditorIcon _d_NetworkIdentity_Icon = BuildIcon("d_NetworkIdentity Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkIdentity Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkIdentity_Icon => _d_NetworkIdentity_Icon;


        private static readonly UnityEditorIcon _d_NetworkLobbyManager_Icon = BuildIcon("d_NetworkLobbyManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkLobbyManager Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkLobbyManager_Icon => _d_NetworkLobbyManager_Icon;


        private static readonly UnityEditorIcon _d_NetworkLobbyPlayer_Icon = BuildIcon("d_NetworkLobbyPlayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkLobbyPlayer Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkLobbyPlayer_Icon => _d_NetworkLobbyPlayer_Icon;


        private static readonly UnityEditorIcon _d_NetworkManager_Icon = BuildIcon("d_NetworkManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkManager Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkManager_Icon => _d_NetworkManager_Icon;


        private static readonly UnityEditorIcon _d_NetworkManagerHUD_Icon = BuildIcon("d_NetworkManagerHUD Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkManagerHUD Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkManagerHUD_Icon => _d_NetworkManagerHUD_Icon;


        private static readonly UnityEditorIcon _d_NetworkMigrationManager_Icon = BuildIcon("d_NetworkMigrationManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkMigrationManager Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkMigrationManager_Icon => _d_NetworkMigrationManager_Icon;


        private static readonly UnityEditorIcon _d_NetworkProximityChecker_Icon = BuildIcon("d_NetworkProximityChecker Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkProximityChecker Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkProximityChecker_Icon => _d_NetworkProximityChecker_Icon;


        private static readonly UnityEditorIcon _d_NetworkStartPosition_Icon = BuildIcon("d_NetworkStartPosition Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkStartPosition Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkStartPosition_Icon => _d_NetworkStartPosition_Icon;


        private static readonly UnityEditorIcon _d_NetworkTransform_Icon = BuildIcon("d_NetworkTransform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkTransform Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkTransform_Icon => _d_NetworkTransform_Icon;


        private static readonly UnityEditorIcon _d_NetworkTransformChild_Icon = BuildIcon("d_NetworkTransformChild Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkTransformChild Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkTransformChild_Icon => _d_NetworkTransformChild_Icon;


        private static readonly UnityEditorIcon _d_NetworkTransformVisualizer_Icon = BuildIcon("d_NetworkTransformVisualizer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_NetworkTransformVisualizer Icon" icon.</summary>
        public static UnityEditorIcon d_NetworkTransformVisualizer_Icon => _d_NetworkTransformVisualizer_Icon;


        private static readonly UnityEditorIcon _NetworkAnimator_Icon = BuildIcon("NetworkAnimator Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkAnimator Icon" icon.</summary>
        public static UnityEditorIcon NetworkAnimator_Icon => _NetworkAnimator_Icon;


        private static readonly UnityEditorIcon _NetworkDiscovery_Icon = BuildIcon("NetworkDiscovery Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkDiscovery Icon" icon.</summary>
        public static UnityEditorIcon NetworkDiscovery_Icon => _NetworkDiscovery_Icon;


        private static readonly UnityEditorIcon _NetworkIdentity_Icon = BuildIcon("NetworkIdentity Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkIdentity Icon" icon.</summary>
        public static UnityEditorIcon NetworkIdentity_Icon => _NetworkIdentity_Icon;


        private static readonly UnityEditorIcon _NetworkLobbyManager_Icon = BuildIcon("NetworkLobbyManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkLobbyManager Icon" icon.</summary>
        public static UnityEditorIcon NetworkLobbyManager_Icon => _NetworkLobbyManager_Icon;


        private static readonly UnityEditorIcon _NetworkLobbyPlayer_Icon = BuildIcon("NetworkLobbyPlayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkLobbyPlayer Icon" icon.</summary>
        public static UnityEditorIcon NetworkLobbyPlayer_Icon => _NetworkLobbyPlayer_Icon;


        private static readonly UnityEditorIcon _NetworkManager_Icon = BuildIcon("NetworkManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkManager Icon" icon.</summary>
        public static UnityEditorIcon NetworkManager_Icon => _NetworkManager_Icon;


        private static readonly UnityEditorIcon _NetworkManagerHUD_Icon = BuildIcon("NetworkManagerHUD Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkManagerHUD Icon" icon.</summary>
        public static UnityEditorIcon NetworkManagerHUD_Icon => _NetworkManagerHUD_Icon;


        private static readonly UnityEditorIcon _NetworkMigrationManager_Icon = BuildIcon("NetworkMigrationManager Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkMigrationManager Icon" icon.</summary>
        public static UnityEditorIcon NetworkMigrationManager_Icon => _NetworkMigrationManager_Icon;


        private static readonly UnityEditorIcon _NetworkProximityChecker_Icon = BuildIcon("NetworkProximityChecker Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkProximityChecker Icon" icon.</summary>
        public static UnityEditorIcon NetworkProximityChecker_Icon => _NetworkProximityChecker_Icon;


        private static readonly UnityEditorIcon _NetworkStartPosition_Icon = BuildIcon("NetworkStartPosition Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkStartPosition Icon" icon.</summary>
        public static UnityEditorIcon NetworkStartPosition_Icon => _NetworkStartPosition_Icon;


        private static readonly UnityEditorIcon _NetworkTransform_Icon = BuildIcon("NetworkTransform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkTransform Icon" icon.</summary>
        public static UnityEditorIcon NetworkTransform_Icon => _NetworkTransform_Icon;


        private static readonly UnityEditorIcon _NetworkTransformChild_Icon = BuildIcon("NetworkTransformChild Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkTransformChild Icon" icon.</summary>
        public static UnityEditorIcon NetworkTransformChild_Icon => _NetworkTransformChild_Icon;


        private static readonly UnityEditorIcon _NetworkTransformVisualizer_Icon = BuildIcon("NetworkTransformVisualizer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkTransformVisualizer Icon" icon.</summary>
        public static UnityEditorIcon NetworkTransformVisualizer_Icon => _NetworkTransformVisualizer_Icon;


        private static readonly UnityEditorIcon _NetworkView_Icon = BuildIcon("NetworkView Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "NetworkView Icon" icon.</summary>
        public static UnityEditorIcon NetworkView_Icon => _NetworkView_Icon;


        private static readonly UnityEditorIcon _OcclusionArea_Icon = BuildIcon("OcclusionArea Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "OcclusionArea Icon" icon.</summary>
        public static UnityEditorIcon OcclusionArea_Icon => _OcclusionArea_Icon;


        private static readonly UnityEditorIcon _OcclusionPortal_Icon = BuildIcon("OcclusionPortal Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "OcclusionPortal Icon" icon.</summary>
        public static UnityEditorIcon OcclusionPortal_Icon => _OcclusionPortal_Icon;


        private static readonly UnityEditorIcon _ParticleSystem_Icon = BuildIcon("ParticleSystem Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleSystem Icon" icon.</summary>
        public static UnityEditorIcon ParticleSystem_Icon => _ParticleSystem_Icon;


        private static readonly UnityEditorIcon _ParticleSystemForceField_Icon = BuildIcon("ParticleSystemForceField Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ParticleSystemForceField Icon" icon.</summary>
        public static UnityEditorIcon ParticleSystemForceField_Icon => _ParticleSystemForceField_Icon;


        private static readonly UnityEditorIcon _PhysicMaterial_Icon = BuildIcon("PhysicMaterial Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PhysicMaterial Icon" icon.</summary>
        public static UnityEditorIcon PhysicMaterial_Icon => _PhysicMaterial_Icon;


        private static readonly UnityEditorIcon _PhysicMaterial_On_Icon = BuildIcon("PhysicMaterial On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PhysicMaterial On Icon" icon.</summary>
        public static UnityEditorIcon PhysicMaterial_On_Icon => _PhysicMaterial_On_Icon;


        private static readonly UnityEditorIcon _PhysicsMaterial2D_Icon = BuildIcon("PhysicsMaterial2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PhysicsMaterial2D Icon" icon.</summary>
        public static UnityEditorIcon PhysicsMaterial2D_Icon => _PhysicsMaterial2D_Icon;


        private static readonly UnityEditorIcon _PhysicsMaterial2D_On_Icon = BuildIcon("PhysicsMaterial2D On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PhysicsMaterial2D On Icon" icon.</summary>
        public static UnityEditorIcon PhysicsMaterial2D_On_Icon => _PhysicsMaterial2D_On_Icon;


        private static readonly UnityEditorIcon _PlatformEffector2D_Icon = BuildIcon("PlatformEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlatformEffector2D Icon" icon.</summary>
        public static UnityEditorIcon PlatformEffector2D_Icon => _PlatformEffector2D_Icon;


        private static readonly UnityEditorIcon _d_PlayableDirector_Icon = BuildIcon("d_PlayableDirector Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PlayableDirector Icon" icon.</summary>
        public static UnityEditorIcon d_PlayableDirector_Icon => _d_PlayableDirector_Icon;


        private static readonly UnityEditorIcon _PlayableDirector_Icon = BuildIcon("PlayableDirector Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PlayableDirector Icon" icon.</summary>
        public static UnityEditorIcon PlayableDirector_Icon => _PlayableDirector_Icon;


        private static readonly UnityEditorIcon _PointEffector2D_Icon = BuildIcon("PointEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PointEffector2D Icon" icon.</summary>
        public static UnityEditorIcon PointEffector2D_Icon => _PointEffector2D_Icon;


        private static readonly UnityEditorIcon _PolygonCollider2D_Icon = BuildIcon("PolygonCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PolygonCollider2D Icon" icon.</summary>
        public static UnityEditorIcon PolygonCollider2D_Icon => _PolygonCollider2D_Icon;


        private static readonly UnityEditorIcon _ProceduralMaterial_Icon = BuildIcon("ProceduralMaterial Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ProceduralMaterial Icon" icon.</summary>
        public static UnityEditorIcon ProceduralMaterial_Icon => _ProceduralMaterial_Icon;


        private static readonly UnityEditorIcon _Projector_Icon = BuildIcon("Projector Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Projector Icon" icon.</summary>
        public static UnityEditorIcon Projector_Icon => _Projector_Icon;


        private static readonly UnityEditorIcon _RectTransform_Icon = BuildIcon("RectTransform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTransform Icon" icon.</summary>
        public static UnityEditorIcon RectTransform_Icon => _RectTransform_Icon;


        private static readonly UnityEditorIcon _ReflectionProbe_Icon = BuildIcon("ReflectionProbe Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ReflectionProbe Icon" icon.</summary>
        public static UnityEditorIcon ReflectionProbe_Icon => _ReflectionProbe_Icon;


        private static readonly UnityEditorIcon _RelativeJoint2D_Icon = BuildIcon("RelativeJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RelativeJoint2D Icon" icon.</summary>
        public static UnityEditorIcon RelativeJoint2D_Icon => _RelativeJoint2D_Icon;


        private static readonly UnityEditorIcon _d_SortingGroup_Icon = BuildIcon("d_SortingGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SortingGroup Icon" icon.</summary>
        public static UnityEditorIcon d_SortingGroup_Icon => _d_SortingGroup_Icon;


        private static readonly UnityEditorIcon _SortingGroup_Icon = BuildIcon("SortingGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SortingGroup Icon" icon.</summary>
        public static UnityEditorIcon SortingGroup_Icon => _SortingGroup_Icon;


        private static readonly UnityEditorIcon _RenderTexture_Icon = BuildIcon("RenderTexture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RenderTexture Icon" icon.</summary>
        public static UnityEditorIcon RenderTexture_Icon => _RenderTexture_Icon;


        private static readonly UnityEditorIcon _RenderTexture_On_Icon = BuildIcon("RenderTexture On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RenderTexture On Icon" icon.</summary>
        public static UnityEditorIcon RenderTexture_On_Icon => _RenderTexture_On_Icon;


        private static readonly UnityEditorIcon _Rigidbody_Icon = BuildIcon("Rigidbody Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Rigidbody Icon" icon.</summary>
        public static UnityEditorIcon Rigidbody_Icon => _Rigidbody_Icon;


        private static readonly UnityEditorIcon _Rigidbody2D_Icon = BuildIcon("Rigidbody2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Rigidbody2D Icon" icon.</summary>
        public static UnityEditorIcon Rigidbody2D_Icon => _Rigidbody2D_Icon;


        private static readonly UnityEditorIcon _ScriptableObject_Icon = BuildIcon("ScriptableObject Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScriptableObject Icon" icon.</summary>
        public static UnityEditorIcon ScriptableObject_Icon => _ScriptableObject_Icon;


        private static readonly UnityEditorIcon _ScriptableObject_On_Icon = BuildIcon("ScriptableObject On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScriptableObject On Icon" icon.</summary>
        public static UnityEditorIcon ScriptableObject_On_Icon => _ScriptableObject_On_Icon;


        private static readonly UnityEditorIcon _Shader_Icon = BuildIcon("Shader Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Shader Icon" icon.</summary>
        public static UnityEditorIcon Shader_Icon => _Shader_Icon;


        private static readonly UnityEditorIcon _ShaderVariantCollection_Icon = BuildIcon("ShaderVariantCollection Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ShaderVariantCollection Icon" icon.</summary>
        public static UnityEditorIcon ShaderVariantCollection_Icon => _ShaderVariantCollection_Icon;


        private static readonly UnityEditorIcon _SkinnedMeshRenderer_Icon = BuildIcon("SkinnedMeshRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SkinnedMeshRenderer Icon" icon.</summary>
        public static UnityEditorIcon SkinnedMeshRenderer_Icon => _SkinnedMeshRenderer_Icon;


        private static readonly UnityEditorIcon _Skybox_Icon = BuildIcon("Skybox Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Skybox Icon" icon.</summary>
        public static UnityEditorIcon Skybox_Icon => _Skybox_Icon;


        private static readonly UnityEditorIcon _SliderJoint2D_Icon = BuildIcon("SliderJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SliderJoint2D Icon" icon.</summary>
        public static UnityEditorIcon SliderJoint2D_Icon => _SliderJoint2D_Icon;


        private static readonly UnityEditorIcon _TrackedPoseDriver_Icon = BuildIcon("TrackedPoseDriver Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TrackedPoseDriver Icon" icon.</summary>
        public static UnityEditorIcon TrackedPoseDriver_Icon => _TrackedPoseDriver_Icon;


        private static readonly UnityEditorIcon _SphereCollider_Icon = BuildIcon("SphereCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SphereCollider Icon" icon.</summary>
        public static UnityEditorIcon SphereCollider_Icon => _SphereCollider_Icon;


        private static readonly UnityEditorIcon _SpringJoint_Icon = BuildIcon("SpringJoint Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpringJoint Icon" icon.</summary>
        public static UnityEditorIcon SpringJoint_Icon => _SpringJoint_Icon;


        private static readonly UnityEditorIcon _SpringJoint2D_Icon = BuildIcon("SpringJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpringJoint2D Icon" icon.</summary>
        public static UnityEditorIcon SpringJoint2D_Icon => _SpringJoint2D_Icon;


        private static readonly UnityEditorIcon _Sprite_Icon = BuildIcon("Sprite Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Sprite Icon" icon.</summary>
        public static UnityEditorIcon Sprite_Icon => _Sprite_Icon;


        private static readonly UnityEditorIcon _SpriteMask_Icon = BuildIcon("SpriteMask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteMask Icon" icon.</summary>
        public static UnityEditorIcon SpriteMask_Icon => _SpriteMask_Icon;


        private static readonly UnityEditorIcon _SpriteRenderer_Icon = BuildIcon("SpriteRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteRenderer Icon" icon.</summary>
        public static UnityEditorIcon SpriteRenderer_Icon => _SpriteRenderer_Icon;


        private static readonly UnityEditorIcon _StreamingController_Icon = BuildIcon("StreamingController Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StreamingController Icon" icon.</summary>
        public static UnityEditorIcon StreamingController_Icon => _StreamingController_Icon;


        private static readonly UnityEditorIcon _SurfaceEffector2D_Icon = BuildIcon("SurfaceEffector2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SurfaceEffector2D Icon" icon.</summary>
        public static UnityEditorIcon SurfaceEffector2D_Icon => _SurfaceEffector2D_Icon;


        private static readonly UnityEditorIcon _TargetJoint2D_Icon = BuildIcon("TargetJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TargetJoint2D Icon" icon.</summary>
        public static UnityEditorIcon TargetJoint2D_Icon => _TargetJoint2D_Icon;


        private static readonly UnityEditorIcon _Terrain_Icon = BuildIcon("Terrain Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Terrain Icon" icon.</summary>
        public static UnityEditorIcon Terrain_Icon => _Terrain_Icon;


        private static readonly UnityEditorIcon _TerrainCollider_Icon = BuildIcon("TerrainCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainCollider Icon" icon.</summary>
        public static UnityEditorIcon TerrainCollider_Icon => _TerrainCollider_Icon;


        private static readonly UnityEditorIcon _TerrainData_Icon = BuildIcon("TerrainData Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainData Icon" icon.</summary>
        public static UnityEditorIcon TerrainData_Icon => _TerrainData_Icon;


        private static readonly UnityEditorIcon _TextAsset_Icon = BuildIcon("TextAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TextAsset Icon" icon.</summary>
        public static UnityEditorIcon TextAsset_Icon => _TextAsset_Icon;


        private static readonly UnityEditorIcon _TextMesh_Icon = BuildIcon("TextMesh Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TextMesh Icon" icon.</summary>
        public static UnityEditorIcon TextMesh_Icon => _TextMesh_Icon;


        private static readonly UnityEditorIcon _Texture_Icon = BuildIcon("Texture Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Texture Icon" icon.</summary>
        public static UnityEditorIcon Texture_Icon => _Texture_Icon;


        private static readonly UnityEditorIcon _Texture2D_Icon = BuildIcon("Texture2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Texture2D Icon" icon.</summary>
        public static UnityEditorIcon Texture2D_Icon => _Texture2D_Icon;


        private static readonly UnityEditorIcon _d_Tile_Icon = BuildIcon("d_Tile Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Tile Icon" icon.</summary>
        public static UnityEditorIcon d_Tile_Icon => _d_Tile_Icon;


        private static readonly UnityEditorIcon _d_Tilemap_Icon = BuildIcon("d_Tilemap Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Tilemap Icon" icon.</summary>
        public static UnityEditorIcon d_Tilemap_Icon => _d_Tilemap_Icon;


        private static readonly UnityEditorIcon _d_TilemapCollider2D_Icon = BuildIcon("d_TilemapCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TilemapCollider2D Icon" icon.</summary>
        public static UnityEditorIcon d_TilemapCollider2D_Icon => _d_TilemapCollider2D_Icon;


        private static readonly UnityEditorIcon _d_TilemapRenderer_Icon = BuildIcon("d_TilemapRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TilemapRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_TilemapRenderer_Icon => _d_TilemapRenderer_Icon;


        private static readonly UnityEditorIcon _Tile_Icon = BuildIcon("Tile Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Tile Icon" icon.</summary>
        public static UnityEditorIcon Tile_Icon => _Tile_Icon;


        private static readonly UnityEditorIcon _Tilemap_Icon = BuildIcon("Tilemap Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Tilemap Icon" icon.</summary>
        public static UnityEditorIcon Tilemap_Icon => _Tilemap_Icon;


        private static readonly UnityEditorIcon _TilemapCollider2D_Icon = BuildIcon("TilemapCollider2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TilemapCollider2D Icon" icon.</summary>
        public static UnityEditorIcon TilemapCollider2D_Icon => _TilemapCollider2D_Icon;


        private static readonly UnityEditorIcon _TilemapRenderer_Icon = BuildIcon("TilemapRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TilemapRenderer Icon" icon.</summary>
        public static UnityEditorIcon TilemapRenderer_Icon => _TilemapRenderer_Icon;


        private static readonly UnityEditorIcon _d_SignalAsset_Icon = BuildIcon("d_SignalAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SignalAsset Icon" icon.</summary>
        public static UnityEditorIcon d_SignalAsset_Icon => _d_SignalAsset_Icon;


        private static readonly UnityEditorIcon _d_SignalEmitter_Icon = BuildIcon("d_SignalEmitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SignalEmitter Icon" icon.</summary>
        public static UnityEditorIcon d_SignalEmitter_Icon => _d_SignalEmitter_Icon;


        private static readonly UnityEditorIcon _d_SignalReceiver_Icon = BuildIcon("d_SignalReceiver Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SignalReceiver Icon" icon.</summary>
        public static UnityEditorIcon d_SignalReceiver_Icon => _d_SignalReceiver_Icon;


        private static readonly UnityEditorIcon _d_TimelineAsset_Icon = BuildIcon("d_TimelineAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TimelineAsset Icon" icon.</summary>
        public static UnityEditorIcon d_TimelineAsset_Icon => _d_TimelineAsset_Icon;


        private static readonly UnityEditorIcon _d_TimelineAsset_On_Icon = BuildIcon("d_TimelineAsset On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_TimelineAsset On Icon" icon.</summary>
        public static UnityEditorIcon d_TimelineAsset_On_Icon => _d_TimelineAsset_On_Icon;


        private static readonly UnityEditorIcon _SignalAsset_Icon = BuildIcon("SignalAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SignalAsset Icon" icon.</summary>
        public static UnityEditorIcon SignalAsset_Icon => _SignalAsset_Icon;


        private static readonly UnityEditorIcon _SignalEmitter_Icon = BuildIcon("SignalEmitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SignalEmitter Icon" icon.</summary>
        public static UnityEditorIcon SignalEmitter_Icon => _SignalEmitter_Icon;


        private static readonly UnityEditorIcon _SignalReceiver_Icon = BuildIcon("SignalReceiver Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SignalReceiver Icon" icon.</summary>
        public static UnityEditorIcon SignalReceiver_Icon => _SignalReceiver_Icon;


        private static readonly UnityEditorIcon _TimelineAsset_Icon = BuildIcon("TimelineAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TimelineAsset Icon" icon.</summary>
        public static UnityEditorIcon TimelineAsset_Icon => _TimelineAsset_Icon;


        private static readonly UnityEditorIcon _TimelineAsset_On_Icon = BuildIcon("TimelineAsset On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TimelineAsset On Icon" icon.</summary>
        public static UnityEditorIcon TimelineAsset_On_Icon => _TimelineAsset_On_Icon;


        private static readonly UnityEditorIcon _TrailRenderer_Icon = BuildIcon("TrailRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TrailRenderer Icon" icon.</summary>
        public static UnityEditorIcon TrailRenderer_Icon => _TrailRenderer_Icon;


        private static readonly UnityEditorIcon _Transform_Icon = BuildIcon("Transform Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Transform Icon" icon.</summary>
        public static UnityEditorIcon Transform_Icon => _Transform_Icon;


        private static readonly UnityEditorIcon _d_SpriteAtlas_Icon = BuildIcon("d_SpriteAtlas Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteAtlas Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteAtlas_Icon => _d_SpriteAtlas_Icon;


        private static readonly UnityEditorIcon _d_SpriteAtlas_On_Icon = BuildIcon("d_SpriteAtlas On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteAtlas On Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteAtlas_On_Icon => _d_SpriteAtlas_On_Icon;


        private static readonly UnityEditorIcon _d_SpriteShapeRenderer_Icon = BuildIcon("d_SpriteShapeRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpriteShapeRenderer Icon" icon.</summary>
        public static UnityEditorIcon d_SpriteShapeRenderer_Icon => _d_SpriteShapeRenderer_Icon;


        private static readonly UnityEditorIcon _SpriteAtlas_Icon = BuildIcon("SpriteAtlas Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteAtlas Icon" icon.</summary>
        public static UnityEditorIcon SpriteAtlas_Icon => _SpriteAtlas_Icon;


        private static readonly UnityEditorIcon _SpriteAtlas_On_Icon = BuildIcon("SpriteAtlas On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteAtlas On Icon" icon.</summary>
        public static UnityEditorIcon SpriteAtlas_On_Icon => _SpriteAtlas_On_Icon;


        private static readonly UnityEditorIcon _SpriteShapeRenderer_Icon = BuildIcon("SpriteShapeRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpriteShapeRenderer Icon" icon.</summary>
        public static UnityEditorIcon SpriteShapeRenderer_Icon => _SpriteShapeRenderer_Icon;


        private static readonly UnityEditorIcon _AspectRatioFitter_Icon = BuildIcon("AspectRatioFitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "AspectRatioFitter Icon" icon.</summary>
        public static UnityEditorIcon AspectRatioFitter_Icon => _AspectRatioFitter_Icon;


        private static readonly UnityEditorIcon _Button_Icon = BuildIcon("Button Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Button Icon" icon.</summary>
        public static UnityEditorIcon Button_Icon => _Button_Icon;


        private static readonly UnityEditorIcon _CanvasScaler_Icon = BuildIcon("CanvasScaler Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "CanvasScaler Icon" icon.</summary>
        public static UnityEditorIcon CanvasScaler_Icon => _CanvasScaler_Icon;


        private static readonly UnityEditorIcon _ContentSizeFitter_Icon = BuildIcon("ContentSizeFitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ContentSizeFitter Icon" icon.</summary>
        public static UnityEditorIcon ContentSizeFitter_Icon => _ContentSizeFitter_Icon;


        private static readonly UnityEditorIcon _d_AspectRatioFitter_Icon = BuildIcon("d_AspectRatioFitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_AspectRatioFitter Icon" icon.</summary>
        public static UnityEditorIcon d_AspectRatioFitter_Icon => _d_AspectRatioFitter_Icon;


        private static readonly UnityEditorIcon _d_Button_Icon = BuildIcon("d_Button Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Button Icon" icon.</summary>
        public static UnityEditorIcon d_Button_Icon => _d_Button_Icon;


        private static readonly UnityEditorIcon _d_CanvasScaler_Icon = BuildIcon("d_CanvasScaler Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_CanvasScaler Icon" icon.</summary>
        public static UnityEditorIcon d_CanvasScaler_Icon => _d_CanvasScaler_Icon;


        private static readonly UnityEditorIcon _d_ContentSizeFitter_Icon = BuildIcon("d_ContentSizeFitter Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ContentSizeFitter Icon" icon.</summary>
        public static UnityEditorIcon d_ContentSizeFitter_Icon => _d_ContentSizeFitter_Icon;


        private static readonly UnityEditorIcon _d_Dropdown_Icon = BuildIcon("d_Dropdown Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Dropdown Icon" icon.</summary>
        public static UnityEditorIcon d_Dropdown_Icon => _d_Dropdown_Icon;


        private static readonly UnityEditorIcon _d_FreeformLayoutGroup_Icon = BuildIcon("d_FreeformLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_FreeformLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon d_FreeformLayoutGroup_Icon => _d_FreeformLayoutGroup_Icon;


        private static readonly UnityEditorIcon _d_GraphicRaycaster_Icon = BuildIcon("d_GraphicRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GraphicRaycaster Icon" icon.</summary>
        public static UnityEditorIcon d_GraphicRaycaster_Icon => _d_GraphicRaycaster_Icon;


        private static readonly UnityEditorIcon _d_Image_Icon = BuildIcon("d_Image Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Image Icon" icon.</summary>
        public static UnityEditorIcon d_Image_Icon => _d_Image_Icon;


        private static readonly UnityEditorIcon _d_InputField_Icon = BuildIcon("d_InputField Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_InputField Icon" icon.</summary>
        public static UnityEditorIcon d_InputField_Icon => _d_InputField_Icon;


        private static readonly UnityEditorIcon _d_LayoutElement_Icon = BuildIcon("d_LayoutElement Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_LayoutElement Icon" icon.</summary>
        public static UnityEditorIcon d_LayoutElement_Icon => _d_LayoutElement_Icon;


        private static readonly UnityEditorIcon _d_Mask_Icon = BuildIcon("d_Mask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Mask Icon" icon.</summary>
        public static UnityEditorIcon d_Mask_Icon => _d_Mask_Icon;


        private static readonly UnityEditorIcon _d_Outline_Icon = BuildIcon("d_Outline Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Outline Icon" icon.</summary>
        public static UnityEditorIcon d_Outline_Icon => _d_Outline_Icon;


        private static readonly UnityEditorIcon _d_PhysicalResolution_Icon = BuildIcon("d_PhysicalResolution Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PhysicalResolution Icon" icon.</summary>
        public static UnityEditorIcon d_PhysicalResolution_Icon => _d_PhysicalResolution_Icon;


        private static readonly UnityEditorIcon _d_PositionAsUV1_Icon = BuildIcon("d_PositionAsUV1 Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_PositionAsUV1 Icon" icon.</summary>
        public static UnityEditorIcon d_PositionAsUV1_Icon => _d_PositionAsUV1_Icon;


        private static readonly UnityEditorIcon _d_RawImage_Icon = BuildIcon("d_RawImage Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RawImage Icon" icon.</summary>
        public static UnityEditorIcon d_RawImage_Icon => _d_RawImage_Icon;


        private static readonly UnityEditorIcon _d_RectMask2D_Icon = BuildIcon("d_RectMask2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_RectMask2D Icon" icon.</summary>
        public static UnityEditorIcon d_RectMask2D_Icon => _d_RectMask2D_Icon;


        private static readonly UnityEditorIcon _d_Scrollbar_Icon = BuildIcon("d_Scrollbar Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Scrollbar Icon" icon.</summary>
        public static UnityEditorIcon d_Scrollbar_Icon => _d_Scrollbar_Icon;


        private static readonly UnityEditorIcon _d_ScrollRect_Icon = BuildIcon("d_ScrollRect Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScrollRect Icon" icon.</summary>
        public static UnityEditorIcon d_ScrollRect_Icon => _d_ScrollRect_Icon;


        private static readonly UnityEditorIcon _d_ScrollViewArea_Icon = BuildIcon("d_ScrollViewArea Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ScrollViewArea Icon" icon.</summary>
        public static UnityEditorIcon d_ScrollViewArea_Icon => _d_ScrollViewArea_Icon;


        private static readonly UnityEditorIcon _d_Selectable_Icon = BuildIcon("d_Selectable Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Selectable Icon" icon.</summary>
        public static UnityEditorIcon d_Selectable_Icon => _d_Selectable_Icon;


        private static readonly UnityEditorIcon _d_SelectionList_Icon = BuildIcon("d_SelectionList Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SelectionList Icon" icon.</summary>
        public static UnityEditorIcon d_SelectionList_Icon => _d_SelectionList_Icon;


        private static readonly UnityEditorIcon _d_SelectionListItem_Icon = BuildIcon("d_SelectionListItem Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SelectionListItem Icon" icon.</summary>
        public static UnityEditorIcon d_SelectionListItem_Icon => _d_SelectionListItem_Icon;


        private static readonly UnityEditorIcon _d_SelectionListTemplate_Icon = BuildIcon("d_SelectionListTemplate Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SelectionListTemplate Icon" icon.</summary>
        public static UnityEditorIcon d_SelectionListTemplate_Icon => _d_SelectionListTemplate_Icon;


        private static readonly UnityEditorIcon _d_Shadow_Icon = BuildIcon("d_Shadow Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Shadow Icon" icon.</summary>
        public static UnityEditorIcon d_Shadow_Icon => _d_Shadow_Icon;


        private static readonly UnityEditorIcon _d_Slider_Icon = BuildIcon("d_Slider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Slider Icon" icon.</summary>
        public static UnityEditorIcon d_Slider_Icon => _d_Slider_Icon;


        private static readonly UnityEditorIcon _d_Text_Icon = BuildIcon("d_Text Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Text Icon" icon.</summary>
        public static UnityEditorIcon d_Text_Icon => _d_Text_Icon;


        private static readonly UnityEditorIcon _d_Toggle_Icon = BuildIcon("d_Toggle Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Toggle Icon" icon.</summary>
        public static UnityEditorIcon d_Toggle_Icon => _d_Toggle_Icon;


        private static readonly UnityEditorIcon _d_ToggleGroup_Icon = BuildIcon("d_ToggleGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_ToggleGroup Icon" icon.</summary>
        public static UnityEditorIcon d_ToggleGroup_Icon => _d_ToggleGroup_Icon;


        private static readonly UnityEditorIcon _Dropdown_Icon = BuildIcon("Dropdown Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Dropdown Icon" icon.</summary>
        public static UnityEditorIcon Dropdown_Icon => _Dropdown_Icon;


        private static readonly UnityEditorIcon _FreeformLayoutGroup_Icon = BuildIcon("FreeformLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "FreeformLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon FreeformLayoutGroup_Icon => _FreeformLayoutGroup_Icon;


        private static readonly UnityEditorIcon _GraphicRaycaster_Icon = BuildIcon("GraphicRaycaster Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GraphicRaycaster Icon" icon.</summary>
        public static UnityEditorIcon GraphicRaycaster_Icon => _GraphicRaycaster_Icon;


        private static readonly UnityEditorIcon _GridLayoutGroup_Icon = BuildIcon("GridLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon GridLayoutGroup_Icon => _GridLayoutGroup_Icon;


        private static readonly UnityEditorIcon _Image_Icon = BuildIcon("Image Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Image Icon" icon.</summary>
        public static UnityEditorIcon Image_Icon => _Image_Icon;


        private static readonly UnityEditorIcon _InputField_Icon = BuildIcon("InputField Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "InputField Icon" icon.</summary>
        public static UnityEditorIcon InputField_Icon => _InputField_Icon;


        private static readonly UnityEditorIcon _LayoutElement_Icon = BuildIcon("LayoutElement Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "LayoutElement Icon" icon.</summary>
        public static UnityEditorIcon LayoutElement_Icon => _LayoutElement_Icon;


        private static readonly UnityEditorIcon _Mask_Icon = BuildIcon("Mask Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Mask Icon" icon.</summary>
        public static UnityEditorIcon Mask_Icon => _Mask_Icon;


        private static readonly UnityEditorIcon _Outline_Icon = BuildIcon("Outline Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Outline Icon" icon.</summary>
        public static UnityEditorIcon Outline_Icon => _Outline_Icon;


        private static readonly UnityEditorIcon _PositionAsUV1_Icon = BuildIcon("PositionAsUV1 Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "PositionAsUV1 Icon" icon.</summary>
        public static UnityEditorIcon PositionAsUV1_Icon => _PositionAsUV1_Icon;


        private static readonly UnityEditorIcon _RawImage_Icon = BuildIcon("RawImage Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RawImage Icon" icon.</summary>
        public static UnityEditorIcon RawImage_Icon => _RawImage_Icon;


        private static readonly UnityEditorIcon _RectMask2D_Icon = BuildIcon("RectMask2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectMask2D Icon" icon.</summary>
        public static UnityEditorIcon RectMask2D_Icon => _RectMask2D_Icon;


        private static readonly UnityEditorIcon _Scrollbar_Icon = BuildIcon("Scrollbar Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Scrollbar Icon" icon.</summary>
        public static UnityEditorIcon Scrollbar_Icon => _Scrollbar_Icon;


        private static readonly UnityEditorIcon _ScrollRect_Icon = BuildIcon("ScrollRect Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScrollRect Icon" icon.</summary>
        public static UnityEditorIcon ScrollRect_Icon => _ScrollRect_Icon;


        private static readonly UnityEditorIcon _Selectable_Icon = BuildIcon("Selectable Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Selectable Icon" icon.</summary>
        public static UnityEditorIcon Selectable_Icon => _Selectable_Icon;


        private static readonly UnityEditorIcon _Shadow_Icon = BuildIcon("Shadow Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Shadow Icon" icon.</summary>
        public static UnityEditorIcon Shadow_Icon => _Shadow_Icon;


        private static readonly UnityEditorIcon _Slider_Icon = BuildIcon("Slider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Slider Icon" icon.</summary>
        public static UnityEditorIcon Slider_Icon => _Slider_Icon;


        private static readonly UnityEditorIcon _Text_Icon = BuildIcon("Text Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Text Icon" icon.</summary>
        public static UnityEditorIcon Text_Icon => _Text_Icon;


        private static readonly UnityEditorIcon _Toggle_Icon = BuildIcon("Toggle Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toggle Icon" icon.</summary>
        public static UnityEditorIcon Toggle_Icon => _Toggle_Icon;


        private static readonly UnityEditorIcon _ToggleGroup_Icon = BuildIcon("ToggleGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToggleGroup Icon" icon.</summary>
        public static UnityEditorIcon ToggleGroup_Icon => _ToggleGroup_Icon;


        private static readonly UnityEditorIcon _VerticalLayoutGroup_Icon = BuildIcon("VerticalLayoutGroup Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VerticalLayoutGroup Icon" icon.</summary>
        public static UnityEditorIcon VerticalLayoutGroup_Icon => _VerticalLayoutGroup_Icon;


        private static readonly UnityEditorIcon _d_StyleSheet_Icon = BuildIcon("d_StyleSheet Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_StyleSheet Icon" icon.</summary>
        public static UnityEditorIcon d_StyleSheet_Icon => _d_StyleSheet_Icon;


        private static readonly UnityEditorIcon _d_VisualTreeAsset_Icon = BuildIcon("d_VisualTreeAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisualTreeAsset Icon" icon.</summary>
        public static UnityEditorIcon d_VisualTreeAsset_Icon => _d_VisualTreeAsset_Icon;


        private static readonly UnityEditorIcon _StyleSheet_Icon = BuildIcon("StyleSheet Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StyleSheet Icon" icon.</summary>
        public static UnityEditorIcon StyleSheet_Icon => _StyleSheet_Icon;


        private static readonly UnityEditorIcon _VisualTreeAsset_Icon = BuildIcon("VisualTreeAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualTreeAsset Icon" icon.</summary>
        public static UnityEditorIcon VisualTreeAsset_Icon => _VisualTreeAsset_Icon;


        private static readonly UnityEditorIcon _d_VisualEffect_Icon = BuildIcon("d_VisualEffect Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisualEffect Icon" icon.</summary>
        public static UnityEditorIcon d_VisualEffect_Icon => _d_VisualEffect_Icon;


        private static readonly UnityEditorIcon _d_VisualEffectAsset_Icon = BuildIcon("d_VisualEffectAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VisualEffectAsset Icon" icon.</summary>
        public static UnityEditorIcon d_VisualEffectAsset_Icon => _d_VisualEffectAsset_Icon;


        private static readonly UnityEditorIcon _VisualEffect_Icon = BuildIcon("VisualEffect Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualEffect Icon" icon.</summary>
        public static UnityEditorIcon VisualEffect_Icon => _VisualEffect_Icon;


        private static readonly UnityEditorIcon _VisualEffectAsset_Icon = BuildIcon("VisualEffectAsset Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualEffectAsset Icon" icon.</summary>
        public static UnityEditorIcon VisualEffectAsset_Icon => _VisualEffectAsset_Icon;


        private static readonly UnityEditorIcon _d_VideoPlayer_Icon = BuildIcon("d_VideoPlayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_VideoPlayer Icon" icon.</summary>
        public static UnityEditorIcon d_VideoPlayer_Icon => _d_VideoPlayer_Icon;


        private static readonly UnityEditorIcon _VideoClip_Icon = BuildIcon("VideoClip Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VideoClip Icon" icon.</summary>
        public static UnityEditorIcon VideoClip_Icon => _VideoClip_Icon;


        private static readonly UnityEditorIcon _VideoPlayer_Icon = BuildIcon("VideoPlayer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VideoPlayer Icon" icon.</summary>
        public static UnityEditorIcon VideoPlayer_Icon => _VideoPlayer_Icon;


        private static readonly UnityEditorIcon _WheelCollider_Icon = BuildIcon("WheelCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WheelCollider Icon" icon.</summary>
        public static UnityEditorIcon WheelCollider_Icon => _WheelCollider_Icon;


        private static readonly UnityEditorIcon _WheelJoint2D_Icon = BuildIcon("WheelJoint2D Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WheelJoint2D Icon" icon.</summary>
        public static UnityEditorIcon WheelJoint2D_Icon => _WheelJoint2D_Icon;


        private static readonly UnityEditorIcon _WindZone_Icon = BuildIcon("WindZone Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WindZone Icon" icon.</summary>
        public static UnityEditorIcon WindZone_Icon => _WindZone_Icon;


        private static readonly UnityEditorIcon _d_SpatialMappingCollider_Icon = BuildIcon("d_SpatialMappingCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SpatialMappingCollider Icon" icon.</summary>
        public static UnityEditorIcon d_SpatialMappingCollider_Icon => _d_SpatialMappingCollider_Icon;


        private static readonly UnityEditorIcon _SpatialMappingCollider_Icon = BuildIcon("SpatialMappingCollider Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpatialMappingCollider Icon" icon.</summary>
        public static UnityEditorIcon SpatialMappingCollider_Icon => _SpatialMappingCollider_Icon;


        private static readonly UnityEditorIcon _SpatialMappingRenderer_Icon = BuildIcon("SpatialMappingRenderer Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpatialMappingRenderer Icon" icon.</summary>
        public static UnityEditorIcon SpatialMappingRenderer_Icon => _SpatialMappingRenderer_Icon;


        private static readonly UnityEditorIcon _UssScript_Icon = BuildIcon("UssScript Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UssScript Icon" icon.</summary>
        public static UnityEditorIcon UssScript_Icon => _UssScript_Icon;


        private static readonly UnityEditorIcon _UxmlScript_Icon = BuildIcon("UxmlScript Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UxmlScript Icon" icon.</summary>
        public static UnityEditorIcon UxmlScript_Icon => _UxmlScript_Icon;


        private static readonly UnityEditorIcon _VideoEffect_Icon = BuildIcon("VideoEffect Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VideoEffect Icon" icon.</summary>
        public static UnityEditorIcon VideoEffect_Icon => _VideoEffect_Icon;


        private static readonly UnityEditorIcon _VisualEffect_Gizmo = BuildIcon("VisualEffect Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisualEffect Gizmo" icon.</summary>
        public static UnityEditorIcon VisualEffect_Gizmo => _VisualEffect_Gizmo;


        private static readonly UnityEditorIcon _WindZone_Gizmo = BuildIcon("WindZone Gizmo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WindZone Gizmo" icon.</summary>
        public static UnityEditorIcon WindZone_Gizmo => _WindZone_Gizmo;


        private static readonly UnityEditorIcon _Profiler_Audio = BuildIcon("Profiler.Audio");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Audio" icon.</summary>
        public static UnityEditorIcon Profiler_Audio => _Profiler_Audio;


        private static readonly UnityEditorIcon _Profiler_Audio2x = BuildIcon("Profiler.Audio@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Audio@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Audio2x => _Profiler_Audio2x;


        private static readonly UnityEditorIcon _Profiler_CPU = BuildIcon("Profiler.CPU");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.CPU" icon.</summary>
        public static UnityEditorIcon Profiler_CPU => _Profiler_CPU;


        private static readonly UnityEditorIcon _Profiler_CPU2x = BuildIcon("Profiler.CPU@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.CPU@2x" icon.</summary>
        public static UnityEditorIcon Profiler_CPU2x => _Profiler_CPU2x;


        private static readonly UnityEditorIcon _Profiler_Custom = BuildIcon("Profiler.Custom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Custom" icon.</summary>
        public static UnityEditorIcon Profiler_Custom => _Profiler_Custom;


        private static readonly UnityEditorIcon _Profiler_Custom2x = BuildIcon("Profiler.Custom@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Custom@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Custom2x => _Profiler_Custom2x;


        private static readonly UnityEditorIcon _Profiler_FirstFrame = BuildIcon("Profiler.FirstFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.FirstFrame" icon.</summary>
        public static UnityEditorIcon Profiler_FirstFrame => _Profiler_FirstFrame;


        private static readonly UnityEditorIcon _Profiler_GlobalIllumination = BuildIcon("Profiler.GlobalIllumination");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.GlobalIllumination" icon.</summary>
        public static UnityEditorIcon Profiler_GlobalIllumination => _Profiler_GlobalIllumination;


        private static readonly UnityEditorIcon _Profiler_GlobalIllumination2x = BuildIcon("Profiler.GlobalIllumination@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.GlobalIllumination@2x" icon.</summary>
        public static UnityEditorIcon Profiler_GlobalIllumination2x => _Profiler_GlobalIllumination2x;


        private static readonly UnityEditorIcon _Profiler_GPU = BuildIcon("Profiler.GPU");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.GPU" icon.</summary>
        public static UnityEditorIcon Profiler_GPU => _Profiler_GPU;


        private static readonly UnityEditorIcon _Profiler_GPU2x = BuildIcon("Profiler.GPU@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.GPU@2x" icon.</summary>
        public static UnityEditorIcon Profiler_GPU2x => _Profiler_GPU2x;


        private static readonly UnityEditorIcon _Profiler_Instrumentation = BuildIcon("Profiler.Instrumentation");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Instrumentation" icon.</summary>
        public static UnityEditorIcon Profiler_Instrumentation => _Profiler_Instrumentation;


        private static readonly UnityEditorIcon _Profiler_LastFrame = BuildIcon("Profiler.LastFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.LastFrame" icon.</summary>
        public static UnityEditorIcon Profiler_LastFrame => _Profiler_LastFrame;


        private static readonly UnityEditorIcon _Profiler_Memory = BuildIcon("Profiler.Memory");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Memory" icon.</summary>
        public static UnityEditorIcon Profiler_Memory => _Profiler_Memory;


        private static readonly UnityEditorIcon _Profiler_Memory2x = BuildIcon("Profiler.Memory@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Memory@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Memory2x => _Profiler_Memory2x;


        private static readonly UnityEditorIcon _Profiler_NetworkMessages = BuildIcon("Profiler.NetworkMessages");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.NetworkMessages" icon.</summary>
        public static UnityEditorIcon Profiler_NetworkMessages => _Profiler_NetworkMessages;


        private static readonly UnityEditorIcon _Profiler_NetworkMessages2x = BuildIcon("Profiler.NetworkMessages@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.NetworkMessages@2x" icon.</summary>
        public static UnityEditorIcon Profiler_NetworkMessages2x => _Profiler_NetworkMessages2x;


        private static readonly UnityEditorIcon _Profiler_NetworkOperations = BuildIcon("Profiler.NetworkOperations");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.NetworkOperations" icon.</summary>
        public static UnityEditorIcon Profiler_NetworkOperations => _Profiler_NetworkOperations;


        private static readonly UnityEditorIcon _Profiler_NetworkOperations2x = BuildIcon("Profiler.NetworkOperations@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.NetworkOperations@2x" icon.</summary>
        public static UnityEditorIcon Profiler_NetworkOperations2x => _Profiler_NetworkOperations2x;


        private static readonly UnityEditorIcon _Profiler_NextFrame = BuildIcon("Profiler.NextFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.NextFrame" icon.</summary>
        public static UnityEditorIcon Profiler_NextFrame => _Profiler_NextFrame;


        private static readonly UnityEditorIcon _Profiler_Open = BuildIcon("Profiler.Open");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Open" icon.</summary>
        public static UnityEditorIcon Profiler_Open => _Profiler_Open;


        private static readonly UnityEditorIcon _Profiler_Open2x = BuildIcon("Profiler.Open@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Open@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Open2x => _Profiler_Open2x;


        private static readonly UnityEditorIcon _Profiler_Open4x = BuildIcon("Profiler.Open@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Open@4x" icon.</summary>
        public static UnityEditorIcon Profiler_Open4x => _Profiler_Open4x;


        private static readonly UnityEditorIcon _Profiler_Physics = BuildIcon("Profiler.Physics");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Physics" icon.</summary>
        public static UnityEditorIcon Profiler_Physics => _Profiler_Physics;


        private static readonly UnityEditorIcon _Profiler_Physics2D = BuildIcon("Profiler.Physics2D");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Physics2D" icon.</summary>
        public static UnityEditorIcon Profiler_Physics2D => _Profiler_Physics2D;


        private static readonly UnityEditorIcon _Profiler_Physics2D2x = BuildIcon("Profiler.Physics2D@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Physics2D@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Physics2D2x => _Profiler_Physics2D2x;


        private static readonly UnityEditorIcon _Profiler_Physics2x = BuildIcon("Profiler.Physics@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Physics@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Physics2x => _Profiler_Physics2x;


        private static readonly UnityEditorIcon _Profiler_PrevFrame = BuildIcon("Profiler.PrevFrame");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.PrevFrame" icon.</summary>
        public static UnityEditorIcon Profiler_PrevFrame => _Profiler_PrevFrame;


        private static readonly UnityEditorIcon _Profiler_Record = BuildIcon("Profiler.Record");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Record" icon.</summary>
        public static UnityEditorIcon Profiler_Record => _Profiler_Record;


        private static readonly UnityEditorIcon _Profiler_Rendering = BuildIcon("Profiler.Rendering");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Rendering" icon.</summary>
        public static UnityEditorIcon Profiler_Rendering => _Profiler_Rendering;


        private static readonly UnityEditorIcon _Profiler_Rendering2x = BuildIcon("Profiler.Rendering@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Rendering@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Rendering2x => _Profiler_Rendering2x;


        private static readonly UnityEditorIcon _Profiler_UI = BuildIcon("Profiler.UI");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.UI" icon.</summary>
        public static UnityEditorIcon Profiler_UI => _Profiler_UI;


        private static readonly UnityEditorIcon _Profiler_UI2x = BuildIcon("Profiler.UI@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.UI@2x" icon.</summary>
        public static UnityEditorIcon Profiler_UI2x => _Profiler_UI2x;


        private static readonly UnityEditorIcon _Profiler_UIDetails = BuildIcon("Profiler.UIDetails");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.UIDetails" icon.</summary>
        public static UnityEditorIcon Profiler_UIDetails => _Profiler_UIDetails;


        private static readonly UnityEditorIcon _Profiler_UIDetails2x = BuildIcon("Profiler.UIDetails@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.UIDetails@2x" icon.</summary>
        public static UnityEditorIcon Profiler_UIDetails2x => _Profiler_UIDetails2x;


        private static readonly UnityEditorIcon _Profiler_Video = BuildIcon("Profiler.Video");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Video" icon.</summary>
        public static UnityEditorIcon Profiler_Video => _Profiler_Video;


        private static readonly UnityEditorIcon _Profiler_Video2x = BuildIcon("Profiler.Video@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.Video@2x" icon.</summary>
        public static UnityEditorIcon Profiler_Video2x => _Profiler_Video2x;


        private static readonly UnityEditorIcon _Profiler_VirtualTexturing = BuildIcon("Profiler.VirtualTexturing");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.VirtualTexturing" icon.</summary>
        public static UnityEditorIcon Profiler_VirtualTexturing => _Profiler_VirtualTexturing;


        private static readonly UnityEditorIcon _Profiler_VirtualTexturing2x = BuildIcon("Profiler.VirtualTexturing@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Profiler.VirtualTexturing@2x" icon.</summary>
        public static UnityEditorIcon Profiler_VirtualTexturing2x => _Profiler_VirtualTexturing2x;


        private static readonly UnityEditorIcon _ProfilerColumn_WarningCount = BuildIcon("ProfilerColumn.WarningCount");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ProfilerColumn.WarningCount" icon.</summary>
        public static UnityEditorIcon ProfilerColumn_WarningCount => _ProfilerColumn_WarningCount;


        private static readonly UnityEditorIcon _Progress = BuildIcon("Progress");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Progress" icon.</summary>
        public static UnityEditorIcon Progress => _Progress;


        private static readonly UnityEditorIcon _Progress2x = BuildIcon("Progress@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Progress@2x" icon.</summary>
        public static UnityEditorIcon Progress2x => _Progress2x;


        private static readonly UnityEditorIcon _Project = BuildIcon("Project");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Project" icon.</summary>
        public static UnityEditorIcon Project => _Project;


        private static readonly UnityEditorIcon _Project2x = BuildIcon("Project@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Project@2x" icon.</summary>
        public static UnityEditorIcon Project2x => _Project2x;


        private static readonly UnityEditorIcon _Record_Off = BuildIcon("Record Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Record Off" icon.</summary>
        public static UnityEditorIcon Record_Off => _Record_Off;


        private static readonly UnityEditorIcon _Record_Off2x = BuildIcon("Record Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Record Off@2x" icon.</summary>
        public static UnityEditorIcon Record_Off2x => _Record_Off2x;


        private static readonly UnityEditorIcon _Record_On = BuildIcon("Record On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Record On" icon.</summary>
        public static UnityEditorIcon Record_On => _Record_On;


        private static readonly UnityEditorIcon _Record_On2x = BuildIcon("Record On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Record On@2x" icon.</summary>
        public static UnityEditorIcon Record_On2x => _Record_On2x;


        private static readonly UnityEditorIcon _RectTool_On = BuildIcon("RectTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTool On" icon.</summary>
        public static UnityEditorIcon RectTool_On => _RectTool_On;


        private static readonly UnityEditorIcon _RectTool_On2x = BuildIcon("RectTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTool On@2x" icon.</summary>
        public static UnityEditorIcon RectTool_On2x => _RectTool_On2x;


        private static readonly UnityEditorIcon _RectTool = BuildIcon("RectTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTool" icon.</summary>
        public static UnityEditorIcon RectTool => _RectTool;


        private static readonly UnityEditorIcon _RectTool2x = BuildIcon("RectTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTool@2x" icon.</summary>
        public static UnityEditorIcon RectTool2x => _RectTool2x;


        private static readonly UnityEditorIcon _RectTransformBlueprint = BuildIcon("RectTransformBlueprint");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTransformBlueprint" icon.</summary>
        public static UnityEditorIcon RectTransformBlueprint => _RectTransformBlueprint;


        private static readonly UnityEditorIcon _RectTransformRaw = BuildIcon("RectTransformRaw");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RectTransformRaw" icon.</summary>
        public static UnityEditorIcon RectTransformRaw => _RectTransformRaw;


        private static readonly UnityEditorIcon _redGroove = BuildIcon("redGroove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "redGroove" icon.</summary>
        public static UnityEditorIcon redGroove => _redGroove;


        private static readonly UnityEditorIcon _ReflectionProbeSelector = BuildIcon("ReflectionProbeSelector");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ReflectionProbeSelector" icon.</summary>
        public static UnityEditorIcon ReflectionProbeSelector => _ReflectionProbeSelector;


        private static readonly UnityEditorIcon _ReflectionProbeSelector2x = BuildIcon("ReflectionProbeSelector@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ReflectionProbeSelector@2x" icon.</summary>
        public static UnityEditorIcon ReflectionProbeSelector2x => _ReflectionProbeSelector2x;


        private static readonly UnityEditorIcon _RepaintDot = BuildIcon("RepaintDot");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RepaintDot" icon.</summary>
        public static UnityEditorIcon RepaintDot => _RepaintDot;


        private static readonly UnityEditorIcon _RepaintDot2x = BuildIcon("RepaintDot@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RepaintDot@2x" icon.</summary>
        public static UnityEditorIcon RepaintDot2x => _RepaintDot2x;


        private static readonly UnityEditorIcon _rightBracket = BuildIcon("rightBracket");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "rightBracket" icon.</summary>
        public static UnityEditorIcon rightBracket => _rightBracket;


        private static readonly UnityEditorIcon _RotateTool_On = BuildIcon("RotateTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotateTool On" icon.</summary>
        public static UnityEditorIcon RotateTool_On => _RotateTool_On;


        private static readonly UnityEditorIcon _RotateTool_On2x = BuildIcon("RotateTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotateTool On@2x" icon.</summary>
        public static UnityEditorIcon RotateTool_On2x => _RotateTool_On2x;


        private static readonly UnityEditorIcon _RotateTool = BuildIcon("RotateTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotateTool" icon.</summary>
        public static UnityEditorIcon RotateTool => _RotateTool;


        private static readonly UnityEditorIcon _RotateTool2x = BuildIcon("RotateTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotateTool@2x" icon.</summary>
        public static UnityEditorIcon RotateTool2x => _RotateTool2x;


        private static readonly UnityEditorIcon _RotateTool4x = BuildIcon("RotateTool@4x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "RotateTool@4x" icon.</summary>
        public static UnityEditorIcon RotateTool4x => _RotateTool4x;


        private static readonly UnityEditorIcon _SaveActive = BuildIcon("SaveActive");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SaveActive" icon.</summary>
        public static UnityEditorIcon SaveActive => _SaveActive;


        private static readonly UnityEditorIcon _SaveAs = BuildIcon("SaveAs");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SaveAs" icon.</summary>
        public static UnityEditorIcon SaveAs => _SaveAs;


        private static readonly UnityEditorIcon _SaveAs2x = BuildIcon("SaveAs@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SaveAs@2x" icon.</summary>
        public static UnityEditorIcon SaveAs2x => _SaveAs2x;


        private static readonly UnityEditorIcon _SaveFromPlay = BuildIcon("SaveFromPlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SaveFromPlay" icon.</summary>
        public static UnityEditorIcon SaveFromPlay => _SaveFromPlay;


        private static readonly UnityEditorIcon _SavePassive = BuildIcon("SavePassive");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SavePassive" icon.</summary>
        public static UnityEditorIcon SavePassive => _SavePassive;


        private static readonly UnityEditorIcon _ScaleTool_On = BuildIcon("ScaleTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScaleTool On" icon.</summary>
        public static UnityEditorIcon ScaleTool_On => _ScaleTool_On;


        private static readonly UnityEditorIcon _ScaleTool_On2x = BuildIcon("ScaleTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScaleTool On@2x" icon.</summary>
        public static UnityEditorIcon ScaleTool_On2x => _ScaleTool_On2x;


        private static readonly UnityEditorIcon _ScaleTool = BuildIcon("ScaleTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScaleTool" icon.</summary>
        public static UnityEditorIcon ScaleTool => _ScaleTool;


        private static readonly UnityEditorIcon _ScaleTool2x = BuildIcon("ScaleTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScaleTool@2x" icon.</summary>
        public static UnityEditorIcon ScaleTool2x => _ScaleTool2x;


        private static readonly UnityEditorIcon _SceneLoadIn = BuildIcon("SceneLoadIn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneLoadIn" icon.</summary>
        public static UnityEditorIcon SceneLoadIn => _SceneLoadIn;


        private static readonly UnityEditorIcon _SceneLoadOut = BuildIcon("SceneLoadOut");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneLoadOut" icon.</summary>
        public static UnityEditorIcon SceneLoadOut => _SceneLoadOut;


        private static readonly UnityEditorIcon _scenepicking_notpickable_mixed = BuildIcon("scenepicking_notpickable-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable-mixed" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_mixed => _scenepicking_notpickable_mixed;


        private static readonly UnityEditorIcon _scenepicking_notpickable_mixed2x = BuildIcon("scenepicking_notpickable-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable-mixed@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_mixed2x => _scenepicking_notpickable_mixed2x;


        private static readonly UnityEditorIcon _scenepicking_notpickable_mixed_hover = BuildIcon("scenepicking_notpickable-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable-mixed_hover" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_mixed_hover => _scenepicking_notpickable_mixed_hover;


        private static readonly UnityEditorIcon _scenepicking_notpickable_mixed_hover2x = BuildIcon("scenepicking_notpickable-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_mixed_hover2x => _scenepicking_notpickable_mixed_hover2x;


        private static readonly UnityEditorIcon _scenepicking_notpickable = BuildIcon("scenepicking_notpickable");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable => _scenepicking_notpickable;


        private static readonly UnityEditorIcon _scenepicking_notpickable2x = BuildIcon("scenepicking_notpickable@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable2x => _scenepicking_notpickable2x;


        private static readonly UnityEditorIcon _scenepicking_notpickable_hover = BuildIcon("scenepicking_notpickable_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable_hover" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_hover => _scenepicking_notpickable_hover;


        private static readonly UnityEditorIcon _scenepicking_notpickable_hover2x = BuildIcon("scenepicking_notpickable_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_notpickable_hover@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_notpickable_hover2x => _scenepicking_notpickable_hover2x;


        private static readonly UnityEditorIcon _scenepicking_pickable_mixed = BuildIcon("scenepicking_pickable-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable-mixed" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_mixed => _scenepicking_pickable_mixed;


        private static readonly UnityEditorIcon _scenepicking_pickable_mixed2x = BuildIcon("scenepicking_pickable-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable-mixed@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_mixed2x => _scenepicking_pickable_mixed2x;


        private static readonly UnityEditorIcon _scenepicking_pickable_mixed_hover = BuildIcon("scenepicking_pickable-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable-mixed_hover" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_mixed_hover => _scenepicking_pickable_mixed_hover;


        private static readonly UnityEditorIcon _scenepicking_pickable_mixed_hover2x = BuildIcon("scenepicking_pickable-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_mixed_hover2x => _scenepicking_pickable_mixed_hover2x;


        private static readonly UnityEditorIcon _scenepicking_pickable = BuildIcon("scenepicking_pickable");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable => _scenepicking_pickable;


        private static readonly UnityEditorIcon _scenepicking_pickable2x = BuildIcon("scenepicking_pickable@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable2x => _scenepicking_pickable2x;


        private static readonly UnityEditorIcon _scenepicking_pickable_hover = BuildIcon("scenepicking_pickable_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable_hover" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_hover => _scenepicking_pickable_hover;


        private static readonly UnityEditorIcon _scenepicking_pickable_hover2x = BuildIcon("scenepicking_pickable_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenepicking_pickable_hover@2x" icon.</summary>
        public static UnityEditorIcon scenepicking_pickable_hover2x => _scenepicking_pickable_hover2x;


        private static readonly UnityEditorIcon _SceneSave = BuildIcon("SceneSave");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneSave" icon.</summary>
        public static UnityEditorIcon SceneSave => _SceneSave;


        private static readonly UnityEditorIcon _SceneSaveGrey = BuildIcon("SceneSaveGrey");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneSaveGrey" icon.</summary>
        public static UnityEditorIcon SceneSaveGrey => _SceneSaveGrey;


        private static readonly UnityEditorIcon _pin = BuildIcon("pin");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "pin" icon.</summary>
        public static UnityEditorIcon pin => _pin;


        private static readonly UnityEditorIcon _pin2x = BuildIcon("pin@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "pin@2x" icon.</summary>
        public static UnityEditorIcon pin2x => _pin2x;


        private static readonly UnityEditorIcon _pinned = BuildIcon("pinned");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "pinned" icon.</summary>
        public static UnityEditorIcon pinned => _pinned;


        private static readonly UnityEditorIcon _pinned2x = BuildIcon("pinned@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "pinned@2x" icon.</summary>
        public static UnityEditorIcon pinned2x => _pinned2x;


        private static readonly UnityEditorIcon _scene_template_2d_scene = BuildIcon("scene-template-2d-scene");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-2d-scene" icon.</summary>
        public static UnityEditorIcon scene_template_2d_scene => _scene_template_2d_scene;


        private static readonly UnityEditorIcon _scene_template_3d_scene = BuildIcon("scene-template-3d-scene");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-3d-scene" icon.</summary>
        public static UnityEditorIcon scene_template_3d_scene => _scene_template_3d_scene;


        private static readonly UnityEditorIcon _scene_template_dark = BuildIcon("scene-template-dark");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-dark" icon.</summary>
        public static UnityEditorIcon scene_template_dark => _scene_template_dark;


        private static readonly UnityEditorIcon _scene_template_default_scene = BuildIcon("scene-template-default-scene");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-default-scene" icon.</summary>
        public static UnityEditorIcon scene_template_default_scene => _scene_template_default_scene;


        private static readonly UnityEditorIcon _scene_template_empty_scene = BuildIcon("scene-template-empty-scene");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-empty-scene" icon.</summary>
        public static UnityEditorIcon scene_template_empty_scene => _scene_template_empty_scene;


        private static readonly UnityEditorIcon _scene_template_light = BuildIcon("scene-template-light");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template-light" icon.</summary>
        public static UnityEditorIcon scene_template_light => _scene_template_light;


        private static readonly UnityEditorIcon _scene_template = BuildIcon("scene-template");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scene-template" icon.</summary>
        public static UnityEditorIcon scene_template => _scene_template;


        private static readonly UnityEditorIcon _SceneView2D = BuildIcon("SceneView2D");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneView2D" icon.</summary>
        public static UnityEditorIcon SceneView2D => _SceneView2D;


        private static readonly UnityEditorIcon _SceneView2D2x = BuildIcon("SceneView2D@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneView2D@2x" icon.</summary>
        public static UnityEditorIcon SceneView2D2x => _SceneView2D2x;


        private static readonly UnityEditorIcon _SceneViewAlpha = BuildIcon("SceneViewAlpha");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewAlpha" icon.</summary>
        public static UnityEditorIcon SceneViewAlpha => _SceneViewAlpha;


        private static readonly UnityEditorIcon _SceneViewAudio_Off = BuildIcon("SceneViewAudio Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewAudio Off" icon.</summary>
        public static UnityEditorIcon SceneViewAudio_Off => _SceneViewAudio_Off;


        private static readonly UnityEditorIcon _SceneViewAudio_Off2x = BuildIcon("SceneViewAudio Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewAudio Off@2x" icon.</summary>
        public static UnityEditorIcon SceneViewAudio_Off2x => _SceneViewAudio_Off2x;


        private static readonly UnityEditorIcon _SceneViewAudio = BuildIcon("SceneViewAudio");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewAudio" icon.</summary>
        public static UnityEditorIcon SceneViewAudio => _SceneViewAudio;


        private static readonly UnityEditorIcon _SceneViewAudio2x = BuildIcon("SceneViewAudio@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewAudio@2x" icon.</summary>
        public static UnityEditorIcon SceneViewAudio2x => _SceneViewAudio2x;


        private static readonly UnityEditorIcon _SceneViewCamera = BuildIcon("SceneViewCamera");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewCamera" icon.</summary>
        public static UnityEditorIcon SceneViewCamera => _SceneViewCamera;


        private static readonly UnityEditorIcon _SceneViewCamera2x = BuildIcon("SceneViewCamera@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewCamera@2x" icon.</summary>
        public static UnityEditorIcon SceneViewCamera2x => _SceneViewCamera2x;


        private static readonly UnityEditorIcon _SceneViewFx = BuildIcon("SceneViewFx");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewFx" icon.</summary>
        public static UnityEditorIcon SceneViewFx => _SceneViewFx;


        private static readonly UnityEditorIcon _SceneViewFX2x = BuildIcon("SceneViewFX@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewFX@2x" icon.</summary>
        public static UnityEditorIcon SceneViewFX2x => _SceneViewFX2x;


        private static readonly UnityEditorIcon _SceneViewLighting_Off = BuildIcon("SceneViewLighting Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewLighting Off" icon.</summary>
        public static UnityEditorIcon SceneViewLighting_Off => _SceneViewLighting_Off;


        private static readonly UnityEditorIcon _SceneViewLighting_Off2x = BuildIcon("SceneViewLighting Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewLighting Off@2x" icon.</summary>
        public static UnityEditorIcon SceneViewLighting_Off2x => _SceneViewLighting_Off2x;


        private static readonly UnityEditorIcon _SceneViewLighting = BuildIcon("SceneViewLighting");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewLighting" icon.</summary>
        public static UnityEditorIcon SceneViewLighting => _SceneViewLighting;


        private static readonly UnityEditorIcon _SceneViewLighting2x = BuildIcon("SceneViewLighting@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewLighting@2x" icon.</summary>
        public static UnityEditorIcon SceneViewLighting2x => _SceneViewLighting2x;


        private static readonly UnityEditorIcon _SceneViewOrtho = BuildIcon("SceneViewOrtho");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewOrtho" icon.</summary>
        public static UnityEditorIcon SceneViewOrtho => _SceneViewOrtho;


        private static readonly UnityEditorIcon _SceneViewRGB = BuildIcon("SceneViewRGB");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewRGB" icon.</summary>
        public static UnityEditorIcon SceneViewRGB => _SceneViewRGB;


        private static readonly UnityEditorIcon _SceneViewTools = BuildIcon("SceneViewTools");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewTools" icon.</summary>
        public static UnityEditorIcon SceneViewTools => _SceneViewTools;


        private static readonly UnityEditorIcon _SceneViewTools2x = BuildIcon("SceneViewTools@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewTools@2x" icon.</summary>
        public static UnityEditorIcon SceneViewTools2x => _SceneViewTools2x;


        private static readonly UnityEditorIcon _SceneViewVisibility = BuildIcon("SceneViewVisibility");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewVisibility" icon.</summary>
        public static UnityEditorIcon SceneViewVisibility => _SceneViewVisibility;


        private static readonly UnityEditorIcon _SceneViewVisibility2x = BuildIcon("SceneViewVisibility@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewVisibility@2x" icon.</summary>
        public static UnityEditorIcon SceneViewVisibility2x => _SceneViewVisibility2x;


        private static readonly UnityEditorIcon _scenevis_hidden_mixed = BuildIcon("scenevis_hidden-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden-mixed" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_mixed => _scenevis_hidden_mixed;


        private static readonly UnityEditorIcon _scenevis_hidden_mixed2x = BuildIcon("scenevis_hidden-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden-mixed@2x" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_mixed2x => _scenevis_hidden_mixed2x;


        private static readonly UnityEditorIcon _scenevis_hidden_mixed_hover = BuildIcon("scenevis_hidden-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden-mixed_hover" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_mixed_hover => _scenevis_hidden_mixed_hover;


        private static readonly UnityEditorIcon _scenevis_hidden_mixed_hover2x = BuildIcon("scenevis_hidden-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_mixed_hover2x => _scenevis_hidden_mixed_hover2x;


        private static readonly UnityEditorIcon _scenevis_hidden = BuildIcon("scenevis_hidden");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden" icon.</summary>
        public static UnityEditorIcon scenevis_hidden => _scenevis_hidden;


        private static readonly UnityEditorIcon _scenevis_hidden2x = BuildIcon("scenevis_hidden@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden@2x" icon.</summary>
        public static UnityEditorIcon scenevis_hidden2x => _scenevis_hidden2x;


        private static readonly UnityEditorIcon _scenevis_hidden_hover = BuildIcon("scenevis_hidden_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden_hover" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_hover => _scenevis_hidden_hover;


        private static readonly UnityEditorIcon _scenevis_hidden_hover2x = BuildIcon("scenevis_hidden_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_hidden_hover@2x" icon.</summary>
        public static UnityEditorIcon scenevis_hidden_hover2x => _scenevis_hidden_hover2x;


        private static readonly UnityEditorIcon _scenevis_scene_hover = BuildIcon("scenevis_scene_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_scene_hover" icon.</summary>
        public static UnityEditorIcon scenevis_scene_hover => _scenevis_scene_hover;


        private static readonly UnityEditorIcon _scenevis_scene_hover2x = BuildIcon("scenevis_scene_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_scene_hover@2x" icon.</summary>
        public static UnityEditorIcon scenevis_scene_hover2x => _scenevis_scene_hover2x;


        private static readonly UnityEditorIcon _scenevis_visible_mixed = BuildIcon("scenevis_visible-mixed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible-mixed" icon.</summary>
        public static UnityEditorIcon scenevis_visible_mixed => _scenevis_visible_mixed;


        private static readonly UnityEditorIcon _scenevis_visible_mixed2x = BuildIcon("scenevis_visible-mixed@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible-mixed@2x" icon.</summary>
        public static UnityEditorIcon scenevis_visible_mixed2x => _scenevis_visible_mixed2x;


        private static readonly UnityEditorIcon _scenevis_visible_mixed_hover = BuildIcon("scenevis_visible-mixed_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible-mixed_hover" icon.</summary>
        public static UnityEditorIcon scenevis_visible_mixed_hover => _scenevis_visible_mixed_hover;


        private static readonly UnityEditorIcon _scenevis_visible_mixed_hover2x = BuildIcon("scenevis_visible-mixed_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible-mixed_hover@2x" icon.</summary>
        public static UnityEditorIcon scenevis_visible_mixed_hover2x => _scenevis_visible_mixed_hover2x;


        private static readonly UnityEditorIcon _scenevis_visible = BuildIcon("scenevis_visible");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible" icon.</summary>
        public static UnityEditorIcon scenevis_visible => _scenevis_visible;


        private static readonly UnityEditorIcon _scenevis_visible2x = BuildIcon("scenevis_visible@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible@2x" icon.</summary>
        public static UnityEditorIcon scenevis_visible2x => _scenevis_visible2x;


        private static readonly UnityEditorIcon _scenevis_visible_hover = BuildIcon("scenevis_visible_hover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible_hover" icon.</summary>
        public static UnityEditorIcon scenevis_visible_hover => _scenevis_visible_hover;


        private static readonly UnityEditorIcon _scenevis_visible_hover2x = BuildIcon("scenevis_visible_hover@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "scenevis_visible_hover@2x" icon.</summary>
        public static UnityEditorIcon scenevis_visible_hover2x => _scenevis_visible_hover2x;


        private static readonly UnityEditorIcon _ScrollShadow = BuildIcon("ScrollShadow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ScrollShadow" icon.</summary>
        public static UnityEditorIcon ScrollShadow => _ScrollShadow;


        private static readonly UnityEditorIcon _Settings = BuildIcon("Settings");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Settings" icon.</summary>
        public static UnityEditorIcon Settings => _Settings;


        private static readonly UnityEditorIcon _Settings2x = BuildIcon("Settings@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Settings@2x" icon.</summary>
        public static UnityEditorIcon Settings2x => _Settings2x;


        private static readonly UnityEditorIcon _SettingsIcon = BuildIcon("SettingsIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SettingsIcon" icon.</summary>
        public static UnityEditorIcon SettingsIcon => _SettingsIcon;


        private static readonly UnityEditorIcon _SettingsIcon2x = BuildIcon("SettingsIcon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SettingsIcon@2x" icon.</summary>
        public static UnityEditorIcon SettingsIcon2x => _SettingsIcon2x;


        private static readonly UnityEditorIcon _alertDialog = BuildIcon("alertDialog");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "alertDialog" icon.</summary>
        public static UnityEditorIcon alertDialog => _alertDialog;


        private static readonly UnityEditorIcon _alertDialog2x = BuildIcon("alertDialog@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "alertDialog@2x" icon.</summary>
        public static UnityEditorIcon alertDialog2x => _alertDialog2x;


        private static readonly UnityEditorIcon _conflict_icon = BuildIcon("conflict-icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "conflict-icon" icon.</summary>
        public static UnityEditorIcon conflict_icon => _conflict_icon;


        private static readonly UnityEditorIcon _conflict_icon2x = BuildIcon("conflict-icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "conflict-icon@2x" icon.</summary>
        public static UnityEditorIcon conflict_icon2x => _conflict_icon2x;


        private static readonly UnityEditorIcon _d_GridAxisX = BuildIcon("d_GridAxisX");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisX" icon.</summary>
        public static UnityEditorIcon d_GridAxisX => _d_GridAxisX;


        private static readonly UnityEditorIcon _d_GridAxisX2x = BuildIcon("d_GridAxisX@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisX@2x" icon.</summary>
        public static UnityEditorIcon d_GridAxisX2x => _d_GridAxisX2x;


        private static readonly UnityEditorIcon _d_GridAxisY = BuildIcon("d_GridAxisY");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisY" icon.</summary>
        public static UnityEditorIcon d_GridAxisY => _d_GridAxisY;


        private static readonly UnityEditorIcon _d_GridAxisY2x = BuildIcon("d_GridAxisY@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisY@2x" icon.</summary>
        public static UnityEditorIcon d_GridAxisY2x => _d_GridAxisY2x;


        private static readonly UnityEditorIcon _d_GridAxisZ = BuildIcon("d_GridAxisZ");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisZ" icon.</summary>
        public static UnityEditorIcon d_GridAxisZ => _d_GridAxisZ;


        private static readonly UnityEditorIcon _d_GridAxisZ2x = BuildIcon("d_GridAxisZ@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_GridAxisZ@2x" icon.</summary>
        public static UnityEditorIcon d_GridAxisZ2x => _d_GridAxisZ2x;


        private static readonly UnityEditorIcon _d_SceneViewSnap_Off = BuildIcon("d_SceneViewSnap-Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewSnap-Off" icon.</summary>
        public static UnityEditorIcon d_SceneViewSnap_Off => _d_SceneViewSnap_Off;


        private static readonly UnityEditorIcon _d_SceneViewSnap_Off2x = BuildIcon("d_SceneViewSnap-Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewSnap-Off@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewSnap_Off2x => _d_SceneViewSnap_Off2x;


        private static readonly UnityEditorIcon _d_SceneViewSnap_On = BuildIcon("d_SceneViewSnap-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewSnap-On" icon.</summary>
        public static UnityEditorIcon d_SceneViewSnap_On => _d_SceneViewSnap_On;


        private static readonly UnityEditorIcon _d_SceneViewSnap_On2x = BuildIcon("d_SceneViewSnap-On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_SceneViewSnap-On@2x" icon.</summary>
        public static UnityEditorIcon d_SceneViewSnap_On2x => _d_SceneViewSnap_On2x;


        private static readonly UnityEditorIcon _GridAxisX = BuildIcon("GridAxisX");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisX" icon.</summary>
        public static UnityEditorIcon GridAxisX => _GridAxisX;


        private static readonly UnityEditorIcon _GridAxisX2x = BuildIcon("GridAxisX@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisX@2x" icon.</summary>
        public static UnityEditorIcon GridAxisX2x => _GridAxisX2x;


        private static readonly UnityEditorIcon _GridAxisY = BuildIcon("GridAxisY");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisY" icon.</summary>
        public static UnityEditorIcon GridAxisY => _GridAxisY;


        private static readonly UnityEditorIcon _GridAxisY2x = BuildIcon("GridAxisY@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisY@2x" icon.</summary>
        public static UnityEditorIcon GridAxisY2x => _GridAxisY2x;


        private static readonly UnityEditorIcon _GridAxisZ = BuildIcon("GridAxisZ");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisZ" icon.</summary>
        public static UnityEditorIcon GridAxisZ => _GridAxisZ;


        private static readonly UnityEditorIcon _GridAxisZ2x = BuildIcon("GridAxisZ@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "GridAxisZ@2x" icon.</summary>
        public static UnityEditorIcon GridAxisZ2x => _GridAxisZ2x;


        private static readonly UnityEditorIcon _SceneViewSnap_Off = BuildIcon("SceneViewSnap-Off");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewSnap-Off" icon.</summary>
        public static UnityEditorIcon SceneViewSnap_Off => _SceneViewSnap_Off;


        private static readonly UnityEditorIcon _SceneViewSnap_Off2x = BuildIcon("SceneViewSnap-Off@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewSnap-Off@2x" icon.</summary>
        public static UnityEditorIcon SceneViewSnap_Off2x => _SceneViewSnap_Off2x;


        private static readonly UnityEditorIcon _SceneViewSnap_On = BuildIcon("SceneViewSnap-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewSnap-On" icon.</summary>
        public static UnityEditorIcon SceneViewSnap_On => _SceneViewSnap_On;


        private static readonly UnityEditorIcon _SceneViewSnap_On2x = BuildIcon("SceneViewSnap-On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SceneViewSnap-On@2x" icon.</summary>
        public static UnityEditorIcon SceneViewSnap_On2x => _SceneViewSnap_On2x;


        private static readonly UnityEditorIcon _SocialNetworks_FacebookShare = BuildIcon("SocialNetworks.FacebookShare");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SocialNetworks.FacebookShare" icon.</summary>
        public static UnityEditorIcon SocialNetworks_FacebookShare => _SocialNetworks_FacebookShare;


        private static readonly UnityEditorIcon _SocialNetworks_LinkedInShare = BuildIcon("SocialNetworks.LinkedInShare");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SocialNetworks.LinkedInShare" icon.</summary>
        public static UnityEditorIcon SocialNetworks_LinkedInShare => _SocialNetworks_LinkedInShare;


        private static readonly UnityEditorIcon _SocialNetworks_Tweet = BuildIcon("SocialNetworks.Tweet");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SocialNetworks.Tweet" icon.</summary>
        public static UnityEditorIcon SocialNetworks_Tweet => _SocialNetworks_Tweet;


        private static readonly UnityEditorIcon _SocialNetworks_UDNLogo = BuildIcon("SocialNetworks.UDNLogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SocialNetworks.UDNLogo" icon.</summary>
        public static UnityEditorIcon SocialNetworks_UDNLogo => _SocialNetworks_UDNLogo;


        private static readonly UnityEditorIcon _SocialNetworks_UDNOpen = BuildIcon("SocialNetworks.UDNOpen");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SocialNetworks.UDNOpen" icon.</summary>
        public static UnityEditorIcon SocialNetworks_UDNOpen => _SocialNetworks_UDNOpen;


        private static readonly UnityEditorIcon _SoftlockInline = BuildIcon("SoftlockInline");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SoftlockInline" icon.</summary>
        public static UnityEditorIcon SoftlockInline => _SoftlockInline;


        private static readonly UnityEditorIcon _SpeedScale = BuildIcon("SpeedScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "SpeedScale" icon.</summary>
        public static UnityEditorIcon SpeedScale => _SpeedScale;


        private static readonly UnityEditorIcon _StateMachineEditor_ArrowTip = BuildIcon("StateMachineEditor.ArrowTip");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.ArrowTip" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_ArrowTip => _StateMachineEditor_ArrowTip;


        private static readonly UnityEditorIcon _StateMachineEditor_ArrowTipSelected = BuildIcon("StateMachineEditor.ArrowTipSelected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.ArrowTipSelected" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_ArrowTipSelected => _StateMachineEditor_ArrowTipSelected;


        private static readonly UnityEditorIcon _StateMachineEditor_Background = BuildIcon("StateMachineEditor.Background");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.Background" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_Background => _StateMachineEditor_Background;


        private static readonly UnityEditorIcon _StateMachineEditor_State = BuildIcon("StateMachineEditor.State");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.State" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_State => _StateMachineEditor_State;


        private static readonly UnityEditorIcon _StateMachineEditor_StateHover = BuildIcon("StateMachineEditor.StateHover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.StateHover" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_StateHover => _StateMachineEditor_StateHover;


        private static readonly UnityEditorIcon _StateMachineEditor_StateSelected = BuildIcon("StateMachineEditor.StateSelected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.StateSelected" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_StateSelected => _StateMachineEditor_StateSelected;


        private static readonly UnityEditorIcon _StateMachineEditor_StateSub = BuildIcon("StateMachineEditor.StateSub");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.StateSub" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_StateSub => _StateMachineEditor_StateSub;


        private static readonly UnityEditorIcon _StateMachineEditor_StateSubHover = BuildIcon("StateMachineEditor.StateSubHover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.StateSubHover" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_StateSubHover => _StateMachineEditor_StateSubHover;


        private static readonly UnityEditorIcon _StateMachineEditor_StateSubSelected = BuildIcon("StateMachineEditor.StateSubSelected");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.StateSubSelected" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_StateSubSelected => _StateMachineEditor_StateSubSelected;


        private static readonly UnityEditorIcon _StateMachineEditor_UpButton = BuildIcon("StateMachineEditor.UpButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.UpButton" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_UpButton => _StateMachineEditor_UpButton;


        private static readonly UnityEditorIcon _StateMachineEditor_UpButtonHover = BuildIcon("StateMachineEditor.UpButtonHover");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StateMachineEditor.UpButtonHover" icon.</summary>
        public static UnityEditorIcon StateMachineEditor_UpButtonHover => _StateMachineEditor_UpButtonHover;


        private static readonly UnityEditorIcon _StepButton_On = BuildIcon("StepButton On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepButton On" icon.</summary>
        public static UnityEditorIcon StepButton_On => _StepButton_On;


        private static readonly UnityEditorIcon _StepButton_On2x = BuildIcon("StepButton On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepButton On@2x" icon.</summary>
        public static UnityEditorIcon StepButton_On2x => _StepButton_On2x;


        private static readonly UnityEditorIcon _StepButton = BuildIcon("StepButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepButton" icon.</summary>
        public static UnityEditorIcon StepButton => _StepButton;


        private static readonly UnityEditorIcon _StepButton2x = BuildIcon("StepButton@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepButton@2x" icon.</summary>
        public static UnityEditorIcon StepButton2x => _StepButton2x;


        private static readonly UnityEditorIcon _StepLeftButton_On = BuildIcon("StepLeftButton-On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepLeftButton-On" icon.</summary>
        public static UnityEditorIcon StepLeftButton_On => _StepLeftButton_On;


        private static readonly UnityEditorIcon _StepLeftButton = BuildIcon("StepLeftButton");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "StepLeftButton" icon.</summary>
        public static UnityEditorIcon StepLeftButton => _StepLeftButton;


        private static readonly UnityEditorIcon _sv_icon_dot0_sml = BuildIcon("sv_icon_dot0_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot0_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot0_sml => _sv_icon_dot0_sml;


        private static readonly UnityEditorIcon _sv_icon_dot10_sml = BuildIcon("sv_icon_dot10_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot10_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot10_sml => _sv_icon_dot10_sml;


        private static readonly UnityEditorIcon _sv_icon_dot11_sml = BuildIcon("sv_icon_dot11_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot11_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot11_sml => _sv_icon_dot11_sml;


        private static readonly UnityEditorIcon _sv_icon_dot12_sml = BuildIcon("sv_icon_dot12_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot12_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot12_sml => _sv_icon_dot12_sml;


        private static readonly UnityEditorIcon _sv_icon_dot13_sml = BuildIcon("sv_icon_dot13_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot13_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot13_sml => _sv_icon_dot13_sml;


        private static readonly UnityEditorIcon _sv_icon_dot14_sml = BuildIcon("sv_icon_dot14_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot14_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot14_sml => _sv_icon_dot14_sml;


        private static readonly UnityEditorIcon _sv_icon_dot15_sml = BuildIcon("sv_icon_dot15_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot15_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot15_sml => _sv_icon_dot15_sml;


        private static readonly UnityEditorIcon _sv_icon_dot1_sml = BuildIcon("sv_icon_dot1_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot1_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot1_sml => _sv_icon_dot1_sml;


        private static readonly UnityEditorIcon _sv_icon_dot2_sml = BuildIcon("sv_icon_dot2_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot2_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot2_sml => _sv_icon_dot2_sml;


        private static readonly UnityEditorIcon _sv_icon_dot3_sml = BuildIcon("sv_icon_dot3_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot3_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot3_sml => _sv_icon_dot3_sml;


        private static readonly UnityEditorIcon _sv_icon_dot4_sml = BuildIcon("sv_icon_dot4_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot4_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot4_sml => _sv_icon_dot4_sml;


        private static readonly UnityEditorIcon _sv_icon_dot5_sml = BuildIcon("sv_icon_dot5_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot5_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot5_sml => _sv_icon_dot5_sml;


        private static readonly UnityEditorIcon _sv_icon_dot6_sml = BuildIcon("sv_icon_dot6_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot6_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot6_sml => _sv_icon_dot6_sml;


        private static readonly UnityEditorIcon _sv_icon_dot7_sml = BuildIcon("sv_icon_dot7_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot7_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot7_sml => _sv_icon_dot7_sml;


        private static readonly UnityEditorIcon _sv_icon_dot8_sml = BuildIcon("sv_icon_dot8_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot8_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot8_sml => _sv_icon_dot8_sml;


        private static readonly UnityEditorIcon _sv_icon_dot9_sml = BuildIcon("sv_icon_dot9_sml");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_dot9_sml" icon.</summary>
        public static UnityEditorIcon sv_icon_dot9_sml => _sv_icon_dot9_sml;


        private static readonly UnityEditorIcon _sv_icon_name0 = BuildIcon("sv_icon_name0");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name0" icon.</summary>
        public static UnityEditorIcon sv_icon_name0 => _sv_icon_name0;


        private static readonly UnityEditorIcon _sv_icon_name1 = BuildIcon("sv_icon_name1");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name1" icon.</summary>
        public static UnityEditorIcon sv_icon_name1 => _sv_icon_name1;


        private static readonly UnityEditorIcon _sv_icon_name2 = BuildIcon("sv_icon_name2");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name2" icon.</summary>
        public static UnityEditorIcon sv_icon_name2 => _sv_icon_name2;


        private static readonly UnityEditorIcon _sv_icon_name3 = BuildIcon("sv_icon_name3");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name3" icon.</summary>
        public static UnityEditorIcon sv_icon_name3 => _sv_icon_name3;


        private static readonly UnityEditorIcon _sv_icon_name4 = BuildIcon("sv_icon_name4");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name4" icon.</summary>
        public static UnityEditorIcon sv_icon_name4 => _sv_icon_name4;


        private static readonly UnityEditorIcon _sv_icon_name5 = BuildIcon("sv_icon_name5");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name5" icon.</summary>
        public static UnityEditorIcon sv_icon_name5 => _sv_icon_name5;


        private static readonly UnityEditorIcon _sv_icon_name6 = BuildIcon("sv_icon_name6");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name6" icon.</summary>
        public static UnityEditorIcon sv_icon_name6 => _sv_icon_name6;


        private static readonly UnityEditorIcon _sv_icon_name7 = BuildIcon("sv_icon_name7");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_name7" icon.</summary>
        public static UnityEditorIcon sv_icon_name7 => _sv_icon_name7;


        private static readonly UnityEditorIcon _sv_icon_none = BuildIcon("sv_icon_none");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_icon_none" icon.</summary>
        public static UnityEditorIcon sv_icon_none => _sv_icon_none;


        private static readonly UnityEditorIcon _sv_label_0 = BuildIcon("sv_label_0");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_0" icon.</summary>
        public static UnityEditorIcon sv_label_0 => _sv_label_0;


        private static readonly UnityEditorIcon _sv_label_1 = BuildIcon("sv_label_1");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_1" icon.</summary>
        public static UnityEditorIcon sv_label_1 => _sv_label_1;


        private static readonly UnityEditorIcon _sv_label_2 = BuildIcon("sv_label_2");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_2" icon.</summary>
        public static UnityEditorIcon sv_label_2 => _sv_label_2;


        private static readonly UnityEditorIcon _sv_label_3 = BuildIcon("sv_label_3");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_3" icon.</summary>
        public static UnityEditorIcon sv_label_3 => _sv_label_3;


        private static readonly UnityEditorIcon _sv_label_4 = BuildIcon("sv_label_4");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_4" icon.</summary>
        public static UnityEditorIcon sv_label_4 => _sv_label_4;


        private static readonly UnityEditorIcon _sv_label_5 = BuildIcon("sv_label_5");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_5" icon.</summary>
        public static UnityEditorIcon sv_label_5 => _sv_label_5;


        private static readonly UnityEditorIcon _sv_label_6 = BuildIcon("sv_label_6");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_6" icon.</summary>
        public static UnityEditorIcon sv_label_6 => _sv_label_6;


        private static readonly UnityEditorIcon _sv_label_7 = BuildIcon("sv_label_7");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "sv_label_7" icon.</summary>
        public static UnityEditorIcon sv_label_7 => _sv_label_7;


        private static readonly UnityEditorIcon _tab_next = BuildIcon("tab_next");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tab_next" icon.</summary>
        public static UnityEditorIcon tab_next => _tab_next;


        private static readonly UnityEditorIcon _tab_next2x = BuildIcon("tab_next@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tab_next@2x" icon.</summary>
        public static UnityEditorIcon tab_next2x => _tab_next2x;


        private static readonly UnityEditorIcon _tab_prev = BuildIcon("tab_prev");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tab_prev" icon.</summary>
        public static UnityEditorIcon tab_prev => _tab_prev;


        private static readonly UnityEditorIcon _tab_prev2x = BuildIcon("tab_prev@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tab_prev@2x" icon.</summary>
        public static UnityEditorIcon tab_prev2x => _tab_prev2x;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolAdd = BuildIcon("TerrainInspector.TerrainToolAdd");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolAdd" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolAdd => _TerrainInspector_TerrainToolAdd;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolLower_On = BuildIcon("TerrainInspector.TerrainToolLower On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolLower On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolLower_On => _TerrainInspector_TerrainToolLower_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolLower = BuildIcon("TerrainInspector.TerrainToolLower");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolLower" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolLower => _TerrainInspector_TerrainToolLower;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolLowerAlt = BuildIcon("TerrainInspector.TerrainToolLowerAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolLowerAlt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolLowerAlt => _TerrainInspector_TerrainToolLowerAlt;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolPlants_On = BuildIcon("TerrainInspector.TerrainToolPlants On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolPlants On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolPlants_On => _TerrainInspector_TerrainToolPlants_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolPlants = BuildIcon("TerrainInspector.TerrainToolPlants");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolPlants" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolPlants => _TerrainInspector_TerrainToolPlants;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolPlantsAlt_On = BuildIcon("TerrainInspector.TerrainToolPlantsAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolPlantsAlt On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolPlantsAlt_On => _TerrainInspector_TerrainToolPlantsAlt_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolPlantsAlt = BuildIcon("TerrainInspector.TerrainToolPlantsAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolPlantsAlt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolPlantsAlt => _TerrainInspector_TerrainToolPlantsAlt;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolRaise_On = BuildIcon("TerrainInspector.TerrainToolRaise On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolRaise On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolRaise_On => _TerrainInspector_TerrainToolRaise_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolRaise = BuildIcon("TerrainInspector.TerrainToolRaise");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolRaise" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolRaise => _TerrainInspector_TerrainToolRaise;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSculpt_On = BuildIcon("TerrainInspector.TerrainToolSculpt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSculpt On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSculpt_On => _TerrainInspector_TerrainToolSculpt_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSculpt = BuildIcon("TerrainInspector.TerrainToolSculpt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSculpt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSculpt => _TerrainInspector_TerrainToolSculpt;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSetheight_On = BuildIcon("TerrainInspector.TerrainToolSetheight On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSetheight On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSetheight_On => _TerrainInspector_TerrainToolSetheight_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSetheight = BuildIcon("TerrainInspector.TerrainToolSetheight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSetheight" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSetheight => _TerrainInspector_TerrainToolSetheight;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSetheightAlt_On = BuildIcon("TerrainInspector.TerrainToolSetheightAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSetheightAlt On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSetheightAlt_On => _TerrainInspector_TerrainToolSetheightAlt_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSetheightAlt = BuildIcon("TerrainInspector.TerrainToolSetheightAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSetheightAlt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSetheightAlt => _TerrainInspector_TerrainToolSetheightAlt;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSettings_On = BuildIcon("TerrainInspector.TerrainToolSettings On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSettings On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSettings_On => _TerrainInspector_TerrainToolSettings_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSettings = BuildIcon("TerrainInspector.TerrainToolSettings");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSettings" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSettings => _TerrainInspector_TerrainToolSettings;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSmoothHeight_On = BuildIcon("TerrainInspector.TerrainToolSmoothHeight On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSmoothHeight On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSmoothHeight_On => _TerrainInspector_TerrainToolSmoothHeight_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSmoothHeight = BuildIcon("TerrainInspector.TerrainToolSmoothHeight");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSmoothHeight" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSmoothHeight => _TerrainInspector_TerrainToolSmoothHeight;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSplat_On = BuildIcon("TerrainInspector.TerrainToolSplat On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSplat On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSplat_On => _TerrainInspector_TerrainToolSplat_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSplat = BuildIcon("TerrainInspector.TerrainToolSplat");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSplat" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSplat => _TerrainInspector_TerrainToolSplat;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSplatAlt_On = BuildIcon("TerrainInspector.TerrainToolSplatAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSplatAlt On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSplatAlt_On => _TerrainInspector_TerrainToolSplatAlt_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolSplatAlt = BuildIcon("TerrainInspector.TerrainToolSplatAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolSplatAlt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolSplatAlt => _TerrainInspector_TerrainToolSplatAlt;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolTrees_On = BuildIcon("TerrainInspector.TerrainToolTrees On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolTrees On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolTrees_On => _TerrainInspector_TerrainToolTrees_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolTrees = BuildIcon("TerrainInspector.TerrainToolTrees");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolTrees" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolTrees => _TerrainInspector_TerrainToolTrees;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolTreesAlt_On = BuildIcon("TerrainInspector.TerrainToolTreesAlt On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolTreesAlt On" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolTreesAlt_On => _TerrainInspector_TerrainToolTreesAlt_On;


        private static readonly UnityEditorIcon _TerrainInspector_TerrainToolTreesAlt = BuildIcon("TerrainInspector.TerrainToolTreesAlt");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TerrainInspector.TerrainToolTreesAlt" icon.</summary>
        public static UnityEditorIcon TerrainInspector_TerrainToolTreesAlt => _TerrainInspector_TerrainToolTreesAlt;


        private static readonly UnityEditorIcon _TestFailed = BuildIcon("TestFailed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestFailed" icon.</summary>
        public static UnityEditorIcon TestFailed => _TestFailed;


        private static readonly UnityEditorIcon _TestIgnored = BuildIcon("TestIgnored");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestIgnored" icon.</summary>
        public static UnityEditorIcon TestIgnored => _TestIgnored;


        private static readonly UnityEditorIcon _TestInconclusive = BuildIcon("TestInconclusive");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestInconclusive" icon.</summary>
        public static UnityEditorIcon TestInconclusive => _TestInconclusive;


        private static readonly UnityEditorIcon _TestNormal = BuildIcon("TestNormal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestNormal" icon.</summary>
        public static UnityEditorIcon TestNormal => _TestNormal;


        private static readonly UnityEditorIcon _TestPassed = BuildIcon("TestPassed");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestPassed" icon.</summary>
        public static UnityEditorIcon TestPassed => _TestPassed;


        private static readonly UnityEditorIcon _TestStopwatch = BuildIcon("TestStopwatch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TestStopwatch" icon.</summary>
        public static UnityEditorIcon TestStopwatch => _TestStopwatch;


        private static readonly UnityEditorIcon _ToggleUVOverlay = BuildIcon("ToggleUVOverlay");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToggleUVOverlay" icon.</summary>
        public static UnityEditorIcon ToggleUVOverlay => _ToggleUVOverlay;


        private static readonly UnityEditorIcon _ToggleUVOverlay2x = BuildIcon("ToggleUVOverlay@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToggleUVOverlay@2x" icon.</summary>
        public static UnityEditorIcon ToggleUVOverlay2x => _ToggleUVOverlay2x;


        private static readonly UnityEditorIcon _Toolbar_Minus = BuildIcon("Toolbar Minus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Minus" icon.</summary>
        public static UnityEditorIcon Toolbar_Minus => _Toolbar_Minus;


        private static readonly UnityEditorIcon _Toolbar_Minus2x = BuildIcon("Toolbar Minus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Minus@2x" icon.</summary>
        public static UnityEditorIcon Toolbar_Minus2x => _Toolbar_Minus2x;


        private static readonly UnityEditorIcon _Toolbar_Plus_More = BuildIcon("Toolbar Plus More");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Plus More" icon.</summary>
        public static UnityEditorIcon Toolbar_Plus_More => _Toolbar_Plus_More;


        private static readonly UnityEditorIcon _Toolbar_Plus_More2x = BuildIcon("Toolbar Plus More@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Plus More@2x" icon.</summary>
        public static UnityEditorIcon Toolbar_Plus_More2x => _Toolbar_Plus_More2x;


        private static readonly UnityEditorIcon _Toolbar_Plus = BuildIcon("Toolbar Plus");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Plus" icon.</summary>
        public static UnityEditorIcon Toolbar_Plus => _Toolbar_Plus;


        private static readonly UnityEditorIcon _Toolbar_Plus2x = BuildIcon("Toolbar Plus@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Toolbar Plus@2x" icon.</summary>
        public static UnityEditorIcon Toolbar_Plus2x => _Toolbar_Plus2x;


        private static readonly UnityEditorIcon _ToolHandleCenter = BuildIcon("ToolHandleCenter");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleCenter" icon.</summary>
        public static UnityEditorIcon ToolHandleCenter => _ToolHandleCenter;


        private static readonly UnityEditorIcon _ToolHandleCenter2x = BuildIcon("ToolHandleCenter@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleCenter@2x" icon.</summary>
        public static UnityEditorIcon ToolHandleCenter2x => _ToolHandleCenter2x;


        private static readonly UnityEditorIcon _ToolHandleGlobal = BuildIcon("ToolHandleGlobal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleGlobal" icon.</summary>
        public static UnityEditorIcon ToolHandleGlobal => _ToolHandleGlobal;


        private static readonly UnityEditorIcon _ToolHandleGlobal2x = BuildIcon("ToolHandleGlobal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleGlobal@2x" icon.</summary>
        public static UnityEditorIcon ToolHandleGlobal2x => _ToolHandleGlobal2x;


        private static readonly UnityEditorIcon _ToolHandleLocal = BuildIcon("ToolHandleLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleLocal" icon.</summary>
        public static UnityEditorIcon ToolHandleLocal => _ToolHandleLocal;


        private static readonly UnityEditorIcon _ToolHandleLocal2x = BuildIcon("ToolHandleLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandleLocal@2x" icon.</summary>
        public static UnityEditorIcon ToolHandleLocal2x => _ToolHandleLocal2x;


        private static readonly UnityEditorIcon _ToolHandlePivot = BuildIcon("ToolHandlePivot");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandlePivot" icon.</summary>
        public static UnityEditorIcon ToolHandlePivot => _ToolHandlePivot;


        private static readonly UnityEditorIcon _ToolHandlePivot2x = BuildIcon("ToolHandlePivot@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolHandlePivot@2x" icon.</summary>
        public static UnityEditorIcon ToolHandlePivot2x => _ToolHandlePivot2x;


        private static readonly UnityEditorIcon _ToolsIcon = BuildIcon("ToolsIcon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ToolsIcon" icon.</summary>
        public static UnityEditorIcon ToolsIcon => _ToolsIcon;


        private static readonly UnityEditorIcon _tranp = BuildIcon("tranp");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tranp" icon.</summary>
        public static UnityEditorIcon tranp => _tranp;


        private static readonly UnityEditorIcon _TransformTool_On = BuildIcon("TransformTool On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TransformTool On" icon.</summary>
        public static UnityEditorIcon TransformTool_On => _TransformTool_On;


        private static readonly UnityEditorIcon _TransformTool_On2x = BuildIcon("TransformTool On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TransformTool On@2x" icon.</summary>
        public static UnityEditorIcon TransformTool_On2x => _TransformTool_On2x;


        private static readonly UnityEditorIcon _TransformTool = BuildIcon("TransformTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TransformTool" icon.</summary>
        public static UnityEditorIcon TransformTool => _TransformTool;


        private static readonly UnityEditorIcon _TransformTool2x = BuildIcon("TransformTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TransformTool@2x" icon.</summary>
        public static UnityEditorIcon TransformTool2x => _TransformTool2x;


        private static readonly UnityEditorIcon _tree_icon = BuildIcon("tree_icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tree_icon" icon.</summary>
        public static UnityEditorIcon tree_icon => _tree_icon;


        private static readonly UnityEditorIcon _tree_icon_branch = BuildIcon("tree_icon_branch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tree_icon_branch" icon.</summary>
        public static UnityEditorIcon tree_icon_branch => _tree_icon_branch;


        private static readonly UnityEditorIcon _tree_icon_branch_frond = BuildIcon("tree_icon_branch_frond");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tree_icon_branch_frond" icon.</summary>
        public static UnityEditorIcon tree_icon_branch_frond => _tree_icon_branch_frond;


        private static readonly UnityEditorIcon _tree_icon_frond = BuildIcon("tree_icon_frond");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tree_icon_frond" icon.</summary>
        public static UnityEditorIcon tree_icon_frond => _tree_icon_frond;


        private static readonly UnityEditorIcon _tree_icon_leaf = BuildIcon("tree_icon_leaf");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "tree_icon_leaf" icon.</summary>
        public static UnityEditorIcon tree_icon_leaf => _tree_icon_leaf;


        private static readonly UnityEditorIcon _TreeEditor_AddBranches = BuildIcon("TreeEditor.AddBranches");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.AddBranches" icon.</summary>
        public static UnityEditorIcon TreeEditor_AddBranches => _TreeEditor_AddBranches;


        private static readonly UnityEditorIcon _TreeEditor_AddLeaves = BuildIcon("TreeEditor.AddLeaves");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.AddLeaves" icon.</summary>
        public static UnityEditorIcon TreeEditor_AddLeaves => _TreeEditor_AddLeaves;


        private static readonly UnityEditorIcon _TreeEditor_Branch_On = BuildIcon("TreeEditor.Branch On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Branch On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Branch_On => _TreeEditor_Branch_On;


        private static readonly UnityEditorIcon _TreeEditor_Branch = BuildIcon("TreeEditor.Branch");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Branch" icon.</summary>
        public static UnityEditorIcon TreeEditor_Branch => _TreeEditor_Branch;


        private static readonly UnityEditorIcon _TreeEditor_BranchFreeHand_On = BuildIcon("TreeEditor.BranchFreeHand On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchFreeHand On" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchFreeHand_On => _TreeEditor_BranchFreeHand_On;


        private static readonly UnityEditorIcon _TreeEditor_BranchFreeHand = BuildIcon("TreeEditor.BranchFreeHand");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchFreeHand" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchFreeHand => _TreeEditor_BranchFreeHand;


        private static readonly UnityEditorIcon _TreeEditor_BranchRotate_On = BuildIcon("TreeEditor.BranchRotate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchRotate On" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchRotate_On => _TreeEditor_BranchRotate_On;


        private static readonly UnityEditorIcon _TreeEditor_BranchRotate = BuildIcon("TreeEditor.BranchRotate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchRotate" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchRotate => _TreeEditor_BranchRotate;


        private static readonly UnityEditorIcon _TreeEditor_BranchScale_On = BuildIcon("TreeEditor.BranchScale On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchScale On" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchScale_On => _TreeEditor_BranchScale_On;


        private static readonly UnityEditorIcon _TreeEditor_BranchScale = BuildIcon("TreeEditor.BranchScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchScale" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchScale => _TreeEditor_BranchScale;


        private static readonly UnityEditorIcon _TreeEditor_BranchTranslate_On = BuildIcon("TreeEditor.BranchTranslate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchTranslate On" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchTranslate_On => _TreeEditor_BranchTranslate_On;


        private static readonly UnityEditorIcon _TreeEditor_BranchTranslate = BuildIcon("TreeEditor.BranchTranslate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.BranchTranslate" icon.</summary>
        public static UnityEditorIcon TreeEditor_BranchTranslate => _TreeEditor_BranchTranslate;


        private static readonly UnityEditorIcon _TreeEditor_Distribution_On = BuildIcon("TreeEditor.Distribution On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Distribution On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Distribution_On => _TreeEditor_Distribution_On;


        private static readonly UnityEditorIcon _TreeEditor_Distribution = BuildIcon("TreeEditor.Distribution");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Distribution" icon.</summary>
        public static UnityEditorIcon TreeEditor_Distribution => _TreeEditor_Distribution;


        private static readonly UnityEditorIcon _TreeEditor_Duplicate = BuildIcon("TreeEditor.Duplicate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Duplicate" icon.</summary>
        public static UnityEditorIcon TreeEditor_Duplicate => _TreeEditor_Duplicate;


        private static readonly UnityEditorIcon _TreeEditor_Geometry_On = BuildIcon("TreeEditor.Geometry On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Geometry On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Geometry_On => _TreeEditor_Geometry_On;


        private static readonly UnityEditorIcon _TreeEditor_Geometry = BuildIcon("TreeEditor.Geometry");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Geometry" icon.</summary>
        public static UnityEditorIcon TreeEditor_Geometry => _TreeEditor_Geometry;


        private static readonly UnityEditorIcon _TreeEditor_Leaf_On = BuildIcon("TreeEditor.Leaf On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Leaf On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Leaf_On => _TreeEditor_Leaf_On;


        private static readonly UnityEditorIcon _TreeEditor_Leaf = BuildIcon("TreeEditor.Leaf");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Leaf" icon.</summary>
        public static UnityEditorIcon TreeEditor_Leaf => _TreeEditor_Leaf;


        private static readonly UnityEditorIcon _TreeEditor_LeafFreeHand_On = BuildIcon("TreeEditor.LeafFreeHand On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafFreeHand On" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafFreeHand_On => _TreeEditor_LeafFreeHand_On;


        private static readonly UnityEditorIcon _TreeEditor_LeafFreeHand = BuildIcon("TreeEditor.LeafFreeHand");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafFreeHand" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafFreeHand => _TreeEditor_LeafFreeHand;


        private static readonly UnityEditorIcon _TreeEditor_LeafRotate_On = BuildIcon("TreeEditor.LeafRotate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafRotate On" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafRotate_On => _TreeEditor_LeafRotate_On;


        private static readonly UnityEditorIcon _TreeEditor_LeafRotate = BuildIcon("TreeEditor.LeafRotate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafRotate" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafRotate => _TreeEditor_LeafRotate;


        private static readonly UnityEditorIcon _TreeEditor_LeafScale_On = BuildIcon("TreeEditor.LeafScale On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafScale On" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafScale_On => _TreeEditor_LeafScale_On;


        private static readonly UnityEditorIcon _TreeEditor_LeafScale = BuildIcon("TreeEditor.LeafScale");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafScale" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafScale => _TreeEditor_LeafScale;


        private static readonly UnityEditorIcon _TreeEditor_LeafTranslate_On = BuildIcon("TreeEditor.LeafTranslate On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafTranslate On" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafTranslate_On => _TreeEditor_LeafTranslate_On;


        private static readonly UnityEditorIcon _TreeEditor_LeafTranslate = BuildIcon("TreeEditor.LeafTranslate");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.LeafTranslate" icon.</summary>
        public static UnityEditorIcon TreeEditor_LeafTranslate => _TreeEditor_LeafTranslate;


        private static readonly UnityEditorIcon _TreeEditor_Material_On = BuildIcon("TreeEditor.Material On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Material On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Material_On => _TreeEditor_Material_On;


        private static readonly UnityEditorIcon _TreeEditor_Material = BuildIcon("TreeEditor.Material");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Material" icon.</summary>
        public static UnityEditorIcon TreeEditor_Material => _TreeEditor_Material;


        private static readonly UnityEditorIcon _TreeEditor_Refresh = BuildIcon("TreeEditor.Refresh");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Refresh" icon.</summary>
        public static UnityEditorIcon TreeEditor_Refresh => _TreeEditor_Refresh;


        private static readonly UnityEditorIcon _TreeEditor_Trash = BuildIcon("TreeEditor.Trash");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Trash" icon.</summary>
        public static UnityEditorIcon TreeEditor_Trash => _TreeEditor_Trash;


        private static readonly UnityEditorIcon _TreeEditor_Wind_On = BuildIcon("TreeEditor.Wind On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Wind On" icon.</summary>
        public static UnityEditorIcon TreeEditor_Wind_On => _TreeEditor_Wind_On;


        private static readonly UnityEditorIcon _TreeEditor_Wind = BuildIcon("TreeEditor.Wind");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "TreeEditor.Wind" icon.</summary>
        public static UnityEditorIcon TreeEditor_Wind => _TreeEditor_Wind;


        private static readonly UnityEditorIcon _UnityEditor_AnimationWindow = BuildIcon("UnityEditor.AnimationWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.AnimationWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_AnimationWindow => _UnityEditor_AnimationWindow;


        private static readonly UnityEditorIcon _UnityEditor_AnimationWindow2x = BuildIcon("UnityEditor.AnimationWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.AnimationWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_AnimationWindow2x => _UnityEditor_AnimationWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_ConsoleWindow = BuildIcon("UnityEditor.ConsoleWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.ConsoleWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_ConsoleWindow => _UnityEditor_ConsoleWindow;


        private static readonly UnityEditorIcon _UnityEditor_ConsoleWindow2x = BuildIcon("UnityEditor.ConsoleWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.ConsoleWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_ConsoleWindow2x => _UnityEditor_ConsoleWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_DebugInspectorWindow = BuildIcon("UnityEditor.DebugInspectorWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.DebugInspectorWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_DebugInspectorWindow => _UnityEditor_DebugInspectorWindow;


        private static readonly UnityEditorIcon _UnityEditor_FindDependencies = BuildIcon("UnityEditor.FindDependencies");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.FindDependencies" icon.</summary>
        public static UnityEditorIcon UnityEditor_FindDependencies => _UnityEditor_FindDependencies;


        private static readonly UnityEditorIcon _UnityEditor_GameView = BuildIcon("UnityEditor.GameView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.GameView" icon.</summary>
        public static UnityEditorIcon UnityEditor_GameView => _UnityEditor_GameView;


        private static readonly UnityEditorIcon _UnityEditor_GameView2x = BuildIcon("UnityEditor.GameView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.GameView@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_GameView2x => _UnityEditor_GameView2x;


        private static readonly UnityEditorIcon _UnityEditor_Graphs_AnimatorControllerTool = BuildIcon("UnityEditor.Graphs.AnimatorControllerTool");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.Graphs.AnimatorControllerTool" icon.</summary>
        public static UnityEditorIcon UnityEditor_Graphs_AnimatorControllerTool => _UnityEditor_Graphs_AnimatorControllerTool;


        private static readonly UnityEditorIcon _UnityEditor_Graphs_AnimatorControllerTool2x = BuildIcon("UnityEditor.Graphs.AnimatorControllerTool@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.Graphs.AnimatorControllerTool@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_Graphs_AnimatorControllerTool2x => _UnityEditor_Graphs_AnimatorControllerTool2x;


        private static readonly UnityEditorIcon _UnityEditor_HierarchyWindow = BuildIcon("UnityEditor.HierarchyWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.HierarchyWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_HierarchyWindow => _UnityEditor_HierarchyWindow;


        private static readonly UnityEditorIcon _UnityEditor_HierarchyWindow2x = BuildIcon("UnityEditor.HierarchyWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.HierarchyWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_HierarchyWindow2x => _UnityEditor_HierarchyWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_InspectorWindow = BuildIcon("UnityEditor.InspectorWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.InspectorWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_InspectorWindow => _UnityEditor_InspectorWindow;


        private static readonly UnityEditorIcon _UnityEditor_InspectorWindow2x = BuildIcon("UnityEditor.InspectorWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.InspectorWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_InspectorWindow2x => _UnityEditor_InspectorWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_ProfilerWindow = BuildIcon("UnityEditor.ProfilerWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.ProfilerWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_ProfilerWindow => _UnityEditor_ProfilerWindow;


        private static readonly UnityEditorIcon _UnityEditor_ProfilerWindow2x = BuildIcon("UnityEditor.ProfilerWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.ProfilerWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_ProfilerWindow2x => _UnityEditor_ProfilerWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_SceneHierarchyWindow = BuildIcon("UnityEditor.SceneHierarchyWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.SceneHierarchyWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_SceneHierarchyWindow => _UnityEditor_SceneHierarchyWindow;


        private static readonly UnityEditorIcon _UnityEditor_SceneHierarchyWindow2x = BuildIcon("UnityEditor.SceneHierarchyWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.SceneHierarchyWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_SceneHierarchyWindow2x => _UnityEditor_SceneHierarchyWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_SceneView = BuildIcon("UnityEditor.SceneView");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.SceneView" icon.</summary>
        public static UnityEditorIcon UnityEditor_SceneView => _UnityEditor_SceneView;


        private static readonly UnityEditorIcon _UnityEditor_SceneView2x = BuildIcon("UnityEditor.SceneView@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.SceneView@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_SceneView2x => _UnityEditor_SceneView2x;


        private static readonly UnityEditorIcon _UnityEditor_Timeline_TimelineWindow = BuildIcon("UnityEditor.Timeline.TimelineWindow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.Timeline.TimelineWindow" icon.</summary>
        public static UnityEditorIcon UnityEditor_Timeline_TimelineWindow => _UnityEditor_Timeline_TimelineWindow;


        private static readonly UnityEditorIcon _UnityEditor_Timeline_TimelineWindow2x = BuildIcon("UnityEditor.Timeline.TimelineWindow@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.Timeline.TimelineWindow@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_Timeline_TimelineWindow2x => _UnityEditor_Timeline_TimelineWindow2x;


        private static readonly UnityEditorIcon _UnityEditor_VersionControl = BuildIcon("UnityEditor.VersionControl");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.VersionControl" icon.</summary>
        public static UnityEditorIcon UnityEditor_VersionControl => _UnityEditor_VersionControl;


        private static readonly UnityEditorIcon _UnityEditor_VersionControl2x = BuildIcon("UnityEditor.VersionControl@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityEditor.VersionControl@2x" icon.</summary>
        public static UnityEditorIcon UnityEditor_VersionControl2x => _UnityEditor_VersionControl2x;


        private static readonly UnityEditorIcon _d_DefaultToolContext_Icon = BuildIcon("d_DefaultToolContext Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_DefaultToolContext Icon" icon.</summary>
        public static UnityEditorIcon d_DefaultToolContext_Icon => _d_DefaultToolContext_Icon;


        private static readonly UnityEditorIcon _DefaultToolContext_Icon = BuildIcon("DefaultToolContext Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "DefaultToolContext Icon" icon.</summary>
        public static UnityEditorIcon DefaultToolContext_Icon => _DefaultToolContext_Icon;


        private static readonly UnityEditorIcon _UnityLogo = BuildIcon("UnityLogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityLogo" icon.</summary>
        public static UnityEditorIcon UnityLogo => _UnityLogo;


        private static readonly UnityEditorIcon _UnityLogoLarge = BuildIcon("UnityLogoLarge");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnityLogoLarge" icon.</summary>
        public static UnityEditorIcon UnityLogoLarge => _UnityLogoLarge;


        private static readonly UnityEditorIcon _UnLinked = BuildIcon("UnLinked");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnLinked" icon.</summary>
        public static UnityEditorIcon UnLinked => _UnLinked;


        private static readonly UnityEditorIcon _UnLinked2x = BuildIcon("UnLinked@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UnLinked@2x" icon.</summary>
        public static UnityEditorIcon UnLinked2x => _UnLinked2x;


        private static readonly UnityEditorIcon _UpArrow = BuildIcon("UpArrow");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "UpArrow" icon.</summary>
        public static UnityEditorIcon UpArrow => _UpArrow;


        private static readonly UnityEditorIcon _Valid = BuildIcon("Valid");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Valid" icon.</summary>
        public static UnityEditorIcon Valid => _Valid;


        private static readonly UnityEditorIcon _Valid2x = BuildIcon("Valid@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Valid@2x" icon.</summary>
        public static UnityEditorIcon Valid2x => _Valid2x;


        private static readonly UnityEditorIcon _d_File = BuildIcon("d_File");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_File" icon.</summary>
        public static UnityEditorIcon d_File => _d_File;


        private static readonly UnityEditorIcon _d_File2x = BuildIcon("d_File@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_File@2x" icon.</summary>
        public static UnityEditorIcon d_File2x => _d_File2x;


        private static readonly UnityEditorIcon _d_Incoming_Icon = BuildIcon("d_Incoming Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Incoming Icon" icon.</summary>
        public static UnityEditorIcon d_Incoming_Icon => _d_Incoming_Icon;


        private static readonly UnityEditorIcon _d_Incoming_Icon2x = BuildIcon("d_Incoming Icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Incoming Icon@2x" icon.</summary>
        public static UnityEditorIcon d_Incoming_Icon2x => _d_Incoming_Icon2x;


        private static readonly UnityEditorIcon _d_Outgoing_Icon = BuildIcon("d_Outgoing Icon@");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Outgoing Icon@" icon.</summary>
        public static UnityEditorIcon d_Outgoing_Icon => _d_Outgoing_Icon;


        private static readonly UnityEditorIcon _d_Outgoing_Icon2x = BuildIcon("d_Outgoing Icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_Outgoing Icon@2x" icon.</summary>
        public static UnityEditorIcon d_Outgoing_Icon2x => _d_Outgoing_Icon2x;


        private static readonly UnityEditorIcon _d_P4_AddedLocal = BuildIcon("d_P4_AddedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_AddedLocal" icon.</summary>
        public static UnityEditorIcon d_P4_AddedLocal => _d_P4_AddedLocal;


        private static readonly UnityEditorIcon _d_P4_AddedLocal2x = BuildIcon("d_P4_AddedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_AddedLocal@2x" icon.</summary>
        public static UnityEditorIcon d_P4_AddedLocal2x => _d_P4_AddedLocal2x;


        private static readonly UnityEditorIcon _d_P4_AddedRemote = BuildIcon("d_P4_AddedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_AddedRemote" icon.</summary>
        public static UnityEditorIcon d_P4_AddedRemote => _d_P4_AddedRemote;


        private static readonly UnityEditorIcon _d_P4_AddedRemote2x = BuildIcon("d_P4_AddedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_AddedRemote@2x" icon.</summary>
        public static UnityEditorIcon d_P4_AddedRemote2x => _d_P4_AddedRemote2x;


        private static readonly UnityEditorIcon _d_P4_BlueLeftParenthesis = BuildIcon("d_P4_BlueLeftParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_BlueLeftParenthesis" icon.</summary>
        public static UnityEditorIcon d_P4_BlueLeftParenthesis => _d_P4_BlueLeftParenthesis;


        private static readonly UnityEditorIcon _d_P4_BlueLeftParenthesis2x = BuildIcon("d_P4_BlueLeftParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_BlueLeftParenthesis@2x" icon.</summary>
        public static UnityEditorIcon d_P4_BlueLeftParenthesis2x => _d_P4_BlueLeftParenthesis2x;


        private static readonly UnityEditorIcon _d_P4_BlueRightParenthesis = BuildIcon("d_P4_BlueRightParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_BlueRightParenthesis" icon.</summary>
        public static UnityEditorIcon d_P4_BlueRightParenthesis => _d_P4_BlueRightParenthesis;


        private static readonly UnityEditorIcon _d_P4_BlueRightParenthesis2x = BuildIcon("d_P4_BlueRightParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_BlueRightParenthesis@2x" icon.</summary>
        public static UnityEditorIcon d_P4_BlueRightParenthesis2x => _d_P4_BlueRightParenthesis2x;


        private static readonly UnityEditorIcon _d_P4_CheckOutLocal = BuildIcon("d_P4_CheckOutLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_CheckOutLocal" icon.</summary>
        public static UnityEditorIcon d_P4_CheckOutLocal => _d_P4_CheckOutLocal;


        private static readonly UnityEditorIcon _d_P4_CheckOutLocal2x = BuildIcon("d_P4_CheckOutLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_CheckOutLocal@2x" icon.</summary>
        public static UnityEditorIcon d_P4_CheckOutLocal2x => _d_P4_CheckOutLocal2x;


        private static readonly UnityEditorIcon _d_P4_CheckOutRemote = BuildIcon("d_P4_CheckOutRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_CheckOutRemote" icon.</summary>
        public static UnityEditorIcon d_P4_CheckOutRemote => _d_P4_CheckOutRemote;


        private static readonly UnityEditorIcon _d_P4_CheckOutRemote2x = BuildIcon("d_P4_CheckOutRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_CheckOutRemote@2x" icon.</summary>
        public static UnityEditorIcon d_P4_CheckOutRemote2x => _d_P4_CheckOutRemote2x;


        private static readonly UnityEditorIcon _d_P4_Conflicted = BuildIcon("d_P4_Conflicted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Conflicted" icon.</summary>
        public static UnityEditorIcon d_P4_Conflicted => _d_P4_Conflicted;


        private static readonly UnityEditorIcon _d_P4_Conflicted2x = BuildIcon("d_P4_Conflicted@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Conflicted@2x" icon.</summary>
        public static UnityEditorIcon d_P4_Conflicted2x => _d_P4_Conflicted2x;


        private static readonly UnityEditorIcon _d_P4_DeletedLocal = BuildIcon("d_P4_DeletedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_DeletedLocal" icon.</summary>
        public static UnityEditorIcon d_P4_DeletedLocal => _d_P4_DeletedLocal;


        private static readonly UnityEditorIcon _d_P4_DeletedLocal2x = BuildIcon("d_P4_DeletedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_DeletedLocal@2x" icon.</summary>
        public static UnityEditorIcon d_P4_DeletedLocal2x => _d_P4_DeletedLocal2x;


        private static readonly UnityEditorIcon _d_P4_DeletedRemote = BuildIcon("d_P4_DeletedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_DeletedRemote" icon.</summary>
        public static UnityEditorIcon d_P4_DeletedRemote => _d_P4_DeletedRemote;


        private static readonly UnityEditorIcon _d_P4_DeletedRemote2x = BuildIcon("d_P4_DeletedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_DeletedRemote@2x" icon.</summary>
        public static UnityEditorIcon d_P4_DeletedRemote2x => _d_P4_DeletedRemote2x;


        private static readonly UnityEditorIcon _d_P4_Local = BuildIcon("d_P4_Local");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Local" icon.</summary>
        public static UnityEditorIcon d_P4_Local => _d_P4_Local;


        private static readonly UnityEditorIcon _d_P4_Local2x = BuildIcon("d_P4_Local@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Local@2x" icon.</summary>
        public static UnityEditorIcon d_P4_Local2x => _d_P4_Local2x;


        private static readonly UnityEditorIcon _d_P4_LockedLocal = BuildIcon("d_P4_LockedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_LockedLocal" icon.</summary>
        public static UnityEditorIcon d_P4_LockedLocal => _d_P4_LockedLocal;


        private static readonly UnityEditorIcon _d_P4_LockedLocal2x = BuildIcon("d_P4_LockedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_LockedLocal@2x" icon.</summary>
        public static UnityEditorIcon d_P4_LockedLocal2x => _d_P4_LockedLocal2x;


        private static readonly UnityEditorIcon _d_P4_LockedRemote = BuildIcon("d_P4_LockedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_LockedRemote" icon.</summary>
        public static UnityEditorIcon d_P4_LockedRemote => _d_P4_LockedRemote;


        private static readonly UnityEditorIcon _d_P4_LockedRemote2x = BuildIcon("d_P4_LockedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_LockedRemote@2x" icon.</summary>
        public static UnityEditorIcon d_P4_LockedRemote2x => _d_P4_LockedRemote2x;


        private static readonly UnityEditorIcon _d_P4_Offline = BuildIcon("d_P4_Offline");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Offline" icon.</summary>
        public static UnityEditorIcon d_P4_Offline => _d_P4_Offline;


        private static readonly UnityEditorIcon _d_P4_Offline2x = BuildIcon("d_P4_Offline@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Offline@2x" icon.</summary>
        public static UnityEditorIcon d_P4_Offline2x => _d_P4_Offline2x;


        private static readonly UnityEditorIcon _d_P4_OutOfSync = BuildIcon("d_P4_OutOfSync");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_OutOfSync" icon.</summary>
        public static UnityEditorIcon d_P4_OutOfSync => _d_P4_OutOfSync;


        private static readonly UnityEditorIcon _d_P4_OutOfSync2x = BuildIcon("d_P4_OutOfSync@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_OutOfSync@2x" icon.</summary>
        public static UnityEditorIcon d_P4_OutOfSync2x => _d_P4_OutOfSync2x;


        private static readonly UnityEditorIcon _d_P4_RedLeftParenthesis = BuildIcon("d_P4_RedLeftParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_RedLeftParenthesis" icon.</summary>
        public static UnityEditorIcon d_P4_RedLeftParenthesis => _d_P4_RedLeftParenthesis;


        private static readonly UnityEditorIcon _d_P4_RedLeftParenthesis2x = BuildIcon("d_P4_RedLeftParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_RedLeftParenthesis@2x" icon.</summary>
        public static UnityEditorIcon d_P4_RedLeftParenthesis2x => _d_P4_RedLeftParenthesis2x;


        private static readonly UnityEditorIcon _d_P4_RedRightParenthesis = BuildIcon("d_P4_RedRightParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_RedRightParenthesis" icon.</summary>
        public static UnityEditorIcon d_P4_RedRightParenthesis => _d_P4_RedRightParenthesis;


        private static readonly UnityEditorIcon _d_P4_RedRightParenthesis2x = BuildIcon("d_P4_RedRightParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_RedRightParenthesis@2x" icon.</summary>
        public static UnityEditorIcon d_P4_RedRightParenthesis2x => _d_P4_RedRightParenthesis2x;


        private static readonly UnityEditorIcon _d_P4_Updating = BuildIcon("d_P4_Updating");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Updating" icon.</summary>
        public static UnityEditorIcon d_P4_Updating => _d_P4_Updating;


        private static readonly UnityEditorIcon _d_P4_Updating2x = BuildIcon("d_P4_Updating@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "d_P4_Updating@2x" icon.</summary>
        public static UnityEditorIcon d_P4_Updating2x => _d_P4_Updating2x;


        private static readonly UnityEditorIcon _File = BuildIcon("File");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "File" icon.</summary>
        public static UnityEditorIcon File => _File;


        private static readonly UnityEditorIcon _File2x = BuildIcon("File@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "File@2x" icon.</summary>
        public static UnityEditorIcon File2x => _File2x;


        private static readonly UnityEditorIcon _Incoming_Icon = BuildIcon("Incoming Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Incoming Icon" icon.</summary>
        public static UnityEditorIcon Incoming_Icon => _Incoming_Icon;


        private static readonly UnityEditorIcon _Incoming_Icon2x = BuildIcon("Incoming Icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Incoming Icon@2x" icon.</summary>
        public static UnityEditorIcon Incoming_Icon2x => _Incoming_Icon2x;


        private static readonly UnityEditorIcon _Incoming_On_Icon = BuildIcon("Incoming On Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Incoming On Icon" icon.</summary>
        public static UnityEditorIcon Incoming_On_Icon => _Incoming_On_Icon;


        private static readonly UnityEditorIcon _Incoming_On_Icon2x = BuildIcon("Incoming On Icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Incoming On Icon@2x" icon.</summary>
        public static UnityEditorIcon Incoming_On_Icon2x => _Incoming_On_Icon2x;


        private static readonly UnityEditorIcon _Outgoing_Icon = BuildIcon("Outgoing Icon");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Outgoing Icon" icon.</summary>
        public static UnityEditorIcon Outgoing_Icon => _Outgoing_Icon;


        private static readonly UnityEditorIcon _Outgoing_Icon2x = BuildIcon("Outgoing Icon@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "Outgoing Icon@2x" icon.</summary>
        public static UnityEditorIcon Outgoing_Icon2x => _Outgoing_Icon2x;


        private static readonly UnityEditorIcon _P4_AddedLocal = BuildIcon("P4_AddedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_AddedLocal" icon.</summary>
        public static UnityEditorIcon P4_AddedLocal => _P4_AddedLocal;


        private static readonly UnityEditorIcon _P4_AddedLocal2x = BuildIcon("P4_AddedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_AddedLocal@2x" icon.</summary>
        public static UnityEditorIcon P4_AddedLocal2x => _P4_AddedLocal2x;


        private static readonly UnityEditorIcon _P4_AddedRemote = BuildIcon("P4_AddedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_AddedRemote" icon.</summary>
        public static UnityEditorIcon P4_AddedRemote => _P4_AddedRemote;


        private static readonly UnityEditorIcon _P4_AddedRemote2x = BuildIcon("P4_AddedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_AddedRemote@2x" icon.</summary>
        public static UnityEditorIcon P4_AddedRemote2x => _P4_AddedRemote2x;


        private static readonly UnityEditorIcon _P4_BlueLeftParenthesis = BuildIcon("P4_BlueLeftParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_BlueLeftParenthesis" icon.</summary>
        public static UnityEditorIcon P4_BlueLeftParenthesis => _P4_BlueLeftParenthesis;


        private static readonly UnityEditorIcon _P4_BlueLeftParenthesis2x = BuildIcon("P4_BlueLeftParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_BlueLeftParenthesis@2x" icon.</summary>
        public static UnityEditorIcon P4_BlueLeftParenthesis2x => _P4_BlueLeftParenthesis2x;


        private static readonly UnityEditorIcon _P4_BlueRightParenthesis = BuildIcon("P4_BlueRightParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_BlueRightParenthesis" icon.</summary>
        public static UnityEditorIcon P4_BlueRightParenthesis => _P4_BlueRightParenthesis;


        private static readonly UnityEditorIcon _P4_BlueRightParenthesis2x = BuildIcon("P4_BlueRightParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_BlueRightParenthesis@2x" icon.</summary>
        public static UnityEditorIcon P4_BlueRightParenthesis2x => _P4_BlueRightParenthesis2x;


        private static readonly UnityEditorIcon _P4_CheckOutLocal = BuildIcon("P4_CheckOutLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_CheckOutLocal" icon.</summary>
        public static UnityEditorIcon P4_CheckOutLocal => _P4_CheckOutLocal;


        private static readonly UnityEditorIcon _P4_CheckOutLocal2x = BuildIcon("P4_CheckOutLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_CheckOutLocal@2x" icon.</summary>
        public static UnityEditorIcon P4_CheckOutLocal2x => _P4_CheckOutLocal2x;


        private static readonly UnityEditorIcon _P4_CheckOutRemote = BuildIcon("P4_CheckOutRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_CheckOutRemote" icon.</summary>
        public static UnityEditorIcon P4_CheckOutRemote => _P4_CheckOutRemote;


        private static readonly UnityEditorIcon _P4_CheckOutRemote2x = BuildIcon("P4_CheckOutRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_CheckOutRemote@2x" icon.</summary>
        public static UnityEditorIcon P4_CheckOutRemote2x => _P4_CheckOutRemote2x;


        private static readonly UnityEditorIcon _P4_Conflicted = BuildIcon("P4_Conflicted");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Conflicted" icon.</summary>
        public static UnityEditorIcon P4_Conflicted => _P4_Conflicted;


        private static readonly UnityEditorIcon _P4_Conflicted2x = BuildIcon("P4_Conflicted@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Conflicted@2x" icon.</summary>
        public static UnityEditorIcon P4_Conflicted2x => _P4_Conflicted2x;


        private static readonly UnityEditorIcon _P4_DeletedLocal = BuildIcon("P4_DeletedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_DeletedLocal" icon.</summary>
        public static UnityEditorIcon P4_DeletedLocal => _P4_DeletedLocal;


        private static readonly UnityEditorIcon _P4_DeletedLocal2x = BuildIcon("P4_DeletedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_DeletedLocal@2x" icon.</summary>
        public static UnityEditorIcon P4_DeletedLocal2x => _P4_DeletedLocal2x;


        private static readonly UnityEditorIcon _P4_DeletedRemote = BuildIcon("P4_DeletedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_DeletedRemote" icon.</summary>
        public static UnityEditorIcon P4_DeletedRemote => _P4_DeletedRemote;


        private static readonly UnityEditorIcon _P4_DeletedRemote2x = BuildIcon("P4_DeletedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_DeletedRemote@2x" icon.</summary>
        public static UnityEditorIcon P4_DeletedRemote2x => _P4_DeletedRemote2x;


        private static readonly UnityEditorIcon _P4_Local = BuildIcon("P4_Local");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Local" icon.</summary>
        public static UnityEditorIcon P4_Local => _P4_Local;


        private static readonly UnityEditorIcon _P4_Local2x = BuildIcon("P4_Local@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Local@2x" icon.</summary>
        public static UnityEditorIcon P4_Local2x => _P4_Local2x;


        private static readonly UnityEditorIcon _P4_LockedLocal = BuildIcon("P4_LockedLocal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_LockedLocal" icon.</summary>
        public static UnityEditorIcon P4_LockedLocal => _P4_LockedLocal;


        private static readonly UnityEditorIcon _P4_LockedLocal2x = BuildIcon("P4_LockedLocal@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_LockedLocal@2x" icon.</summary>
        public static UnityEditorIcon P4_LockedLocal2x => _P4_LockedLocal2x;


        private static readonly UnityEditorIcon _P4_LockedRemote = BuildIcon("P4_LockedRemote");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_LockedRemote" icon.</summary>
        public static UnityEditorIcon P4_LockedRemote => _P4_LockedRemote;


        private static readonly UnityEditorIcon _P4_LockedRemote2x = BuildIcon("P4_LockedRemote@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_LockedRemote@2x" icon.</summary>
        public static UnityEditorIcon P4_LockedRemote2x => _P4_LockedRemote2x;


        private static readonly UnityEditorIcon _P4_Offline = BuildIcon("P4_Offline");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Offline" icon.</summary>
        public static UnityEditorIcon P4_Offline => _P4_Offline;


        private static readonly UnityEditorIcon _P4_Offline2x = BuildIcon("P4_Offline@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Offline@2x" icon.</summary>
        public static UnityEditorIcon P4_Offline2x => _P4_Offline2x;


        private static readonly UnityEditorIcon _P4_OutOfSync = BuildIcon("P4_OutOfSync");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_OutOfSync" icon.</summary>
        public static UnityEditorIcon P4_OutOfSync => _P4_OutOfSync;


        private static readonly UnityEditorIcon _P4_OutOfSync2x = BuildIcon("P4_OutOfSync@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_OutOfSync@2x" icon.</summary>
        public static UnityEditorIcon P4_OutOfSync2x => _P4_OutOfSync2x;


        private static readonly UnityEditorIcon _P4_RedLeftParenthesis = BuildIcon("P4_RedLeftParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_RedLeftParenthesis" icon.</summary>
        public static UnityEditorIcon P4_RedLeftParenthesis => _P4_RedLeftParenthesis;


        private static readonly UnityEditorIcon _P4_RedLeftParenthesis2x = BuildIcon("P4_RedLeftParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_RedLeftParenthesis@2x" icon.</summary>
        public static UnityEditorIcon P4_RedLeftParenthesis2x => _P4_RedLeftParenthesis2x;


        private static readonly UnityEditorIcon _P4_RedRightParenthesis = BuildIcon("P4_RedRightParenthesis");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_RedRightParenthesis" icon.</summary>
        public static UnityEditorIcon P4_RedRightParenthesis => _P4_RedRightParenthesis;


        private static readonly UnityEditorIcon _P4_RedRightParenthesis2x = BuildIcon("P4_RedRightParenthesis@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_RedRightParenthesis@2x" icon.</summary>
        public static UnityEditorIcon P4_RedRightParenthesis2x => _P4_RedRightParenthesis2x;


        private static readonly UnityEditorIcon _P4_Updating = BuildIcon("P4_Updating");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Updating" icon.</summary>
        public static UnityEditorIcon P4_Updating => _P4_Updating;


        private static readonly UnityEditorIcon _P4_Updating2x = BuildIcon("P4_Updating@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "P4_Updating@2x" icon.</summary>
        public static UnityEditorIcon P4_Updating2x => _P4_Updating2x;


        private static readonly UnityEditorIcon _VerticalSplit = BuildIcon("VerticalSplit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VerticalSplit" icon.</summary>
        public static UnityEditorIcon VerticalSplit => _VerticalSplit;


        private static readonly UnityEditorIcon _ViewToolMove_On = BuildIcon("ViewToolMove On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolMove On" icon.</summary>
        public static UnityEditorIcon ViewToolMove_On => _ViewToolMove_On;


        private static readonly UnityEditorIcon _ViewToolMove_On2x = BuildIcon("ViewToolMove On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolMove On@2x" icon.</summary>
        public static UnityEditorIcon ViewToolMove_On2x => _ViewToolMove_On2x;


        private static readonly UnityEditorIcon _ViewToolMove = BuildIcon("ViewToolMove");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolMove" icon.</summary>
        public static UnityEditorIcon ViewToolMove => _ViewToolMove;


        private static readonly UnityEditorIcon _ViewToolMove2x = BuildIcon("ViewToolMove@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolMove@2x" icon.</summary>
        public static UnityEditorIcon ViewToolMove2x => _ViewToolMove2x;


        private static readonly UnityEditorIcon _ViewToolOrbit_On = BuildIcon("ViewToolOrbit On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolOrbit On" icon.</summary>
        public static UnityEditorIcon ViewToolOrbit_On => _ViewToolOrbit_On;


        private static readonly UnityEditorIcon _ViewToolOrbit_On2x = BuildIcon("ViewToolOrbit On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolOrbit On@2x" icon.</summary>
        public static UnityEditorIcon ViewToolOrbit_On2x => _ViewToolOrbit_On2x;


        private static readonly UnityEditorIcon _ViewToolOrbit = BuildIcon("ViewToolOrbit");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolOrbit" icon.</summary>
        public static UnityEditorIcon ViewToolOrbit => _ViewToolOrbit;


        private static readonly UnityEditorIcon _ViewToolOrbit2x = BuildIcon("ViewToolOrbit@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolOrbit@2x" icon.</summary>
        public static UnityEditorIcon ViewToolOrbit2x => _ViewToolOrbit2x;


        private static readonly UnityEditorIcon _ViewToolZoom_On = BuildIcon("ViewToolZoom On");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolZoom On" icon.</summary>
        public static UnityEditorIcon ViewToolZoom_On => _ViewToolZoom_On;


        private static readonly UnityEditorIcon _ViewToolZoom_On2x = BuildIcon("ViewToolZoom On@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolZoom On@2x" icon.</summary>
        public static UnityEditorIcon ViewToolZoom_On2x => _ViewToolZoom_On2x;


        private static readonly UnityEditorIcon _ViewToolZoom = BuildIcon("ViewToolZoom");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolZoom" icon.</summary>
        public static UnityEditorIcon ViewToolZoom => _ViewToolZoom;


        private static readonly UnityEditorIcon _ViewToolZoom2x = BuildIcon("ViewToolZoom@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "ViewToolZoom@2x" icon.</summary>
        public static UnityEditorIcon ViewToolZoom2x => _ViewToolZoom2x;


        private static readonly UnityEditorIcon _VisibilityOff = BuildIcon("VisibilityOff");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisibilityOff" icon.</summary>
        public static UnityEditorIcon VisibilityOff => _VisibilityOff;


        private static readonly UnityEditorIcon _VisibilityOn = BuildIcon("VisibilityOn");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VisibilityOn" icon.</summary>
        public static UnityEditorIcon VisibilityOn => _VisibilityOn;


        private static readonly UnityEditorIcon _VUMeterTextureHorizontal = BuildIcon("VUMeterTextureHorizontal");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VUMeterTextureHorizontal" icon.</summary>
        public static UnityEditorIcon VUMeterTextureHorizontal => _VUMeterTextureHorizontal;


        private static readonly UnityEditorIcon _VUMeterTextureVertical = BuildIcon("VUMeterTextureVertical");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "VUMeterTextureVertical" icon.</summary>
        public static UnityEditorIcon VUMeterTextureVertical => _VUMeterTextureVertical;


        private static readonly UnityEditorIcon _WaitSpin00 = BuildIcon("WaitSpin00");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin00" icon.</summary>
        public static UnityEditorIcon WaitSpin00 => _WaitSpin00;


        private static readonly UnityEditorIcon _WaitSpin01 = BuildIcon("WaitSpin01");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin01" icon.</summary>
        public static UnityEditorIcon WaitSpin01 => _WaitSpin01;


        private static readonly UnityEditorIcon _WaitSpin02 = BuildIcon("WaitSpin02");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin02" icon.</summary>
        public static UnityEditorIcon WaitSpin02 => _WaitSpin02;


        private static readonly UnityEditorIcon _WaitSpin03 = BuildIcon("WaitSpin03");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin03" icon.</summary>
        public static UnityEditorIcon WaitSpin03 => _WaitSpin03;


        private static readonly UnityEditorIcon _WaitSpin04 = BuildIcon("WaitSpin04");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin04" icon.</summary>
        public static UnityEditorIcon WaitSpin04 => _WaitSpin04;


        private static readonly UnityEditorIcon _WaitSpin05 = BuildIcon("WaitSpin05");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin05" icon.</summary>
        public static UnityEditorIcon WaitSpin05 => _WaitSpin05;


        private static readonly UnityEditorIcon _WaitSpin06 = BuildIcon("WaitSpin06");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin06" icon.</summary>
        public static UnityEditorIcon WaitSpin06 => _WaitSpin06;


        private static readonly UnityEditorIcon _WaitSpin07 = BuildIcon("WaitSpin07");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin07" icon.</summary>
        public static UnityEditorIcon WaitSpin07 => _WaitSpin07;


        private static readonly UnityEditorIcon _WaitSpin08 = BuildIcon("WaitSpin08");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin08" icon.</summary>
        public static UnityEditorIcon WaitSpin08 => _WaitSpin08;


        private static readonly UnityEditorIcon _WaitSpin09 = BuildIcon("WaitSpin09");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin09" icon.</summary>
        public static UnityEditorIcon WaitSpin09 => _WaitSpin09;


        private static readonly UnityEditorIcon _WaitSpin10 = BuildIcon("WaitSpin10");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin10" icon.</summary>
        public static UnityEditorIcon WaitSpin10 => _WaitSpin10;


        private static readonly UnityEditorIcon _WaitSpin11 = BuildIcon("WaitSpin11");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WaitSpin11" icon.</summary>
        public static UnityEditorIcon WaitSpin11 => _WaitSpin11;


        private static readonly UnityEditorIcon _WelcomeScreen_AssetStoreLogo = BuildIcon("WelcomeScreen.AssetStoreLogo");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "WelcomeScreen.AssetStoreLogo" icon.</summary>
        public static UnityEditorIcon WelcomeScreen_AssetStoreLogo => _WelcomeScreen_AssetStoreLogo;


        private static readonly UnityEditorIcon _winbtn_graph = BuildIcon("winbtn_graph");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_graph" icon.</summary>
        public static UnityEditorIcon winbtn_graph => _winbtn_graph;


        private static readonly UnityEditorIcon _winbtn_graph_close_h = BuildIcon("winbtn_graph_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_graph_close_h" icon.</summary>
        public static UnityEditorIcon winbtn_graph_close_h => _winbtn_graph_close_h;


        private static readonly UnityEditorIcon _winbtn_graph_max_h = BuildIcon("winbtn_graph_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_graph_max_h" icon.</summary>
        public static UnityEditorIcon winbtn_graph_max_h => _winbtn_graph_max_h;


        private static readonly UnityEditorIcon _winbtn_graph_min_h = BuildIcon("winbtn_graph_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_graph_min_h" icon.</summary>
        public static UnityEditorIcon winbtn_graph_min_h => _winbtn_graph_min_h;


        private static readonly UnityEditorIcon _winbtn_mac_close = BuildIcon("winbtn_mac_close");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close => _winbtn_mac_close;


        private static readonly UnityEditorIcon _winbtn_mac_close2x = BuildIcon("winbtn_mac_close@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close2x => _winbtn_mac_close2x;


        private static readonly UnityEditorIcon _winbtn_mac_close_a = BuildIcon("winbtn_mac_close_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close_a" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close_a => _winbtn_mac_close_a;


        private static readonly UnityEditorIcon _winbtn_mac_close_a2x = BuildIcon("winbtn_mac_close_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close_a2x => _winbtn_mac_close_a2x;


        private static readonly UnityEditorIcon _winbtn_mac_close_h = BuildIcon("winbtn_mac_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close_h" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close_h => _winbtn_mac_close_h;


        private static readonly UnityEditorIcon _winbtn_mac_close_h2x = BuildIcon("winbtn_mac_close_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_close_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_close_h2x => _winbtn_mac_close_h2x;


        private static readonly UnityEditorIcon _winbtn_mac_inact = BuildIcon("winbtn_mac_inact");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_inact" icon.</summary>
        public static UnityEditorIcon winbtn_mac_inact => _winbtn_mac_inact;


        private static readonly UnityEditorIcon _winbtn_mac_inact2x = BuildIcon("winbtn_mac_inact@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_inact@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_inact2x => _winbtn_mac_inact2x;


        private static readonly UnityEditorIcon _winbtn_mac_max = BuildIcon("winbtn_mac_max");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max => _winbtn_mac_max;


        private static readonly UnityEditorIcon _winbtn_mac_max2x = BuildIcon("winbtn_mac_max@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max2x => _winbtn_mac_max2x;


        private static readonly UnityEditorIcon _winbtn_mac_max_a = BuildIcon("winbtn_mac_max_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max_a" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max_a => _winbtn_mac_max_a;


        private static readonly UnityEditorIcon _winbtn_mac_max_a2x = BuildIcon("winbtn_mac_max_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max_a2x => _winbtn_mac_max_a2x;


        private static readonly UnityEditorIcon _winbtn_mac_max_h = BuildIcon("winbtn_mac_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max_h" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max_h => _winbtn_mac_max_h;


        private static readonly UnityEditorIcon _winbtn_mac_max_h2x = BuildIcon("winbtn_mac_max_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_max_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_max_h2x => _winbtn_mac_max_h2x;


        private static readonly UnityEditorIcon _winbtn_mac_min = BuildIcon("winbtn_mac_min");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min => _winbtn_mac_min;


        private static readonly UnityEditorIcon _winbtn_mac_min2x = BuildIcon("winbtn_mac_min@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min2x => _winbtn_mac_min2x;


        private static readonly UnityEditorIcon _winbtn_mac_min_a = BuildIcon("winbtn_mac_min_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min_a" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min_a => _winbtn_mac_min_a;


        private static readonly UnityEditorIcon _winbtn_mac_min_a2x = BuildIcon("winbtn_mac_min_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min_a2x => _winbtn_mac_min_a2x;


        private static readonly UnityEditorIcon _winbtn_mac_min_h = BuildIcon("winbtn_mac_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min_h" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min_h => _winbtn_mac_min_h;


        private static readonly UnityEditorIcon _winbtn_mac_min_h2x = BuildIcon("winbtn_mac_min_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_mac_min_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_mac_min_h2x => _winbtn_mac_min_h2x;


        private static readonly UnityEditorIcon _winbtn_win_close = BuildIcon("winbtn_win_close");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close" icon.</summary>
        public static UnityEditorIcon winbtn_win_close => _winbtn_win_close;


        private static readonly UnityEditorIcon _winbtn_win_close2x = BuildIcon("winbtn_win_close@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_close2x => _winbtn_win_close2x;


        private static readonly UnityEditorIcon _winbtn_win_close_a = BuildIcon("winbtn_win_close_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close_a" icon.</summary>
        public static UnityEditorIcon winbtn_win_close_a => _winbtn_win_close_a;


        private static readonly UnityEditorIcon _winbtn_win_close_a2x = BuildIcon("winbtn_win_close_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_close_a2x => _winbtn_win_close_a2x;


        private static readonly UnityEditorIcon _winbtn_win_close_h = BuildIcon("winbtn_win_close_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close_h" icon.</summary>
        public static UnityEditorIcon winbtn_win_close_h => _winbtn_win_close_h;


        private static readonly UnityEditorIcon _winbtn_win_close_h2x = BuildIcon("winbtn_win_close_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_close_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_close_h2x => _winbtn_win_close_h2x;


        private static readonly UnityEditorIcon _winbtn_win_max = BuildIcon("winbtn_win_max");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max" icon.</summary>
        public static UnityEditorIcon winbtn_win_max => _winbtn_win_max;


        private static readonly UnityEditorIcon _winbtn_win_max2x = BuildIcon("winbtn_win_max@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_max2x => _winbtn_win_max2x;


        private static readonly UnityEditorIcon _winbtn_win_max_a = BuildIcon("winbtn_win_max_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max_a" icon.</summary>
        public static UnityEditorIcon winbtn_win_max_a => _winbtn_win_max_a;


        private static readonly UnityEditorIcon _winbtn_win_max_a2x = BuildIcon("winbtn_win_max_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_max_a2x => _winbtn_win_max_a2x;


        private static readonly UnityEditorIcon _winbtn_win_max_h = BuildIcon("winbtn_win_max_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max_h" icon.</summary>
        public static UnityEditorIcon winbtn_win_max_h => _winbtn_win_max_h;


        private static readonly UnityEditorIcon _winbtn_win_max_h2x = BuildIcon("winbtn_win_max_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_max_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_max_h2x => _winbtn_win_max_h2x;


        private static readonly UnityEditorIcon _winbtn_win_min = BuildIcon("winbtn_win_min");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_min" icon.</summary>
        public static UnityEditorIcon winbtn_win_min => _winbtn_win_min;


        private static readonly UnityEditorIcon _winbtn_win_min_a = BuildIcon("winbtn_win_min_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_min_a" icon.</summary>
        public static UnityEditorIcon winbtn_win_min_a => _winbtn_win_min_a;


        private static readonly UnityEditorIcon _winbtn_win_min_h = BuildIcon("winbtn_win_min_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_min_h" icon.</summary>
        public static UnityEditorIcon winbtn_win_min_h => _winbtn_win_min_h;


        private static readonly UnityEditorIcon _winbtn_win_rest = BuildIcon("winbtn_win_rest");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_rest" icon.</summary>
        public static UnityEditorIcon winbtn_win_rest => _winbtn_win_rest;


        private static readonly UnityEditorIcon _winbtn_win_rest_a = BuildIcon("winbtn_win_rest_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_rest_a" icon.</summary>
        public static UnityEditorIcon winbtn_win_rest_a => _winbtn_win_rest_a;


        private static readonly UnityEditorIcon _winbtn_win_rest_h = BuildIcon("winbtn_win_rest_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_rest_h" icon.</summary>
        public static UnityEditorIcon winbtn_win_rest_h => _winbtn_win_rest_h;


        private static readonly UnityEditorIcon _winbtn_win_restore = BuildIcon("winbtn_win_restore");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore => _winbtn_win_restore;


        private static readonly UnityEditorIcon _winbtn_win_restore2x = BuildIcon("winbtn_win_restore@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore2x => _winbtn_win_restore2x;


        private static readonly UnityEditorIcon _winbtn_win_restore_a = BuildIcon("winbtn_win_restore_a");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore_a" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore_a => _winbtn_win_restore_a;


        private static readonly UnityEditorIcon _winbtn_win_restore_a2x = BuildIcon("winbtn_win_restore_a@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore_a@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore_a2x => _winbtn_win_restore_a2x;


        private static readonly UnityEditorIcon _winbtn_win_restore_h = BuildIcon("winbtn_win_restore_h");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore_h" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore_h => _winbtn_win_restore_h;


        private static readonly UnityEditorIcon _winbtn_win_restore_h2x = BuildIcon("winbtn_win_restore_h@2x");
        /// <summary>Returns a <see cref="UnityEditorIcon"> containing the data for the "winbtn_win_restore_h@2x" icon.</summary>
        public static UnityEditorIcon winbtn_win_restore_h2x => _winbtn_win_restore_h2x;

    }
}
