/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace FDOTSerenity.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('FDOTSerenity');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}