using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System.Collections.Generic;
using System.Collections;

public class InfoManagerScript1 : MonoBehaviour {

	public Text info;
	public AudioSource[] sounds;
	AudioSource current;
	// Use this for initialization
	void Start () {
		current = sounds [6];
	}

	public void onSoundClick()
	{
		current.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours ();

		foreach (TrackableBehaviour tb in tbs) {
			string imageTargetName = tb.TrackableName;
			// ---->Code to be copied<-----//
			if (imageTargetName == "Bison") 
			{
				info.text = "<b>Scientific name :</b>Bison bison athabascae\n<b>Habitat:</b>  River valleys and Prairies\n<b>Life Span :</b> 15 years(approx)\n<b>Food :</b> Grass and Sedges\n<b>Region :</b>  Alaska "; 
				current = sounds [0];
			}
			// -----><-----//
				if (imageTargetName == "boar") 
			{
				info.text = "<b>Scientific name :</b> Sus scrofa\n<b>Habitat:</b>  Deciduous broad-leaf forests\n<b>Life Span :</b> 15 -20 years(approx)\n<b>Food :</b> Small Birds or Mammals\n<b>Region :</b> :  Eurasia and North Africa ";
				current = sounds [1];
			}
			// -----><-----//
				if (imageTargetName == "BrownBear") 
			{
				info.text = "<b>Scientific name :</b> Ursus arctos\n<b>Habitat:</b> High Mountain and Forests\n<b>Life Span :</b> 20 -25years(approx)\n<b>Food :</b> Grass and Small Animals\n<b>Region :</b> North America ";
				current = sounds [6];
			}
				// -----><-----//
				if (imageTargetName == "chimpanzee") 
			{
				info.text = "<b>Scientific name :</b>Pan\n<b>Habitat :</b>Openwoodlands and Forests\n<b>Life Span :</b>  40 years(approx)\n<b>Food :</b> Fruits and Insects\n<b>Region :</b> Southwest Tanzania ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "deer") 
			{
				info.text = "<b>Scientific name :</b> Cervidae\n<b>Habitat:</b> Hardwoods and Pasturelands\n<b>Life Span:</b> 10 -13years(approx)\n<b>Food :</b> Acorns and Pecans \n<b>Region :</b> Colombia and Venezuela ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "eagle") 
			{
				info.text = "<b>Scientific name:</b>Haliaeetus Leucocephalus\n<b>Habitat:</b> Sea Coasts\n<b>Life Span:</b>20 years(approx)\n<b>Food :</b>Snakes and Fish\n<b>Region:</b> Canada and Alaska";
				current = sounds [3];
			}
			// -----><-----//
				if (imageTargetName == "elephant") 
			{
				info.text = "<b>Scientific name :</b> Elephas maximus\n<b>Habitat:</b>Grasslands and Forests\n<b>Life Span:</b> 40-50 years(approx)\n<b>Food :</b> Grasses and Small Plants\n<b>Region :</b> Africa and Asia";
				current = sounds [4];
			}
			// -----><-----//
				if (imageTargetName == "fly") 
			{
				info.text = "<b>Scientific name :</b> Musca Domestica\n<b>Habitat:</b> Everywhere\n<b>Life Span :</b> 28 days(approx)\n<b>Food :</b> Liquid or Semiliquid Substances\n<b>Region :</b> Middle East";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "giraffe") 
			{
				info.text = "<b>Scientific name :</b> Giraffa Camelopardalis\n<b>Habitat:</b> Grasslands or Woodlands\n<b>Life Span :</b> 25 years(approx)\n<b>Food :</b> Flowers and Fruits\n<b>Region :</b> West Africa";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "hare") 
			{
				info.text = "<b>Scientific name :</b> Lepus\n<b>Habitat :</b> Farmland\n<b>Life Span :</b> 6 – 7 years(approx)\n<b>Food :</b> Grass and Fruits\n<b>Region :</b> Northern Canada";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "Horse") 
			{
				info.text = " <b>Scientific name :</b>Equus Ferus Caballus\n<b>Habitat:</b> Wide Open Spaces\n<b>Life Span:</b>25 – 30 years(approx)\n<b>Food :</b> Grass\n<b>Region :</b> Europe and Asia";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "killerwhale") 
			{
				info.text = "<b>Scientific name :</b> Orcinus Orca\n<b>Habitat:</b> Oceans\n<b>Life Span :</b> 17-20 years(approx)\n<b>Food :</b> Sea Animals\n<b>Region :</b>Arctic and Antarctic Regions";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "octopus") 
			{
				info.text = "<b>Scientific name :</b> Enteroctopus Dofleini\n<b>Habitat:</b> Oceans\n<b>Life Span:</b> 3 – 5 years(approx)\n<b>Food :</b> Crabs amd Worms\n<b>Region :</b>Tropical and Temperate waters ";
				current = sounds [6];
			}
				// -----><-----//
				if (imageTargetName == "ostrich") 
			{
				info.text = "<b>Scientific name :</b> Struthio Camelus\n<b>Habitat:</b> Sandy and Arid Places\n<b>Life Span:</b> 40–45 years(approx)\n<b>Food :</b>Fruits and Shrubs \n<b>Region :</b>Southern and Eastern Africa ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "scorpion") 
			{
				info.text = "<b>Scientific name :</b> Scorpiones\n<b>Habitat:</b> Deserts and Jungle\n<b>Life Span:</b> 4-25 years(approx)\n<b>Food :</b> Insects\n<b>Region :</b>ASia,Africa,Europe ";
				current = sounds [6];
				}
			// -----><-----//
				if (imageTargetName == "tarantula") 
			{
				info.text = "<b>Scientific name :</b> Theraphosidae\n<b>Habitat:</b>  Arid and SemiDesert Regions\n<b>Life Span:</b> 15 – 25 years(approx)\n<b>Food :</b> Insects\n<b>Region :</b>  North America ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "tortoise") 
			{
				info.text = "<b>Scientific name :</b> Testudinidae\n<b>Habitat:</b>  Land or Fresh Waters\n<b>Life Span:</b> 100 years(approx)\n<b>Food :</b>Grasses and Insects\n<b>Region :</b>North Western Mexico ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "Shark") 
			{
				info.text = "<b>Scientific name :</b>Carcharodon Carcharias \n<b>Habitat:</b>  Coastal Areas\n<b>Life Span:</b> 100 years(approx)\n<b>Food :</b>  Fishes\n<b>Region :</b> South Africa and Japan ";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "Tiger") 
			{
				info.text = "<b>Scientific name :</b> Panthera Tigris\n<b>Habitat:</b> Forests\n<b>Life Span:</b> 20 – 26 years(approx)\n<b>Food :</b>Wild Animals\n<b>Region :</b> Asia ";
				current = sounds [2];
			}
			// -----><-----//// -----><-----//// -----><-----//// -----><-----//// -----><-----//// -----><-----//
			
			if (imageTargetName == "trex") 
			{
				info.text = "<b>Scientific name :</b> Tyrannosaurus\n<b>Habitat:</b>  Humid Environment\n<b>Life Span:</b> 20-30 years(approx)\n<b>Food :</b>Wild Animals\n<b>Region :</b> North America";
				current = sounds [6];
				}
			// -----><-----//
				if (imageTargetName == "triceratop") 
			{
				info.text = "<b>Scientific name :</b> Triceratops\n<b>Habitat:</b> Grasslands\n<b>Life Span:</b> 200 years(approx)\n<b>Food :</b>Plants\n<b>Region :</b> North America";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "stegosaurus") 
			{
				info.text = "<b>Scientific name :</b> Stegosaurus\n<b>Habitat:</b> Subtropical Areas\n<b>Life Span:</b> 75 to 100 years(approx)\n<b>Food :</b>Plants\n<b>Region :</b> Western North America";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "pterosaurs") 
			{
				info.text = "<b>Scientific name :</b> Pterosauria\n<b>Habitat:</b>Hilly Areas\n<b>Life Span:</b> 75 to 100 years(approx)\n<b>Food :</b>Wild Animals\n<b>Region :</b> Europe and South Africa";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "spinosaurus") 
			{
				info.text = "<b>Scientific name :</b> Spinosaurus\n<b>Habitat:</b>Swamps\n<b>Life Span:</b> 100 years(approx)\n<b>Food :</b>Wild Animals and Fishes\n<b>Region :</b> North Africa";
				current = sounds [5];
			}
			// -----><-----//
				if (imageTargetName == "godzilla") 
			{
				info.text = "Godzilla is a fictional giant monster.\nWeigh upto 164,000 tons.\nHeight upto 70 Feet.";
				current = sounds [6];
			}
			// -----><-----//
				if (imageTargetName == "dragon") 
			{
				info.text = "A dragon is a legendary creature.\nWeigh Upto 18 Tonnes.\nHeight upto 10 feet";
				current = sounds [6];
			}
		}
	}
}
