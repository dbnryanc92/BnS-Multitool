﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BnS_Multitool.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BnS_Multitool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon AppIcon {
            get {
                object obj = ResourceManager.GetObject("AppIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] BnS_Multi_Tool_Updater {
            get {
                object obj = ResourceManager.GetObject("BnS_Multi_Tool_Updater", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # target hp
        ///UI.Gauge.CurMax
        ///
        ///# target hp %
        ///UI.Gauge.Percent
        ///
        ///# target range
        ///UI.Target.Distance
        ///
        ///# f8 lobby #
        ///UI.ArenaLobbyDuel.RoomNumber.Link.Text
        ///
        ///# /invite
        ///Usercommand.party-invite1
        ///
        ///# /join
        ///Usercommand.party-suggest-join2
        ///
        ///# dps meter
        ///UI.DamageMeter.DamagePerSecond
        ///
        ///# dps meter player name
        ///UI.DamageMeter.Name.Player
        ///UI.DamageMeter.Name.Pc
        ///
        ///# challengemode stuff
        ///UI.ChallengeParty.*
        ///
        ///# chat tab
        ///UI.Hypertext.*.
        /// </summary>
        internal static string minimal {
            get {
                return ResourceManager.GetString("minimal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;config&gt;
        ///    &lt;options&gt;
        ///        &lt;option name=&quot;useAutoBait&quot; enable=&quot;0&quot; /&gt;
        ///        &lt;option name=&quot;useItemCap&quot; enable=&quot;0&quot; /&gt;
        ///        &lt;option name=&quot;useMarketplace&quot; enable=&quot;0&quot; /&gt;
        ///        &lt;option name=&quot;AutoCombat&quot; enable=&quot;0&quot; useRange=&quot;0&quot; range=&quot;30&quot;/&gt;
        ///        &lt;option name=&quot;useNoCameraLock&quot; enable=&quot;0&quot; /&gt;
        ///    &lt;/options&gt;
        ///    &lt;gcd enable=&quot;0&quot;&gt;
        ///    &lt;/gcd&gt;
        ///&lt;/config&gt;.
        /// </summary>
        internal static string multitool_qol {
            get {
                return ResourceManager.GetString("multitool_qol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;?include .\patches\*.xml?&gt;
        ///&lt;patches&gt;
        ///  &lt;patch file=&quot;system.config2.xml&quot;&gt;
        ///    &lt;select-node query=&quot;/config&quot;&gt;
        ///      &lt;!-- don&apos;t show eula --&gt;
        ///      &lt;select-node query=&quot;./option[@name=&apos;show-clause&apos;]/@value&quot;&gt;
        ///        &lt;set-value value=&quot;false&quot; /&gt;
        ///      &lt;/select-node&gt;
        ///      &lt;!-- disable nagle algorithm in arena --&gt;
        ///      &lt;select-node query=&quot;./option[@name=&apos;use-nagle-arena&apos;]/@value&quot;&gt;
        ///        &lt;set-value value=&quot;false&quot; /&gt;
        ///      &lt;/select-node&gt;
        ///      &lt;!-- simple mode at [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string patches {
            get {
                return ResourceManager.GetString("patches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # include most UI text
        ///-UI.MaxLevelGuide.*
        ///-UI.Action.Credit*
        ///UI.*
        ///
        ///# skill button text
        ///Text_*
        ///
        ///# login keypad button
        ///Text.Otp.*
        ///
        ///# crafting guild name
        ///Craft.N.*
        ///
        ///# unity level
        ///Name.AccountLevel_Name_0??
        ///Name.AccountLevel_Name_1??
        ///
        ///# player name
        ///Name.Pc.*
        ///
        ///# player class, etc
        ///Name.job.*.style?
        ///Name.job.*
        ///Name.race.*
        ///Name.sex.*
        ///
        ///# key name
        ///Name.Key.*
        ///Name.Slot.Key.*
        ///#Name.KeyCommand.*
        ///
        ///# date/time
        ///Name.Time.*
        ///
        ///# party member status
        ///Name.Party.Status.*
        ///Name.Team.Status.*
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string playable_kr {
            get {
                return ResourceManager.GetString("playable_kr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # include most UI text
        ///-UI.MaxLevelGuide.*
        ///-UI.Action.Credit*
        ///UI.*
        ///
        ///# skill button text
        ///Text_*
        ///
        ///# login keypad button
        ///Text.Otp.*
        ///
        ///# crafting guild name
        ///Craft.N.*
        ///
        ///# unity level
        ///Name.AccountLevel_Name_0??
        ///Name.AccountLevel_Name_1??
        ///
        ///# player name
        ///Name.Pc.*
        ///
        ///# player class, etc
        ///Name.job.*.style?
        ///Name.job.*
        ///Name.race.*
        ///Name.sex.*
        ///
        ///# key name
        ///Name.Key.*
        ///Name.Slot.Key.*
        ///#Name.KeyCommand.*
        ///
        ///# date/time
        ///Name.Time.*
        ///
        ///# party member status
        ///Name.Party.Status.*
        ///Name.Team.Status.*
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string playable_ncwest {
            get {
                return ResourceManager.GetString("playable_ncwest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;patches&gt;
        ///  &lt;patch file=&quot;system.config2.xml&quot;&gt;
        ///    &lt;!-- enable ingame login --&gt;
        ///    &lt;select-node query=&quot;/config/option[@name=&apos;region&apos; and (@value=&apos;&apos; or @value=&apos;NCWEST&apos; or @value=&apos;NCTaiwan&apos;)]&quot;&gt;
        ///      &lt;root&gt;
        ///        &lt;select-node query=&quot;/config/option[@name=&apos;use-web-launching&apos;]/@value&quot;&gt;
        ///          &lt;set-value value=&quot;false&quot; /&gt;
        ///        &lt;/select-node&gt; 
        ///      &lt;/root&gt;
        ///    &lt;/select-node&gt;
        ///  &lt;/patch&gt;
        ///  &lt;patch file=&quot;release.config2.xml&quot;&gt;
        ///    &lt;select-node query=&quot;/config&quot;&gt;
        ///      &lt;!-- s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string use_ingame_login {
            get {
                return ResourceManager.GetString("use_ingame_login", resourceCulture);
            }
        }

        internal static string AutoIdSearchNotSupported
        {
            get
            {
                return ResourceManager.GetString("AutoIdSearchNotSupported", resourceCulture);
            }
        }

        internal static string translate
        {
            get
            {
                return ResourceManager.GetString("translate", resourceCulture);
            }
        }
    }
}
