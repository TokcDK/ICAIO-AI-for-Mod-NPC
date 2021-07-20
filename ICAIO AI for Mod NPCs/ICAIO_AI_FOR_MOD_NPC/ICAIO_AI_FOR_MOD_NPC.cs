using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using ICAIO_AI_FOR_MOD_NPCs.Utilities;
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
            var ICAIO = state.LoadOrder.GetModByFileName("Immersive Citizens - AI Overhaul.esp");

            if (ICAIO == null) 
            {
                System.Console.WriteLine("Required Mods Not Found");
                return;
            }

            //var FactionsToPatch = new HashSet<FormLink<IFactionGetter>>
            //{
            //    Skyrim.Faction.TownWhiterunFaction
            //};

            var WhiterunExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("23B055:Immersive Citizens - AI Overhaul.esp"));
            var RiftExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("ACFF97:Immersive Citizens - AI Overhaul.esp"));
            var HaafingarExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("AC5D90:Immersive Citizens - AI Overhaul.esp"));
            var PaleExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("AC5D92:Immersive Citizens - AI Overhaul.esp"));
            var EastmarchExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("AC5D8F:Immersive Citizens - AI Overhaul.esp"));
            var WinterholdExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("AC5D93:Immersive Citizens - AI Overhaul.esp"));
            var FalkreathExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("ACFF96:Immersive Citizens - AI Overhaul.esp"));
            var ReachExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("ACFF98:Immersive Citizens - AI Overhaul.esp"));
            var HjaalmarchExtraCitizenPackage = new FormLink<IPackageGetter>(FormKey.Factory("AC5D91:Immersive Citizens - AI Overhaul.esp"));


            var ICAIOCitizensFaction = new FormLink<IFactionGetter>(FormKey.Factory("2FDA89:Immersive Citizens - AI Overhaul.esp"));

            HashSet<ModKey> vanilla = Implicits.Get(GameRelease.SkyrimSE).BaseMasters.ToHashSet();


            foreach (var npc in state.LoadOrder.PriorityOrder.Npc().WinningOverrides())
            {


                if (!vanilla.Contains(npc.FormKey.ModKey))
                {

                    foreach (var CrimeRankPlacementGetter in npc.Factions)
                    {
                        if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionWhiterun))
                        {
                            Console.WriteLine("Whiterun Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if  (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownWhiterunFaction))
                                {
                                    Console.WriteLine("Whiterun Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, WhiterunExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        }) ;
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionRift))
                        {
                            Console.WriteLine("Rift Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownRiftenFaction))
                                {
                                    Console.WriteLine("Riften Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, RiftExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionHaafingar))
                        {
                            Console.WriteLine("Haafingar Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownSolitudeFaction))
                                {
                                    Console.WriteLine("Solitude Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, HaafingarExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionPale))
                        {
                            Console.WriteLine("Pale Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownDawnstarFaction))
                                {
                                    Console.WriteLine("Dawnstar Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, PaleExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionEastmarch))
                        {
                            Console.WriteLine("Eastmarch Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownWindhelmFaction))
                                {
                                    Console.WriteLine("Windhelm Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, EastmarchExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionWinterhold))
                        {
                            Console.WriteLine("Winterhold Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownWinterholdFaction))
                                {
                                    Console.WriteLine("Winterhold Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, WinterholdExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionFalkreath))
                        {
                            Console.WriteLine("Falkreath Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownFalkreathFaction))
                                {
                                    Console.WriteLine("Falkreath Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, FalkreathExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionReach))
                        {
                            Console.WriteLine("The Reach Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownMarkarthFaction))
                                {
                                    Console.WriteLine("Markarth Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, ReachExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }
                        else if (CrimeRankPlacementGetter.Faction.Equals(Skyrim.Faction.CrimeFactionHjaalmarch))
                        {
                            Console.WriteLine("Hjaalmarch Faction Found");
                            foreach (var TownRankPlacementGetter in npc.Factions)
                            {
                                if (TownRankPlacementGetter.Faction.Equals(Skyrim.Faction.TownMorthalFaction))
                                {
                                    Console.WriteLine("Morthal Town Faction  Found");
                                    var npcOverride = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                                    npcOverride.Packages.Insert(0, HjaalmarchExtraCitizenPackage);
                                    npcOverride.Factions.Add(
                                        new RankPlacement()
                                        {
                                            Faction = ICAIOCitizensFaction,
                                            Rank = 0
                                        });
                                }
                            }
                        }

                    }
                }

            }

        }
    }
}
