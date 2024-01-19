using Volo.Abp.Settings;

namespace Umi.Settings;

public class UmiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(UmiSettings.MySetting1));
    }
}
