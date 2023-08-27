using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace BSWLmod.Content.ExperienceOrbs
{
	public class HugeDormant : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
		}

		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.value = Item.buyPrice(0, 0, 0, 0);
			Item.rare = -1;
			Item.maxStack = 9999;
		}
	}
}