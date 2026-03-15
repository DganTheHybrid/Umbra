using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Umbra.Compat
{
	/// <summary>
	/// Provides additional crossmod data for which entities should count as bosses
	/// for the sake of being effected by the tree
	/// </summary>
	internal class ExtraBossMarks : ModSystem
	{
		public static List<int> countsAsBoss = new();
		public static List<string> modsNotPresent = new();

		public override void PostSetupContent()
		{
			countsAsBoss.Clear();
			modsNotPresent.Clear();

			// Add a handful of vanilla entities that should count as bosses
			countsAsBoss.Add(NPCID.Creeper);

			countsAsBoss.Add(NPCID.EaterofWorldsBody);
			countsAsBoss.Add(NPCID.EaterofWorldsTail);

			countsAsBoss.Add(NPCID.SkeletronHand);

			countsAsBoss.Add(NPCID.WallofFleshEye);
			countsAsBoss.Add(NPCID.TheHungry);
			countsAsBoss.Add(NPCID.TheHungryII);

			countsAsBoss.Add(NPCID.TheDestroyerBody);
			countsAsBoss.Add(NPCID.TheDestroyerTail);

			countsAsBoss.Add(NPCID.PrimeCannon);
			countsAsBoss.Add(NPCID.PrimeLaser);
			countsAsBoss.Add(NPCID.PrimeSaw);
			countsAsBoss.Add(NPCID.PrimeVice);

			countsAsBoss.Add(NPCID.PlanterasHook);
			countsAsBoss.Add(NPCID.PlanterasTentacle);

			countsAsBoss.Add(NPCID.MartianSaucerCannon);
			countsAsBoss.Add(NPCID.MartianSaucerCore);
			countsAsBoss.Add(NPCID.MartianSaucerTurret);

			countsAsBoss.Add(NPCID.PumpkingBlade);

			countsAsBoss.Add(NPCID.PirateShipCannon);

			countsAsBoss.Add(NPCID.GolemFistLeft);
			countsAsBoss.Add(NPCID.GolemFistRight);
			countsAsBoss.Add(NPCID.GolemHead);
			countsAsBoss.Add(NPCID.GolemHeadFree);

			countsAsBoss.Add(NPCID.MoonLordFreeEye);
			countsAsBoss.Add(NPCID.MoonLordHand);
			countsAsBoss.Add(NPCID.MoonLordHead);
			countsAsBoss.Add(NPCID.MoonLordLeechBlob);

			// Modded entries, largely up to community maintinence. Please PR additions or removals!

			// Starlight River
			TryAddBoss("StarlightRiver", "Tentacle"); // Example entry 

			TryAddBoss("StarlightRiver", "VitricBossCrystal");
			TryAddBoss("StarlightRiver", "ArenaBottom");

			TryAddBoss("StarlightRiver", "DeadBrain");
			TryAddBoss("StarlightRiver", "TheThinker");
			TryAddBoss("StarlightRiver", "Neurysm");
			TryAddBoss("StarlightRiver", "HorrifyingVisage");
			TryAddBoss("StarlightRiver", "WeakPoint");

			//Calamity Mod
			TryAddBoss("CalamityMod", "AquaticScourgeBody");
			TryAddBoss("CalamityMod", "AquaticScourgeHead");
			TryAddBoss("CalamityMod", "AquaticScourgeTail");
			TryAddBoss("CalamityMod", "AstrumAureus");
			TryAddBoss("CalamityMod", "AquaticScourgeBodyAlt");
			TryAddBoss("CalamityMod", "AstrumDeusHead");
			TryAddBoss("CalamityMod", "AstrumDeusBody");
			TryAddBoss("CalamityMod", "AstrumDeusTail");
			TryAddBoss("CalamityMod", "BrimstoneElemental");
			TryAddBoss("CalamityMod", "Bumblebirb");
			TryAddBoss("CalamityMod", "CalamitasClone");
			TryAddBoss("CalamityMod", "Catastrophe");
			TryAddBoss("CalamityMod", "Cataclysm");
			TryAddBoss("CalamityMod", "CeaselessVoid");
			TryAddBoss("CalamityMod", "DarkEnergy");
			TryAddBoss("CalamityMod", "Crabulon");
			TryAddBoss("CalamityMod", "Cryogen");
			TryAddBoss("CalamityMod", "CryodenShield");
			TryAddBoss("CalamityMod", "DesertScourgeHead");
			TryAddBoss("CalamityMod", "DesertScourgeBody");
			TryAddBoss("CalamityMod", "DesertScourgeTail");
			TryAddBoss("CalamityMod", "DevourerOfGodsHead");
			TryAddBoss("CalamityMod", "DevourerOfGodsBody");
			TryAddBoss("CalamityMod", "DevourerOfGodsTail");
			TryAddBoss("CalamityMod", "Apollo");
			TryAddBoss("CalamityMod", "AresBody");
			TryAddBoss("CalamityMod", "ThanatosHead");
			TryAddBoss("CalamityMod", "ThanatosBody1");
			TryAddBoss("CalamityMod", "ThanatosBody2");
			TryAddBoss("CalamityMod", "ThanatosTail");
			TryAddBoss("CalamityMod", "AresGaussNuke");
			TryAddBoss("CalamityMod", "AresLaserCannon");
			TryAddBoss("CalamityMod", "AresPlasmaFlamethrower");
			TryAddBoss("CalamityMod", "AresTeslaCannon");
			TryAddBoss("CalamityMod", "Draedon"); //lol
			TryAddBoss("CalamityMod", "HiveMind");
			TryAddBoss("CalamityMod", "Anahita");
			TryAddBoss("CalamityMod", "Leviathan");
			TryAddBoss("CalamityMod", "OldDuke");
			TryAddBoss("CalamityMod", "PerforatorHive");
			TryAddBoss("CalamityMod", "PerforatorHeadSmall");
			TryAddBoss("CalamityMod", "PerforatorHeadMedium");
			TryAddBoss("CalamityMod", "PerforatorHeadLarge");
			TryAddBoss("CalamityMod", "PerforatorBodySmall");
			TryAddBoss("CalamityMod", "PerforatorBodyMedium");
			TryAddBoss("CalamityMod", "PerforatorBodyLarge");
			TryAddBoss("CalamityMod", "PerforatorTailSmall");
			TryAddBoss("CalamityMod", "PerforatorTailMedium");
			TryAddBoss("CalamityMod", "PerforatorTailLarge");
			TryAddBoss("CalamityMod", "PlaguebringerGoliath");
			TryAddBoss("CalamityMod", "Polterghast");
			TryAddBoss("CalamityMod", "PolterPhantom");
			TryAddBoss("CalamityMod", "PrimordialWyrmHead"); //no other body parts because it will make no sense, they're invincible
			TryAddBoss("CalamityMod", "ProfanedGuardianCommander");
			TryAddBoss("CalamityMod", "ProfanedGuardianDefender");
			TryAddBoss("CalamityMod", "ProfanedGuardianHealer");
			TryAddBoss("CalamityMod", "Providence");
			TryAddBoss("CalamityMod", "RavagerBody");
			TryAddBoss("CalamityMod", "RavagerLegRight");
			TryAddBoss("CalamityMod", "RavagerLegLeft");
			TryAddBoss("CalamityMod", "RavagerClawRight");
			TryAddBoss("CalamityMod", "RavagerClawLeft");
			TryAddBoss("CalamityMod", "RavagerHead"); //like p1 golem head, static to boss
			TryAddBoss("CalamityMod", "RavagerHead2"); //like p2 golem head, non static to boss, but can be damaged
			TryAddBoss("CalamityMod", "Signus");
			TryAddBoss("CalamityMod", "EbonianPaladin");
			TryAddBoss("CalamityMod", "CrimulanPaladin");
			TryAddBoss("CalamityMod", "SlimeGodCore");
			TryAddBoss("CalamityMod", "StormWeaverHead");
			TryAddBoss("CalamityMod", "StormWeaverBody");
			TryAddBoss("CalamityMod", "StormWeaverTail");
			TryAddBoss("CalamityMod", "SepulcherHead");
			TryAddBoss("CalamityMod", "SepulcherBody");
			TryAddBoss("CalamityMod", "SepulcherTail");
			TryAddBoss("CalamityMod", "SupremeCalamitas");
			TryAddBoss("CalamityMod", "SupremeCataclysm");
			TryAddBoss("CalamityMod", "SupremeCatastrophe");
			TryAddBoss("CalamityMod", "Yharon");
			TryAddBoss("CalamityMod", "AureusSpawn"); //CalamityMod boss servants:
			TryAddBoss("CalamityMod", "Brimling");
			TryAddBoss("CalamityMod", "DraconicSwarmer");
			TryAddBoss("CalamityMod", "SoulSeeker");
			TryAddBoss("CalamityMod", "CrabShroom");
			TryAddBoss("CalamityMod", "DeserNuisanceHead");
			TryAddBoss("CalamityMod", "DeserNuisanceBody");
			TryAddBoss("CalamityMod", "DeserNuisanceTail");
			TryAddBoss("CalamityMod", "DankCreeper");
			TryAddBoss("CalamityMod", "AquaticAberration");
			TryAddBoss("CalamityMod", "OldDukeToothBall");
			TryAddBoss("CalamityMod", "PhantomFuckYou");
			TryAddBoss("CalamityMod", "ProfanedRocks");
			TryAddBoss("CalamityMod", "FlamePillar");
			TryAddBoss("CalamityMod", "RockPillar");
			TryAddBoss("CalamityMod", "CosmicLantern");
			TryAddBoss("CalamityMod", "CosmicMine");
			TryAddBoss("CalamityMod", "CorruptSlimeSpawn");
			TryAddBoss("CalamityMod", "CorruptSlimeSpawn2");
			TryAddBoss("CalamityMod", "CrimsonSlimeSpawn");
			TryAddBoss("CalamityMod", "CrimsonSlimeSpawn2");
			TryAddBoss("CalamityMod", "SplitCrimulanPaladin");
			TryAddBoss("CalamityMod", "SplitEbonianPaladin");
			TryAddBoss("CalamityMod", "BrimstoneHeart");
			TryAddBoss("CalamityMod", "SepulcherArm");
			TryAddBoss("CalamityMod", "SoukSeekerSupreme");
			
			//InfernumMode
			TryAddBoss("InfernumMode", "BereftVassal");
			TryAddBoss("InfernumMode", "ProfanedCrystaHealerShieldCrystal");
			if (ModLoader.TryGetMod("InfernumMode", as Mod InfMod)) //I DON'T rember, will it work or no
			{
				get => InfMod.Core.GlobalInstances.Systems.WorldSaveSystem.InfernumModeEnabled
				set

				if (InfMod.Core.GlobalInstances.Systems.WorldSaveSystem.InfernumModeEnabled)
				{
					TryAddBoss("CalamityMod", "GreatSandShark");
					countsAsBoss.Add(NPCID.Dreadnautilus);
					countsAsBoss.Add(NPCID.Betsy);
				}
			}
		}
			
		/// <summary>
		/// Attempts to add the given NPC from the given mod to the boss registry. If the mod is not present
		/// it will be marked as such and other NPCs from that mod not attempted
		/// </summary>
		/// <param name="mod"></param>
		/// <param name="internalName"></param>
		public void TryAddBoss(string modName, string internalName)
		{
			if (modsNotPresent.Contains(modName))
				return;

			if (ModLoader.TryGetMod(modName, out Mod mod))
			{
				if (mod.TryFind<ModNPC>(internalName, out ModNPC npc))
					countsAsBoss.Add(npc.Type);
			}
			else
			{
				modsNotPresent.Add(modName);
			}
		}

		/// <summary>
		/// Should be used to check if a given NPC is a boss for all tree functionality
		/// </summary>
		/// <param name="npc">The NPC to check</param>
		/// <returns>If the NPC should be treated as a boss</returns>
		public static bool DoICountAsABoss(NPC npc)
		{
			return npc.boss || npc.GetGlobalNPC<ExtraBossMarkNPC>().countsAsBossForTree;
		}
	}

	internal class ExtraBossMarkNPC : GlobalNPC
	{
		public bool countsAsBossForTree;

		public override bool InstancePerEntity => true;

		public override void SetDefaults(NPC entity)
		{
			if (ExtraBossMarks.countsAsBoss.Contains(entity.type))
				countsAsBossForTree = true;
		}
	}
}
