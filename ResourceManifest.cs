using Orchard.UI.Resources;

namespace Onefourseven.AdminLTE {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // These definitions will be replaced by future `Orchard.Resources` module
            //jQueryUI Input Mask
            manifest.DefineScript("jQueryUI_InputMask").SetUrl("input-mask/jquery.inputmask.js").SetVersion("0.0.0").SetDependencies("jQueryUI");
            manifest.DefineScript("jQueryUI_InputMask_Extentions").SetUrl("input-mask/jquery.inputmask.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Date_Extentions").SetUrl("input-mask/jquery.inputmask.date.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Numeric_Extentions").SetUrl("input-mask/jquery.inputmask.numeric.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Phone_Extentions").SetUrl("input-mask/jquery.inputmask.phone.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Regex_Extentions").SetUrl("input-mask/jquery.inputmask.regex.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            
            // AdminLTE specific resources  
            manifest.DefineScript("AdminApp").SetUrl("app.min.js", "app.js").SetVersion("2.3.0").SetDependencies("jQuery");
            manifest.DefineStyle("AdminLTE").SetUrl("AdminLTE.min.css", "AdminLTE.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_all_skins").SetUrl("skins/_all-skins.min.css", "skins/all-skins.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_black_light").SetUrl("skins/skin-black-light.min.css", "skins/skin-black-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_black").SetUrl("skins/skin-black.min.css", "skins/skin-black.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_blue_light").SetUrl("skins/skin-blue-light.min.css", "skins/skin-blue-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_blue").SetUrl("skins/skin-blue.min.css", "skins/skin-blue.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_green_light").SetUrl("skins/skin-green-light.min.css", "skins/skin-green-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_green").SetUrl("skins/skin-green.min.css", "skins/skin-green.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_purple_light").SetUrl("skins/skin-purple-light.min.css", "skins/skin-purple-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_purple").SetUrl("skins/skin-purple.min.css", "skins/skin-purple.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_red_light").SetUrl("skins/skin-red-light.min.css", "skins/skin-red-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_red").SetUrl("skins/skin-red.min.css", "skins/skin-red.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_yellow_light").SetUrl("skins/skin-yellow-light.min.css", "skins/skin-yellow-light.css").SetVersion("2.3.0");
            manifest.DefineStyle("AdminLTE_yellow").SetUrl("skins/skin-yellow.min.css", "skins/skin-yellow.css").SetVersion("2.3.0");

            // iCheck
            manifest.DefineStyle("iCheck").SetUrl("iCheck/all.css");
            manifest.DefineScript("iCheck").SetUrl("iCheck/iCheck.min.js", "iCheck.icheck.js").SetDependencies("jQuery");
        }
    }
}
