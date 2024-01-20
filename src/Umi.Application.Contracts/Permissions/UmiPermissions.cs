namespace Umi.Permissions;

public static class UmiPermissions
{
    public const string GroupName = "Umi";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Shops
    {
        public const string Default = GroupName + ".Shops";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
