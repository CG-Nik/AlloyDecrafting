using Alta.Blacksmithing;
using Alta.Inventory;
using CustomRecipesAPI;
using Alta;
using MelonLoader;
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

            CustomRecipesAPI.Core.SetUpSmeltingRecipeThroughCode(
                "Carsi Decraft",
                18061,
                7f,
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.CarsiIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        crystalShardBlue,
                        1
                    ),
                },
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.RedIronIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverOre],
                        4
                    ),
                },
                smelterUpgrades_gem2,
                true
            );

            CustomRecipesAPI.Core.SetUpSmeltingRecipeThroughCode(
                "Evinon Steel Decraft",
                18062,
                10f,
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.EvinonSteelIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        crystalShardBlue,
                        1
                    ),
                },
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.MythrilIngot],
                        2
                    ),
                },
                smelterUpgrades_gem3,
                true
            );

            CustomRecipesAPI.Core.SetUpSmeltingRecipeThroughCode(
                "Orchi Decraft",
                18063,
                8f,
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.OrchiIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        crystalShardBlue,
                        1
                    ),
                },
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.GoldOre],
                        3
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.MythrilOre],
                        2
                    ),
                },
                smelterUpgrades_gem3,
                true
            );

            CustomRecipesAPI.Core.SetUpSmeltingRecipeThroughCode(
                "Red Iron Decraft",
                18064,
                7f,
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.RedIronIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        crystalShardBlue,
                        1
                    ),
                },
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.IronIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.CopperIngot],
                        1
                    ),
                },
                smelterUpgrades_gem1,
                true
            );

            CustomRecipesAPI.Core.SetUpSmeltingRecipeThroughCode(
                "White Gold Decraft",
                18065,
                7f,
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.WhiteGoldIngot],
                        1
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        crystalShardBlue,
                        1
                    ),
                },
                new ItemCount[]
                {
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.SilverOre],
                        3
                    ),
                    CustomRecipesAPI.Core.CreateItemCount(
                        CustomRecipesAPI.Core.VanillaOreAndIngotItems[(int)CustomRecipesAPI.Core.VanillaOreAndIngotIndexers.GoldOre],
                        2
                    ),
                },
                smelterUpgrades_gem2,
                true
            );
        }
    }
}