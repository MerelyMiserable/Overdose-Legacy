using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace OverdoseLegacy
{
    public class OverdoseLegacy
    {
        public static void Main()
        {

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Generator"),
                    NameOverride = "Gray's Generator-ODL",
                    NameToOrderByOverride = "Generator 2",
                    DescriptionOverride = "A Generator but made by florida man.",
                    CategoryOverride = ModAPI.FindCategory("Machinery"),
                    ThumbnailOverride = ModAPI.LoadSprite("grayView.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("gray.png");
                        Instance.transform.localScale = new Vector2(1f, 1f);
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.gravityScale = 1f;
                        Instance.AddComponent<GeneratorBehaviour>();
                        UseEventTrigger useEventTrigger = Instance.AddComponent<UseEventTrigger>();
                        useEventTrigger.Event = new UnityEvent();
                        useEventTrigger.Event.AddListener(delegate ()
                        {
                            Instance.GetComponent<PhysicalBehaviour>().charge = float.PositiveInfinity;
                            Instance.GetComponent<PhysicalBehaviour>().Charge = float.PositiveInfinity;
                        });
                    }
                }
            );

            {
                ModAPI.Register(
                    new Modification()
                    {
                        OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
                        NameOverride = "Fire Syringe-ODL",
                        NameToOrderByOverride = "Syringe 99",
                        DescriptionOverride = "Injection of this syringe causes combustion.",
                        CategoryOverride = ModAPI.FindCategory("Biohazard"),
                        ThumbnailOverride = ModAPI.LoadSprite("ignsyringView.png"),
                        AfterSpawn = (Instance) =>
                        {
                            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("ignsyring.png");
                            Instance.GetComponent<SpriteRenderer>().color = Color.white;
                            GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
                            Instance.AddComponent<FireSyringe>();
                        }
                    }
                );

                ModAPI.Register(
                    new Modification()
                    {
                        OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
                        NameOverride = "Electricity Syringe-ODL",
                        NameToOrderByOverride = "Syringe 999",
                        DescriptionOverride = "Injection of this syringe electrifies the victim.",
                        CategoryOverride = ModAPI.FindCategory("Biohazard"),
                        ThumbnailOverride = ModAPI.LoadSprite("elecsyringView.png"),
                        AfterSpawn = (Instance) =>
                        {
                            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("elecsyring.png");
                            Instance.GetComponent<SpriteRenderer>().color = Color.white;
                            GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
                            Instance.AddComponent<ElecSyringe>();
                        }
                    }
                );

                ModAPI.Register(
        new Modification()
        {
            OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
            NameOverride = "Better Syringe-ODL",
            NameToOrderByOverride = "Syringe 9999",
            DescriptionOverride = "Injection of this syringe makes the victim better.",
            CategoryOverride = ModAPI.FindCategory("Biohazard"),
            ThumbnailOverride = ModAPI.LoadSprite("bettersyringView.png"),
            AfterSpawn = (Instance) =>
            {
                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("bettersyring.png");
                Instance.GetComponent<SpriteRenderer>().color = Color.white;
                GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
                Instance.AddComponent<BetterSyringe>();
            }
        }
    );

                ModAPI.Register(
new Modification()
{
    OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
    NameOverride = "Ouch Syringe-ODL",
    NameToOrderByOverride = "Syringe 99999",
    DescriptionOverride = "Injection of this syringe makes the victim go ouch.",
    CategoryOverride = ModAPI.FindCategory("Biohazard"),
    ThumbnailOverride = ModAPI.LoadSprite("ouchsyringView.png"),
    AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("ouchsyring.png");
        Instance.GetComponent<SpriteRenderer>().color = Color.white;
        GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
        Instance.AddComponent<OuchSyringe>();
    }
}
                );

                ModAPI.Register(
new Modification()
{
    OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
    NameOverride = "Stay alive Syringe-ODL",
    NameToOrderByOverride = "Syringe 999999",
    DescriptionOverride = "Injection of this syringe into a part of the body makes in not die.",
    CategoryOverride = ModAPI.FindCategory("Biohazard"),
    ThumbnailOverride = ModAPI.LoadSprite("feelssyringView.png"),
    AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("feelssyring.png");
        Instance.GetComponent<SpriteRenderer>().color = Color.white;
        GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
        Instance.AddComponent<FeelsSyringe>();
    }
}
    );

                ModAPI.Register(
                    new Modification()
                    {
                        OriginalItem = ModAPI.FindSpawnable("Revolver"),
                        NameOverride = "Florida Man's Gun-ODL",
                        NameToOrderByOverride = "Revolver 2",
                        DescriptionOverride = "PEW PEW BANG BANG",
                        CategoryOverride = ModAPI.FindCategory("Firearms"),
                        ThumbnailOverride = ModAPI.LoadSprite("perngView.png", 5f),
                        AfterSpawn = (Instance) =>
                        {
                            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("perng.png");
                            var firearm = Instance.GetComponent<FirearmBehaviour>();
                            Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                            customCartridge.name = "DEATH";
                            customCartridge.Damage += 999999f;
                            customCartridge.Recoil += 999999f;
                            firearm.Cartridge = customCartridge;
                        }
                    }
                );

                ModAPI.Register(
                 new Modification()
                 {
                     OriginalItem = ModAPI.FindSpawnable("Revolver"),
                     NameOverride = "anti gun-ODL",
                     NameToOrderByOverride = "Revolver 3",
                     DescriptionOverride = "so Like does it heal people?",
                     CategoryOverride = ModAPI.FindCategory("Firearms"),
                     ThumbnailOverride = ModAPI.LoadSprite("antigunView.png", 5f),
                     AfterSpawn = (Instance) =>
                     {
                         Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("antigun.png");
                         var firearm = Instance.GetComponent<FirearmBehaviour>();
                         Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                         customCartridge.name = "life?";
                         customCartridge.Damage += -999999f;
                         customCartridge.Recoil += -10f;
                         firearm.Cartridge = customCartridge;
                     }
                 }
                 );

    ModAPI.Register(
    new Modification()
    {
      OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
      NameOverride = "Outtahere Syringe-ODL",
      NameToOrderByOverride = "Syringe 9999999",
      DescriptionOverride = "ight imma head out.",
      CategoryOverride = ModAPI.FindCategory("Biohazard"),
      ThumbnailOverride = ModAPI.LoadSprite("outtahereView.png"),
      AfterSpawn = (Instance) =>
        {
           Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("outtahere.png");
            Instance.GetComponent<SpriteRenderer>().color = Color.white;
          GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
          Instance.AddComponent<OuttahereSyringe>();
     }
    }
    );

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
                    NameOverride = "Spaz Syringe-ODL",
                    NameToOrderByOverride = "Syringe 999999999",
                    DescriptionOverride = "Makes the limb you inject it into spaz out " +
                    "EHEHHEHEHEHEHEAHHH.",
                    CategoryOverride = ModAPI.FindCategory("Biohazard"),
                    ThumbnailOverride = ModAPI.LoadSprite("spazsyringView.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("spazsyring.png");
                        Instance.GetComponent<SpriteRenderer>().color = Color.white;
                        GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
                        Instance.AddComponent<WinceSyringe>();
                    }
                }
                );


                //ModAPI.Register(        Cut for problems maybe later
                //new Modification()
                //{
                //OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
                //NameOverride = "Anti-Spaz Syringe",
                //NameToOrderByOverride = "Syringe 999999999",
                //DescriptionOverride = "Makes the limb you inject it into not spaz out " +
                //"EHEHHEHEHEH- what oh....",
                //CategoryOverride = ModAPI.FindCategory("Biohazard"),
                //ThumbnailOverride = ModAPI.LoadSprite("antispazsyringView.png"),
                //AfterSpawn = (Instance) =>
                //{
                //Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("antispazsyring.png");
                //Instance.GetComponent<SpriteRenderer>().color = Color.white;
                //GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
                //Instance.AddComponent<antiWinceSyringe>();
                //  }
                //}
                //);

                ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
        NameOverride = "Kabooie Syringe-ODL",
        NameToOrderByOverride = "Syringe 99999999",
        DescriptionOverride = "Aye, me bottle o' scrumpy!",
        CategoryOverride = ModAPI.FindCategory("Biohazard"),
        ThumbnailOverride = ModAPI.LoadSprite("kabooiesyringView.png"),
        AfterSpawn = (Instance) =>
        {
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("kabooiesyring.png");
            Instance.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
            Instance.AddComponent<KabooieSyringe>();
        }
    }
);


                ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Life Syringe"),
        NameOverride = "Life Steal Syringe-ODL",
        NameToOrderByOverride = "Syringe 999999999",
        DescriptionOverride = "zucc",
        CategoryOverride = ModAPI.FindCategory("Biohazard"),
        ThumbnailOverride = ModAPI.LoadSprite("lssyringView.png"),
        AfterSpawn = (Instance) =>
        {
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("lssyring.png");
            Instance.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Destroy(Instance.GetComponent<LifeSyringe>());
            Instance.AddComponent<LSSyringe>();
        }
    }
);



                ModAPI.Register(
                 new Modification()
                 {
                     OriginalItem = ModAPI.FindSpawnable("Revolver"),
                     NameOverride = "boom gun-ODL",
                     NameToOrderByOverride = "Revolver 4",
                     DescriptionOverride = "BOOM BOOM BOOM",
                     CategoryOverride = ModAPI.FindCategory("Firearms"),
                     ThumbnailOverride = ModAPI.LoadSprite("boomView.png", 5f),
                     AfterSpawn = (Instance) =>
                     {
                         Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("boom.png");
                         var firearm = Instance.GetComponent<FirearmBehaviour>();
                         Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                         customCartridge.name = "nuke";
                         customCartridge.Damage += -0.0000001f;
                         customCartridge.Recoil += 10f;
                         firearm.Cartridge = customCartridge;
                         Instance.AddComponent<Nukegun>();
                     }
                 }
                 );


                ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Dynamite"),
        NameOverride = "Anti Dynamite-ODL",
        NameToOrderByOverride = "Dynamite",
        DescriptionOverride = "so a implosion?",
        CategoryOverride = ModAPI.FindCategory("Explosives"),
        ThumbnailOverride = ModAPI.LoadSprite("antibombView.png"),
        AfterSpawn = (Instance) =>
        {
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("antibomb.png");
            Instance.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Destroy(Instance.GetComponent<ExplosiveBehaviour>());
            Instance.AddComponent<antibomb>();
        }
    }
);


                
                ModAPI.Register(
                 new Modification()
                 {
                     OriginalItem = ModAPI.FindSpawnable("Revolver"),
                     NameOverride = "worp gun-ODL",
                     NameToOrderByOverride = "Revolver 4",
                     DescriptionOverride = "THATS A LOT A DAMAGE!",
                     CategoryOverride = ModAPI.FindCategory("Firearms"),
                     ThumbnailOverride = ModAPI.LoadSprite("worpgunView.png", 5f),
                     AfterSpawn = (Instance) =>
                     {
                         Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("worpgun.png");
                         var firearm = Instance.GetComponent<FirearmBehaviour>();
                         Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                         customCartridge.name = "blackhole";
                         customCartridge.Damage += -0.0000001f;
                         customCartridge.Recoil += 10f;
                         firearm.Cartridge = customCartridge;
                         Instance.AddComponent<Worpgun>();
                     }
                 }
                 );

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Decimator"),
                    NameOverride = "Spawnable Blackhole-ODL",
                    NameToOrderByOverride = "Revolver 4",
                    DescriptionOverride = "Portable put it in your lunchbox!",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("blackholeView.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        GameObject.Instantiate(ModAPI.FindSpawnable("Decimator").Prefab.GetComponent<DecimatorBehaviour>().BlackHole, Instance.transform.position, Quaternion.identity);
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("blackhole.png");
                        Instance.GetComponent<SpriteRenderer>().color = Color.clear;
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(0).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(1).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(2).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(3).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(4).gameObject);
                        BoxCollider2D[] colliders = Instance.GetComponents<BoxCollider2D>();
                        for (int i = 0; i < colliders.Length; i++)
                        {
                            UnityEngine.GameObject.Destroy(colliders[i]);
                        }
                    }
                }
);

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Vector"),
                    NameOverride = "Flordia Man's Minigun-ODL",
                    NameToOrderByOverride = "Revolver 5",
                    DescriptionOverride = "PEW PEW BANG BANG but cooler B)",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("miniflorView.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("miniflor.png");
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "DEATH";
                        customCartridge.Damage += 999999f;
                        customCartridge.Recoil += 999999f;
                        customCartridge.ImpactForce += 999999f;
                        firearm.Cartridge = customCartridge;
                    }
                }
                );


                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Shotgun"),
                    NameOverride = "Flordia Man's Shotgun-ODL",
                    NameToOrderByOverride = "Revolver 6",
                    DescriptionOverride = "The Most Flordia Man of them all",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("fmsgView.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("fmsg.png", 4f);
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "DEATH";
                        customCartridge.Damage += 9999999f;
                        customCartridge.Recoil += 9999999f;
                        customCartridge.ImpactForce += 9999999f;
                        firearm.Cartridge = customCartridge;
                    }
                }
                );



                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Brick"),
                    NameOverride = "Overdose V2",
                    NameToOrderByOverride = "brick 2",
                    DescriptionOverride = "Activate me for Overdose V2",
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                    ThumbnailOverride = ModAPI.LoadSprite("odv2.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var trigger = Instance.AddComponent<UseEventTrigger>();
                        trigger.Event = new UnityEngine.Events.UnityEvent();
                        trigger.Event.AddListener(delegate ()
                        {
                            Utils.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=2148965453");
                        });
                    }
                });
            }
        }
    }
}
            
