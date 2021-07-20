using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
//using ICAIO_AI_FOR_MOD_NPCs.Utilities;
using Noggog;

namespace ICAIO_AI_FOR_MOD_NPCs
{
    public class ICAIO_AI_FOR_MOD_NPC
    {
        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetTypicalOpen(GameRelease.SkyrimSE, "ICAIO_AI_MOD_NPCs.esp")
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //var ICAIO = state.LoadOrder.GetModByFileName("Immersive Citizens - AI Overhaul.esp");

            //if (ICAIO == null) 
            //{
            //    System.Console.WriteLine("Required Mods Not Found");
            //    return;
            //}



            var WhiterunExtraCitizenPackage =       new FormLink<IPackageGetter>(FormKey.Factory("23B055:Immersive Citizens - AI Overhaul.esp"));
            var RiverwoodExtraCitizenPackage =      new FormLink<IPackageGetter>(FormKey.Factory("ABBB88:Immersive Citizens - AI Overhaul.esp"));
            var FalkreathExtraCitizenPackage =      new FormLink<IPackageGetter>(FormKey.Factory("AD509D:Immersive Citizens - AI Overhaul.esp"));
            var RoriksteadExtraCitizenPackage =     new FormLink<IPackageGetter>(FormKey.Factory("ABBB89:Immersive Citizens - AI Overhaul.esp"));
            var IvarsteadExtraCitizenPackage =      new FormLink<IPackageGetter>(FormKey.Factory("AC0C89:Immersive Citizens - AI Overhaul.esp"));
            var DarkwaterExtraCitizenPackage =      new FormLink<IPackageGetter>(FormKey.Factory("AC0C8B:Immersive Citizens - AI Overhaul.esp"));
            var RiftenExtraCitizenPackage =         new FormLink<IPackageGetter>(FormKey.Factory("AD50A0:Immersive Citizens - AI Overhaul.esp"));
            var DawnstarExtraCitizenPackage =       new FormLink<IPackageGetter>(FormKey.Factory("AD509B:Immersive Citizens - AI Overhaul.esp"));
            var MorthalExtraCitizenPackage =        new FormLink<IPackageGetter>(FormKey.Factory("AD509F:Immersive Citizens - AI Overhaul.esp"));
            var DragonBridgeExtraCitizenPackage =   new FormLink<IPackageGetter>(FormKey.Factory("ABBB8D:Immersive Citizens - AI Overhaul.esp"));
            var WindhelmExtraCitizenPackage =       new FormLink<IPackageGetter>(FormKey.Factory("AD50A2:Immersive Citizens - AI Overhaul.esp"));
            var ShorsStoneExtraCitizenPackage =     new FormLink<IPackageGetter>(FormKey.Factory("AC0C8C:Immersive Citizens - AI Overhaul.esp"));
            var KynesgroveExtraCitizenPackage =     new FormLink<IPackageGetter>(FormKey.Factory("ABBB8C:Immersive Citizens - AI Overhaul.esp"));
            var SolitudeExtraCitizenPackage =       new FormLink<IPackageGetter>(FormKey.Factory("AD50A1:Immersive Citizens - AI Overhaul.esp"));
            var StonehillsExtraCitizenPackage =     new FormLink<IPackageGetter>(FormKey.Factory("A74D3D:Immersive Citizens - AI Overhaul.esp"));
            var WinterholdExtraCitizenPackage =     new FormLink<IPackageGetter>(FormKey.Factory("332712:Immersive Citizens - AI Overhaul.esp"));
            var MarkarthExtraCitizenPackage =       new FormLink<IPackageGetter>(FormKey.Factory("AD509E:Immersive Citizens - AI Overhaul.esp"));
            var KarthwastenExtraCitizenPackage =    new FormLink<IPackageGetter>(FormKey.Factory("AC0C8A:Immersive Citizens - AI Overhaul.esp"));

