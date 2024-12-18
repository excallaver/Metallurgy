// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    using Eco.Shared.Utils;
    using Eco.Gameplay.Items.Recipes;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [Serialized]
    [LocDisplayName("Metallurgy")]
    [LocDescription("Metallurgy Teaches you new ways to refine ores.")]
    [Ecopedia("Professions", "Smith", createAsSubPage: true)]
    [RequiresSkill(typeof(SmithSkill), 0), Tag("Smith Specialty"), Tier(1)]
    [Tag("Specialty")]
    [Tag("Teachable")]
    public partial class MetallurgySkill : Skill
    {

        public override void OnLevelUp(User user)
        {
            user.Skillset.AddExperience(typeof(SelfImprovementSkill), 20, Localizer.DoStr("for leveling up another specialization."));
        }


        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] { 
                1,
                1 - 0.5f,
                1 - 0.55f,
                1 - 0.6f,
                1 - 0.65f,
                1 - 0.7f,
                1 - 0.75f,
                1 - 0.8f,
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;

        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] { 
                0,
                0.5f,
                0.55f,
                0.6f,
                0.65f,
                0.7f,
                0.75f,
                0.8f,
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 1; } }
    }

    [Serialized]
    [LocDisplayName("Metallurgy Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true)]
    public partial class MetallurgySkillBook : SkillBook<MetallurgySkill, MetallurgySkillScroll> {}

    [Serialized]
    [LocDisplayName("Metallurgy Skill Scroll")]
    public partial class MetallurgySkillScroll : SkillScroll<MetallurgySkill, MetallurgySkillBook> {}


    [RequiresSkill(typeof(SmeltingSkill), 7)]
    public partial class MetallurgySkillBookRecipe : RecipeFamily
    {
        public MetallurgySkillBookRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Metallurgy",  //noloc
                Localizer.DoStr("Metallurgy Skill Book"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(MetallurgyResearchPaperAdvancedItem), 20, typeof(SmeltingSkill)),
                    new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 20, typeof(BasicEngineeringSkill)),
                    new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 20, typeof(MasonrySkill)),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<MetallurgySkillBook>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(10000, typeof(SmeltingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(MetallurgySkillBookRecipe), 10, typeof(SmeltingSkill));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Metallurgy Skill Book"), typeof(MetallurgySkillBookRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
