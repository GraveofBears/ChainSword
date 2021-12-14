using BepInEx;
using ItemManager;

namespace ChainSword
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class ChainSword : BaseUnityPlugin
    {
        private const string ModName = "ChainSword";
        private const string ModVersion = "0.0.4";
        private const string ModGUID = "org.bepinex.plugins.chainsword";

        public void Awake()
        {
            Item ChainSword = new Item("chainsword", "ChainSword", "Sword");
            ChainSword.Crafting.Add(CraftingTable.Forge, 3);
            ChainSword.RequiredItems.Add("BlackMetal", 14);
            ChainSword.RequiredItems.Add("RoundLog", 4);
            ChainSword.RequiredItems.Add("Wood", 4);
            ChainSword.RequiredUpgradeItems.Add("BlackMetal", 12);
            ChainSword.RequiredUpgradeItems.Add("RoundLog", 2);
            ChainSword.RequiredUpgradeItems.Add("Wood", 2);
            ChainSword.CraftAmount = 1;

        }
    }
}



