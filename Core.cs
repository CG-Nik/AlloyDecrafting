using Alta.Blacksmithing;
using Alta.Inventory;
using CustomRecipesAPI;
using Alta;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

[assembly: MelonInfo(typeof(AlloyDecrafting.Core), "AlloyDecrafting", "1.0.0", "CGNik", null)]
[assembly: MelonGame("Alta", "A Township Tale")]

namespace AlloyDecrafting
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");

            CustomRecipesAPI.Core.SetUpRecipes += SetUpRecipes;
        }

        private void SetUpRecipes()
        {
            AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(MelonEnvironment.ModsDirectory, "AlloyDecrafting/AssetBundles/!alloydecrafting"));
            SmeltingRecipe smeltingRecipe_CarsiDecraft = assetBundle.LoadAsset<SmeltingRecipe>("Carsi Decraft.asset");
            SmeltingRecipe smeltingRecipe_EvinonSteelDecraft = assetBundle.LoadAsset<SmeltingRecipe>("Evinon Steel Decraft.asset");
            SmeltingRecipe smeltingRecipe_OrchiDecraft = assetBundle.LoadAsset<SmeltingRecipe>("Orchi Decraft.asset");
            SmeltingRecipe smeltingRecipe_RedIronDecraft = assetBundle.LoadAsset<SmeltingRecipe>("Red Iron Decraft.asset");
            SmeltingRecipe smeltingRecipe_WhiteGoldDecraft = assetBundle.LoadAsset<SmeltingRecipe>("White Gold Decraft.asset");

            SmelterUpgrades smelterUpgrades_gem1 = SmelterUpgrades.All.Where(upgrade => upgrade.Hash == 23872u).First();
            SmelterUpgrades smelterUpgrades_gem2 = SmelterUpgrades.All.Where(upgrade => upgrade.Hash == 28650u).First();
            SmelterUpgrades smelterUpgrades_gem3 = SmelterUpgrades.All.Where(upgrade => upgrade.Hash == 33428u).First();
            Item crystalShardBlue = Item.All.Where(item => item.Hash == 7824u).First();

            CustomRecipesAPI.Core.itemsToAddToSmelter.Add(crystalShardBlue);

            CustomRecipesAPI.Core.AddSmelterOffsets(
                CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.CopperOre],
                new Vector3(0, -0.6f, -0.6f),
                new Vector3(0, -0.6f, -0.6f)
            );
            CustomRecipesAPI.Core.AddSmelterOffsets(
                CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.IronOre],
                new Vector3(0, -0.6f, -0.6f),
                new Vector3(0, -0.6f, -0.6f)
            );
            CustomRecipesAPI.Core.AddSmelterOffsets(
                CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.GoldOre],
                new Vector3(0, -0.6f, -0.6f),
                new Vector3(0, -0.6f, -0.6f)
            );
            CustomRecipesAPI.Core.AddSmelterOffsets(
                CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverOre],
                new Vector3(0, -0.6f, -0.6f),
                new Vector3(0, -0.6f, -0.6f)
            );
            CustomRecipesAPI.Core.AddSmelterOffsets(
                CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.MythrilOre],
                new Vector3(0, -0.6f, -0.6f),
                new Vector3(0, -0.6f, -0.6f)
            );

            CustomRecipesAPI.Core.SetUpSmeltingRecipe(
                smeltingRecipe_CarsiDecraft,
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.CarsiIngot],
                    crystalShardBlue
                },
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.RedIronIngot],
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverOre]
                },
                smelterUpgrades_gem2,
                true
            );
            CustomRecipesAPI.Core.SetUpSmeltingRecipe(
                smeltingRecipe_EvinonSteelDecraft,
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.EvinonSteelIngot],
                    crystalShardBlue
                },
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverIngot],
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.MythrilIngot]
                },
                smelterUpgrades_gem3,
                true
            );
            CustomRecipesAPI.Core.SetUpSmeltingRecipe(
                smeltingRecipe_OrchiDecraft,
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.OrchiIngot],
                    crystalShardBlue
                },
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.GoldOre],
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.MythrilOre]
                },
                smelterUpgrades_gem3,
                true
            );
            CustomRecipesAPI.Core.SetUpSmeltingRecipe(
                smeltingRecipe_RedIronDecraft,
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.RedIronIngot],
                    crystalShardBlue
                },
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.IronIngot],
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.CopperIngot]
                },
                smelterUpgrades_gem1,
                true
            );
            CustomRecipesAPI.Core.SetUpSmeltingRecipe(
                smeltingRecipe_WhiteGoldDecraft,
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.WhiteGoldIngot],
                    crystalShardBlue
                },
                new Item[]
                {
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverOre],
                    CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.GoldOre]
                },
                smelterUpgrades_gem2,
                true
            );
        }
    }
}