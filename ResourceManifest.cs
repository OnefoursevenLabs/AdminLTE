using Orchard.UI.Resources;

namespace Onefourseven.AdminLTE {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // These definitions will be replaced by future `Orchard.Resources` module
            //jQuery
            manifest.DefineScript("jQuery").SetUrl("jQuery-2.1.4.min.js", "jQuery-2.1.4.js").SetVersion("2.1.4").SetCdn("//ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.min.js", "//ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.js", true);

            //jQueryUI
            manifest.DefineScript("jQueryUI").SetUrl("ui/jquery-ui.min.js", "ui/jquery-ui.js").SetVersion("1.11.4").SetDependencies("jQuery").SetCdn("//ajax.aspnetcdn.com/ajax/jquery.ui/1.11.4/jquery-ui.min.js", "//ajax.aspnetcdn.com/ajax/jquery.ui/1.11.4/jquery-ui.js", true);

            //jQueryUI Input Mask
            manifest.DefineScript("jQueryUI_InputMask").SetUrl("input-mask/jquery.inputmask.js").SetVersion("0.0.0").SetDependencies("jQueryUI");
            manifest.DefineScript("jQueryUI_InputMask_Extentions").SetUrl("input-mask/jquery.inputmask.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Date_Extentions").SetUrl("input-mask/jquery.inputmask.date.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Numeric_Extentions").SetUrl("input-mask/jquery.inputmask.numeric.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Phone_Extentions").SetUrl("input-mask/jquery.inputmask.phone.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");
            manifest.DefineScript("jQueryUI_InputMask_Regex_Extentions").SetUrl("input-mask/jquery.inputmask.regex.extenstions.js").SetVersion("0.0.0").SetDependencies("jQueryUI_InputMask");

            // boostrap
            manifest.DefineScript("Bootstrap").SetUrl("bootstrap/js/bootstrap.min.js", "bootstrap/js/bootstrap.js").SetVersion("3.3.4").SetDependencies("jQuery").SetCdn("//ajax.aspnetcdn.com/ajax/bootstrap/3.3.4/bootstrap.min.js", "//ajax.aspnetcdn.com/ajax/bootstrap/3.3.4/bootstrap.js", true);
            manifest.DefineStyle("Bootstrap").SetUrl("boostrap/css/bootstrap.min.css", "boostrap/css/bootstrap.css").SetVersion("3.3.5").SetCdn("//ajax.aspnetcdn.com/ajax/bootstrap/3.3.5/css/bootstrap.min.css", "//ajax.aspnetcdn.com/ajax/bootstrap/3.3.5/css/bootstrap.css", true);

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