            var WhiterunCombatExtraCitizen =        new FormLink<IFormListGetter>(FormKey.Factory("31E2DA:Immersive Citizens - AI Overhaul.esp"));
            var RiverwoodCombatExtraCitizen =       new FormLink<IFormListGetter>(FormKey.Factory("238A7B:Immersive Citizens - AI Overhaul.esp"));
            var FalkreathCombatExtraCitizen =       new FormLink<IFormListGetter>(FormKey.Factory("238FE8:Immersive Citizens - AI Overhaul.esp"));
            var RoriksteadCombatExtraCitizen =      new FormLink<IFormListGetter>(FormKey.Factory("238FE2:Immersive Citizens - AI Overhaul.esp"));
            var IvarsteadCombatExtraCitizen =       new FormLink<IFormListGetter>(FormKey.Factory("238FE4:Immersive Citizens - AI Overhaul.esp"));
            var DarkwaterCombatExtraCitizen =       new FormLink<IFormListGetter>(FormKey.Factory("23955D:Immersive Citizens - AI Overhaul.esp"));
            var RiftenCombatExtraCitizen =          new FormLink<IFormListGetter>(FormKey.Factory("3284E5:Immersive Citizens - AI Overhaul.esp"));
            var DawnstarCombatExtraCitizen =        new FormLink<IFormListGetter>(FormKey.Factory("32D5FD:Immersive Citizens - AI Overhaul.esp"));
            var MorthalCombatExtraCitizen =         new FormLink<IFormListGetter>(FormKey.Factory("238FEE:Immersive Citizens - AI Overhaul.esp"));
            var DragonBridgeCombatExtraCitizen =    new FormLink<IFormListGetter>(FormKey.Factory("238FF4:Immersive Citizens - AI Overhaul.esp"));
            var WindhelmCombatExtraCitizen =        new FormLink<IFormListGetter>(FormKey.Factory("3284EF:Immersive Citizens - AI Overhaul.esp"));
            var ShorsStoneCombatExtraCitizen =      new FormLink<IFormListGetter>(FormKey.Factory("23955B:Immersive Citizens - AI Overhaul.esp"));
            var KynesgroveCombatExtraCitizen =      new FormLink<IFormListGetter>(FormKey.Factory("239AC1:Immersive Citizens - AI Overhaul.esp"));
            var SolitudeCombatExtraCitizen =        new FormLink<IFormListGetter>(FormKey.Factory("3284E9:Immersive Citizens - AI Overhaul.esp"));
            var StonehillsCombatExtraCitizen =      new FormLink<IFormListGetter>(FormKey.Factory("238FEB:Immersive Citizens - AI Overhaul.esp"));
            var WinterholdCombatExtraCitizen =      new FormLink<IFormListGetter>(FormKey.Factory("239AC7:Immersive Citizens - AI Overhaul.esp"));
            var MarkarthCombatExtraCitizen =        new FormLink<IFormListGetter>(FormKey.Factory("3284EC:Immersive Citizens - AI Overhaul.esp"));
            var KarthwastenCombatExtraCitizen =     new FormLink<IFormListGetter>(FormKey.Factory("238FF1:Immersive Citizens - AI Overhaul.esp"));

            var ICAIOCitizensFaction = new FormLink<IFactionGetter>(FormKey.Factory("2FDA89:Immersive Citizens - AI Overhaul.esp"));
            var ICAIOExclusionFaction = new FormLink<IFactionGetter>(FormKey.Factory("237FB4:Immersive Citizens - AI Overhaul.esp"));

            var FactionBlacklist = new HashSet<FormLink<IFactionGetter>>
            {
                Skyrim.Faction.IsGuardFaction,
                Skyrim.Faction.CWImperialFaction,
                Skyrim.Faction.CrimeFactionSons,
                Skyrim.Faction.PenitusOculatusFaction,
                Skyrim.Faction.ThalmorFaction,
                Skyrim.Faction.CompanionsFaction,
                Skyrim.Faction.CollegeofWinterholdFaction,
                ICAIOExclusionFaction
            };

            bool npcIsPatched = false;

            HashSet<ModKey> vanilla = Implicits.Get(GameRelease.SkyrimSE).BaseMasters.ToHashSet();


