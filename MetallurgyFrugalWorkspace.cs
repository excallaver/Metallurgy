

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;

    [Serialized]
    [LocDisplayName("Frugal Workspace: Metallurgy")]
    [LocDescription("Lowers the tier requirement of related tables by 0.2.(Only applies to claimed workstations)")]
    public partial class MetallurgyFrugalWorkspaceTalentGroup : TalentGroup
    {

        public MetallurgyFrugalWorkspaceTalentGroup()
        {
            Talents = new Type[]
            {

            typeof(MetallurgyFrugalReqTalent),


            };
            this.OwningSkill = typeof(MetallurgySkill);
            this.Level = 6;
        }
    }


        [Serialized]
        public partial class MetallurgyFrugalReqTalent : FrugalWorkspaceTalent
        {
            public override bool Base { get { return false; } }
            public override Type TalentGroupType { get { return typeof(global::Eco.Mods.TechTree.MetallurgyFrugalWorkspaceTalentGroup); } }
            public MetallurgyFrugalReqTalent()
            {
                this.Value = -0.2f;
            }
        }

    }