using System.Collections.Generic;
using Terraria.ModLoader;

namespace TornReality.DamageClasses
{
	public class Warmonger : DamageClass
	{
		public override void SetStaticDefaults() {
			ClassName.SetDefault("Warmonger Damage");
		}

		protected override float GetBenefitFrom(DamageClass damageClass) {
			if (damageClass == DamageClass.Generic)
				return 1f;

			if (damageClass == DamageClass.Ranged)
				return 0.5f;
			

			
			return 0;
		}

		public override bool CountsAs(DamageClass damageClass) {
			return false;
		}
	}
}