            foreach (var npc in state.LoadOrder.PriorityOrder.Npc().WinningOverrides())
            {
                npcIsPatched = false;

                if (!vanilla.Contains(npc.FormKey.ModKey))
                {
                    //Whiterun
                    npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionWhiterun,Skyrim.Faction.TownWhiterunFaction,ICAIOCitizensFaction,ICAIOExclusionFaction,WhiterunExtraCitizenPackage,WhiterunCombatExtraCitizen);
                    //Riverwood
                    if (!npcIsPatched)
                    { 
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionWhiterun, Skyrim.Faction.TownRiverwoodFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, RiverwoodExtraCitizenPackage, RiverwoodCombatExtraCitizen);
                    }
                    //Falkreath
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionFalkreath, Skyrim.Faction.TownFalkreathFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, FalkreathExtraCitizenPackage, FalkreathCombatExtraCitizen);
                    }
                    //Rorikstead
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionWhiterun, Skyrim.Faction.TownRoriksteadFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, RoriksteadExtraCitizenPackage, RoriksteadCombatExtraCitizen);
                    }
                    //Ivarstead
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionRift, Skyrim.Faction.TownIvarsteadFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, IvarsteadExtraCitizenPackage, IvarsteadCombatExtraCitizen);
                    }
                    //Darkwater Crossing
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionEastmarch, Skyrim.Faction.TownDarkwaterCrossingFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, DarkwaterExtraCitizenPackage, DarkwaterCombatExtraCitizen);
                    }
                    //Riften
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionRift, Skyrim.Faction.TownRiftenFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, RiftenExtraCitizenPackage, RiftenCombatExtraCitizen);
                    }
                    //Dawnstar
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionPale, Skyrim.Faction.TownDawnstarFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, DawnstarExtraCitizenPackage, DawnstarCombatExtraCitizen);
                    }
                    //Morthal
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionHjaalmarch, Skyrim.Faction.TownMorthalFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, MorthalExtraCitizenPackage, MorthalCombatExtraCitizen);
                    }
                    //Dragon Bridge
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionHaafingar, Skyrim.Faction.TownDragonBridgeFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, DragonBridgeExtraCitizenPackage, DragonBridgeCombatExtraCitizen);
                    }
                    //Windhelm
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionEastmarch, Skyrim.Faction.TownWindhelmFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, WindhelmExtraCitizenPackage, WindhelmCombatExtraCitizen);
                    }
                    //Shors Stone
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionRift, Skyrim.Faction.TownShorsStoneFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, ShorsStoneExtraCitizenPackage, ShorsStoneCombatExtraCitizen);
                    }
                    //Kynesgrove
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionEastmarch, Skyrim.Faction.TownKynesgroveFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, KynesgroveExtraCitizenPackage, KynesgroveCombatExtraCitizen);
                    }
                    //Solitude
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionHaafingar, Skyrim.Faction.TownSolitudeFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, SolitudeExtraCitizenPackage, SolitudeCombatExtraCitizen);
                    }
                    //Stone Hills
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionHjaalmarch, Skyrim.Faction.TownStonehillsFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, StonehillsExtraCitizenPackage, StonehillsCombatExtraCitizen);
                    }
                    //Winterhold
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionWinterhold, Skyrim.Faction.TownWinterholdFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, WinterholdExtraCitizenPackage, WinterholdCombatExtraCitizen);
                    }
                    //Markarth
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionReach, Skyrim.Faction.TownMarkarthFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, MarkarthExtraCitizenPackage, MarkarthCombatExtraCitizen);
                    }
                    //Karthwasten
                    if (!npcIsPatched)
                    {
                        npcIsPatched = CheckFactions(state, npc, FactionBlacklist, Skyrim.Faction.CrimeFactionReach, Skyrim.Faction.TownKarthwastenFaction, ICAIOCitizensFaction, ICAIOExclusionFaction, KarthwastenExtraCitizenPackage, KarthwastenCombatExtraCitizen);
                    }
                }

            }

        }
        
        public static bool CheckFactions(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, INpcGetter npc, HashSet<FormLink<IFactionGetter>> FactionBlacklist, FormLink<IFactionGetter> CrimFactionToCheck, FormLink<IFactionGetter> TownFactionToCheck, FormLink<IFactionGetter> ICAIOCitizensFaction, FormLink<IFactionGetter> ICAIOExclusionFaction, FormLink<IPackageGetter> AIPackageToAdd, FormLink<IFormListGetter> CombatPackageToAdd)
        {
            bool npcIsPatched = false;
            bool CrimeFactionIsFound = false;
            bool TownFactionIsFound = false;
            bool BlacklistedIsFound = false;

            foreach (var RankPlacementGetter in npc.Factions)
            {
                if (RankPlacementGetter.Faction.Equals(CrimFactionToCheck))
                {
                    Console.WriteLine("Crime Faction Found");
                    CrimeFactionIsFound = true;
                }  
                    
                if (RankPlacementGetter.Faction.Equals(TownFactionToCheck))
                {
                    Console.WriteLine("Town Faction Found");
                    TownFactionIsFound = true;
                }

                if (FactionBlacklist.Contains(RankPlacementGetter.Faction))
                {
                    Console.WriteLine("Blacklisted Faction Found");
                    BlacklistedIsFound = true;
                }
                 
            }

            if (CrimeFactionIsFound == true && TownFactionIsFound == true && BlacklistedIsFound == false)
            {
                var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                npcOverride.Packages.Insert(0, AIPackageToAdd);
                npcOverride.Factions.Add(
                    new RankPlacement()
                    {
                        Faction = ICAIOCitizensFaction,
                        Rank = 0
                    });
                npcOverride.Factions.Add(
                    new RankPlacement()
                    {
                        Faction = ICAIOExclusionFaction,
                        Rank = 0
                    });
                if (npcOverride.CombatOverridePackageList.IsNull)
                {
                    npcOverride.CombatOverridePackageList.SetTo(CombatPackageToAdd);
                }

                npcIsPatched = true;
            }
            

            return npcIsPatched;
                
        }

    }
}
