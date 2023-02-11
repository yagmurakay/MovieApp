using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository(){
            _movies = new List<Movie>()
            {
              new Movie()
              {
                  Id=1,
                  Name="Shazam(2019)",
                  ShortDescription="A newly fostered young boy in search of his mother instead finds unexpected super powers and soon gains a powerful enemy.",
                  Description= "<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother.</p> <p> However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion.</p> <p> Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy.</p> <p> However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead.</p> <p> Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand.</p>",
                  ImageUrl="1.jpg",
                  CategoryId=1
                     },
              new Movie()
              {
                  Id=2,
                  Name="Extraction(2020)",
                  ShortDescription="Tyler Rake, a fearless black market mercenary, embarks on the most deadly extraction of his career when he's enlisted to rescue the kidnapped son of an imprisoned international crime lord",
                 Description= "<p>In an underworld of weapons dealers and traffickers, a young boy becomes the pawn in a war between notorious drug lords.</p> <p> Trapped by kidnappers inside one of the world's most impenetrable cities, his rescue beckons the unparalleled skill of a mercenary named Tyler Rake, but Rake is a broken man with nothing to lose, harboring a death wish that makes an already deadly mission near impossible.</p>",
                  ImageUrl="2.jpg",
                  CategoryId=1
                     },
              new Movie()
               {
                  Id=3,
                  Name="Aquaman(2018)",
                  ShortDescription="Arthur Curry, the human-born heir to the underwater kingdom of Atlantis, goes on a quest to prevent a war between the worlds of ocean and land.",
                  Description= "<p>Born upon the shores of the surface world, Arthur Curry (Jason Momoa) discovers that he is only half human, with the other half of his blood being of Atlanteean descent, thus making him the rightful heir to the throne of the undersea kingdom of Atlantis.</p> <p> However, Arthur learns that Atlantis is being ruled by his malicious half-brother Orm (Patrick Wilson), who seeks to unite the seven underwater kingdoms and wage war upon the surface.</p> <p> With aid from Nuidis Vulko (Willem Dafoe) and the gorgeous Mera (Amber Heard), Arthur must discover the full potential of his true destiny and become Aquaman in order to save Atlantis and the surface from Orm's evil plot. </p>",
                  ImageUrl="3.jpg",
                  CategoryId=2
                     },
              new Movie()
               {
                  Id=4,
                  Name="Ad Astra (2019) ",
                  ShortDescription="Astronaut Roy McBride undertakes a mission across an unforgiving solar system to uncover the truth about his missing father and his doomed expedition that now, 30 years later, threatens the universe.",
                  Description= "<p>Astronaut Roy McBride (Brad Pitt) travels to the outer edges of the solar system to find his missing father and unravel a mystery that threatens the survival of our planet.</p> <p>  His journey will uncover secrets that challenge the nature of human existence and our place in the cosmos.</p>",
                  ImageUrl="4.jpg",
                  CategoryId=2
                     },
              new Movie()
               {
                  Id=5,
                  Name="Over The Moon (2020)",
                  ShortDescription="In this animated musical, a girl builds a rocket ship and blasts off, hoping to meet a mythical moon goddess.",
                  Description= "<p>In this animated musical, a girl builds a rocket ship and blasts off, hoping to meet a mythical moon goddess.</p>",
                  ImageUrl="5.jpg",
                  CategoryId=3

                     },

                      new Movie()
               {
                  Id=6,
                  Name="The Boss Baby(2017)",
                  ShortDescription="A suit-wearing, briefcase-carrying baby pairs up with his 7-year old brother to stop the dastardly plot of the CEO of Puppy Co.",
                  Description= "<p>Seven-year-old Tim Templeton has always had an overactive imagination--and for the past seven years--life has been all peaches for him, getting all the love and affection from his caring parents.</p> <p> However, after the arrival of Boss Baby, an unexpected new brother dressed in a black suit complete with a tie and a briefcase, Tim won't be the centre of attention anymore, as the powerful sibling takes over the whole house, robbing him of all care, little by little.</p> <p> But, soon, Tim and the new Boss in a diaper will need to put differences aside and join forces, as a sneaky scheme involving the head of Puppy Co. threatens to tilt the balance of power towards their insidiously adorable furry antagonists, not to mention that the next Pet Convention is only in two days. Brothers, hurry up.</p>",
                  ImageUrl="6.jpg",
                  CategoryId=3
                     },

                      new Movie()
               {
                  Id=7,
                  Name="The SpongeBob SquarePants(2004)",
                  ShortDescription="After SpongeBob's beloved pet snail Gary is snail-napped, he and Patrick embark on an epic adventure to The Lost City of Atlantic City to bring Gary home.",
                  Description= "<p>Set before the events of the television series, SpongeBob goes on a trip to Kamp Koral and meets some new friends.</p> <p> However, when his pet snail Gary gets kidnapped by Poseidon and taken to the Lost City of Atlantic City, he and his new best friend Patrick must go on a rescue mission to save him from the dastardly plan of Poseidon before it is too late.</p> <p> The movie will also reveal the first time our beloved characters (as kids) met at Camp...a magical moment that brings meaning to the power of true friendship. </p>",
                  ImageUrl="7.jpg",
                  CategoryId=4
                     },

                    new Movie()
               {
                  Id=8,
                  Name="Despicable Me 3 (2017) ",
                  ShortDescription="Gru meets his long-lost, charming, cheerful, and more successful twin brother Dru, who wants to team up with him for one last criminal heist.",
                  Description= "<p> After he is fired from the Anti-Villain League for failing to take down the latest bad guy to threaten humanity, Gru (Steve Carell) finds himself in the midst of a major identity crisis.</p> <p> But when a mysterious stranger shows up to inform Gru that he has a long-lost twin brother - a brother who desperately wishes to follow in his twin's despicable footsteps - one former supervillain will rediscover just how good it feels to be bad. </p>",
                  ImageUrl="8.jpg",
                  CategoryId=4
                     },

                     new Movie()
               {
                  Id=9,
                  Name="Troop Zero (2019)",
                  ShortDescription="In rural 1977 Georgia, a misfit girl dreams of life in outer space. When a competition offers her a chance to be recorded on NASA's Golden Record, she recruits a makeshift troop of Birdie Scouts, forging friendships that last a lifetime.",
                  Description= "<p> January seems like it was 12 years ago instead of just 12 months ago, but people who can remember that far back may also remember enjoying Bert & Bertie’s sweet scout comedy Troop Zero.</p> <p>  It’s awesome enough to see the twin powerhouses Viola Davis and Allison Janney go head to head as rival scout leaders, but it’s also a film that has charm to spare and a delightful ensemble of young performers led by star-in-the-making Mckenna Grace.</p> <p> The spirit of classics like Troop Beverley Hills flows through it, and unlike most of the other selections on this list it can be appreciated by audiences of all ages. </p>",
                  ImageUrl="9.jpg",
                  CategoryId=5
                     },
                            new Movie()
               {
                  Id=10,
                  Name="Jojo Rabbit(2019)",
                  ShortDescription="A young boy in Hitler's army finds out his mother is hiding a Jewish girl in their home.",
                  Description= "<p> A World War II satire that follows a lonely German boy named Jojo (Roman Griffin Davis) whose world view is turned upside down when he discovers his single mother (Scarlett Johansson) is hiding a young Jewish girl (Thomasin McKenzie) in their attic.</p> <p> Aided only by his idiotic imaginary friend, Adolf Hitler (Taika Waititi), Jojo must confront his blind nationalism. </p>",
                  ImageUrl="10.jpg",
                  CategoryId=5
                     },
                            new Movie()
               {
                  Id=11,
                  Name="Citizen Kane(1941)",
                  ShortDescription="Following the death of publishing tycoon Charles Foster Kane, reporters scramble to uncover the meaning of his final utterance; 'Rosebud'.",
                  Description= "<p> A group of reporters are trying to decipher the last word ever spoken by Charles Foster Kane, the millionaire newspaper tycoon: 'Rosebud'.</p> <p> The film begins with a news reel detailing Kane's life for the masses, and then from there, we are shown flashbacks from Kane's life.</p> <p>  As the reporters investigate further, the viewers see a display of a fascinating man's rise to fame, and how he eventually fell off the top of the world.</p>",
                  ImageUrl="11.jpg",
                  CategoryId=6
                     },
                            new Movie()
               {
                  Id=12,
                  Name="Talaash(2012)",
                  ShortDescription="Inspector Surjan Shekhawat, who is dealing with a depressing past, has to investigate a high profile murder case, deal with his crumbling marriage and use the help and solace of a prostitute by the name of Rosie.",
                  Description= "<p>Seeing reflections of Mumbai under the red light, Talaash is a tale of love lost, fatal attraction and above all the quest to solve a perfect crime.</p> <p>  Suspense at its core, Talaash explores Mumbai's underbelly like never before. Aamir Khan plays an investigation officer, Inspector Shekhawat who receives a phone call early in the morning informing him about death and an accident and how everything starts to unfold from there.</p> <p> The case turns into a life altering chase for Inspector Shekhawat when he is forced to reel under the repercussions of a broken married life with his wife Roshni played by Rani Mukherji and come face to face with his suppressed grief.</p> <p> Being on his investigational quest and fighting it out with personal struggle, Inspector Shekhawat meets a sex worker Rosie played by Kareena Kapoor who further adds shades of mystery to the puzzle. What looks like a simple car accident investigation turns into a haunting mystery as further investigations show many anomalies stringed ... </p>",
                  ImageUrl="12.jpg",
                  CategoryId=6
                     },
                            new Movie()
               {
                  Id=13,
                  Name="Warcraft(2016)",
                  ShortDescription="As an Orc horde invades the planet Azeroth using a magic portal, a few human heroes and dissenting Orcs must attempt to stop the true evil behind this war.",
                  Description= "<p> When the world of the Orcs of Draenor is being destroyed by the evil fel magic that uses life-force, the powerful warlock Gul'dan creates a portal to the world of Azeroth and forms the Horde with members of the Orc clans.</p> <p> He also captures many prisoners to keep the portal open. The king of Azeroth, Llane Wrynn and his brother-in-law, Anduin Lothar are informed by the apprentice of magician Khadgar that he has found fel magic in dead bodies and the king decides to summon the Guardian of Tirisfal, Medivh, to protect his kingdom.</p> <p> Lothar and Khadgar head to Kharazhan to meet Medivh and an ominous shadow points a book out to Khadgar, who takes it and hides. Anduin, Khadgar and Medivh and a group of soldiers are attacked by Orcs and they capture the slave Garona, who is released by King Llane, and she shows them the location of the portal. Garona is contacted by the Orc chief of a clan Durotan that wants to meet King Llane to stop the fel magic. Meanwhile Khadgar learns that the gate was ... </p>",
                  ImageUrl="13.jpg",
                  CategoryId=7
                     },
                            new Movie()
               {
                  Id=14,
                  Name="Fantastic Four(2015)",
                  ShortDescription="Four young outsiders teleport to an alternate and dangerous universe which alters their physical form in shocking ways. The four must learn to harness their new abilities and work together to save Earth from a former friend turned enemy.",
                  Description= "<p>FANTASTIC FOUR, a contemporary re-imagining of Marvel's original and longest-running superhero team, centers on four young outsiders who teleport to an alternate and dangerous universe, which alters their physical form in shocking ways.</p> <p> Their lives irrevocably upended, the team must learn to harness their daunting new abilities and work together to save Earth from a former friend turned enemy. </p>",
                  ImageUrl="14.jpg",
                  CategoryId=7
                     },
                            new Movie()
               {
                  Id=15,
                  Name="The Shining(1980)",
                  ShortDescription="A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.",
                  Description= "<p>Haunted by a persistent writer's block, the aspiring author and recovering alcoholic, Jack Torrance, drags his wife, Wendy, and his gifted son, Danny, up snow-capped Colorado's secluded Overlook Hotel after taking up a job as an off-season caretaker.</p> <p> As the cavernous hotel shuts down for the season, the manager gives Jack a grand tour, and the facility's chef, the ageing Mr Hallorann, has a fascinating chat with Danny about a rare psychic gift called 'The Shining', making sure to warn him about the hotel's abandoned rooms, and, in particular, the off-limits Room 237. However, instead of overcoming the dismal creative rut, little by little, Jack starts losing his mind, trapped in an unforgiving environment of seemingly endless snowstorms, and a gargantuan silent prison riddled with strange occurrences and eerie visions.</p> <p> Now, the incessant voices inside Jack's head demand sacrifice. Is Jack capable of murder? </p>",
                  ImageUrl="15.jpg",
                  CategoryId=8
                     },
                            new Movie()
               {
                  Id=16,
                  Name=" Hereditary (2018)",
                  ShortDescription="A grieving family is haunted by tragic and disturbing occurrences.",
                  Description= "<p>When her mentally ill mother passes away, Annie (Toni Collette), her husband (Gabriel Byrne), son (Alex Wolff), and daughter (Milly Shapiro) all mourn her loss. The family turn to different means to handle their grief, including Annie and her daughter both flirting with the supernatural.</p> <p> They each begin to have disturbing, otherworldly experiences linked to the sinister secrets and emotional trauma that have been passed through the generations of their family. </p>",
                  ImageUrl="16.jpg",
                  CategoryId=8
                     },
                            new Movie()
               {
                  Id=17,
                  Name="The Trial of the Chicago 7(2020)",
                  ShortDescription="The story of 7 people on trial stemming from various charges surrounding the uprising at the 1968 Democratic National Convention in Chicago, Illinois.",
                  Description= "<p> In Chicago 1968, the Democratic Party Convention was met with protests from activists like the moderate Students for a Democratic Society led by Tom Hayden and the militant Yippies led by Abbie Hoffman and Jerry Rubin, which led to violent confrontations with the local authorities.</p> <p> As a result, seven of the accused ringleaders are arraigned on charges like Conspiracy by the hostile Nixon administration, including Bobby Seale of the Black Panthers who was not involved in the incident. What follows is an unfair trial presided by the belligerent Judge Hoffman (No relation) and prosecuted by a reluctant but duty-bound Richard Schultz.</p> <p> As their pro bono lawyers face such odds, Hayden and his fellows are frustrated by the Yippies' outrageous antics undermining their defense in defiance of the system even while Seale is denied a chance to defend himself his way.</p> <p> Along the way, the Chicago 7 clash in their political philosophies even as they learn they need each other in this fight.</p>",
                  ImageUrl="17.jpg",
                  CategoryId=9
                     },
                            new Movie()
               {
                  Id=18,
                  Name="The Revenant(2015)",
                  ShortDescription="A frontiersman on a fur trading expedition in the 1820s fights for survival after being mauled by a bear and left for dead by members of his own hunting team.",
                  Description= "<p> While exploring uncharted wilderness in 1823, legendary frontiersman Hugh Glass sustains injuries from a brutal bear attack.</p> <p> When his hunting team leaves him for dead, Glass must utilize his survival skills to find a way back home while avoiding natives on their own hunt. Grief-stricken and fueled by vengeance, Glass treks through the wintry terrain to track down John Fitzgerald, the former confidant who betrayed and abandoned him.</p>",
                  ImageUrl="18.jpg",
                  CategoryId=9
                     },
                            new Movie()
               {
                  Id=19,
                  Name="The Rocky Horror Picture Show (1975)",
                  ShortDescription="A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter.",
                  Description= "<p>On a wild and rain-swept late-November evening, somewhere at an empty stretch of road outside Ohio's merry Denton, blissfully-affianced, prudish, boringly-innocent young pair Brad Majors (Barry Bostwick) and Janet Weiss (Susan Sarandon) find themselves stranded on their way to visit an ex-tutor. Instead, the couple will inadvertently unearth the cross-dressing Dr. Frank-N-Furter's (Tim Curry's) spooky lair of inexhaustible oddities, just in time to partake in the out-of-this-world mad scientist's proud unveiling of his latest, delightfully extravagant, most daring creation: the ultimate male and the perfect sex symbol: the flaxen-haired Rocky Horror (Peter Hinwood). But, little by little, as the effervescent transgressive force gobbles up whole the unsuspecting visitors of the night, Brad and Janet slowly begin to embrace the potent fascinations of seduction, while an idolized Rocky roams free in the mansion. Who can interrupt man's union with the absolute pleasure? </p>",
                  ImageUrl="19.jpg",
                  CategoryId=10
                     },
                            new Movie()
               {
                  Id=20,
                  Name="Going My Way (1944)",
                  ShortDescription="When young Father O'Malley arrives at St. Dominic's, old Father Fitzgibbon doesn't think much of the church's newest member.",
                  Description= "<p>Youthful Father Chuck O'Malley led a colorful life of sports, song, and romance before joining the Roman Catholic clergy, but his level gaze and twinkling eyes make it clear that he knows he made the right choice. After joining a parish, O'Malley's worldly knowledge helps him connect with a gang of kids looking for direction and handle the business details of the church-building fund, winning over his aging, conventional superior, Father Fitzgibbon. </p>",
                  ImageUrl="20.jpg",
                  CategoryId=10
                     },
                            new Movie()
               {
                  Id=21,
                  Name="I Origins (2014)",
                  ShortDescription="A molecular biologist and his laboratory partner uncover evidence that may fundamentally change society as we know it.",
                  Description= "<p> I Origins begins when graduate student, Ian Gray, is researching the evolution of human eyes with Karen and Kenny, in order to prove that eyes have evolved instead of 'appeared' as creationists claim. His fascination with eyes takes him into areas that have profound personal and cultural consequences.</p>",
                  ImageUrl="21.jpg",
                  CategoryId=11
                     },
                            new Movie()
               {
                  Id=22,
                  Name="One-Way to Tomorrow (2020)",
                  ShortDescription="A romantic story of two strangers who come across each other on a journey from Ankara to Izmir.",
                  Description= "A romantic story of two strangers who come across each other on a journey from Ankara to Izmir.",
                  ImageUrl="22.jpg",
                  CategoryId=11
                     },
                            new Movie()
               {
                  Id=23,
                  Name="High Life(2018)",
                  ShortDescription="A father and his daughter struggle to survive in deep space where they live in isolation.",
                  Description= "<p>Takes place beyond the solar system in a future that seems like the present.</p> <p> About a group of criminals who accept a mission in space to become the subjects of a human reproduction experiment.</p> <p> They find themselves in the most unimaginable situation after a storm of cosmic rays hit the ship. </p>",
                  ImageUrl="23.jpg",
                  CategoryId=12
                     },
                            new Movie()
               {
                  Id=24,
                  Name="The Butterfly Effect(2004) ",
                  ShortDescription="Evan Treborn suffers blackouts during significant events of his life. As he grows up, he finds a way to remember these lost memories and a supernatural way to alter his life by reading his journal.",
                  Description= "<p> As a child, Evan Treborn was afflicted with blackouts where he would be in one place one minute and then another the next, remembering absolutely nothing in-between. Now all grown up and in college, he decides to read from an old journal he wrote to remember stuff that might have happened in the in-between, and suddenly finds himself back at a certain point in his life. He realizes that those blackouts he had were actually empty spaces of time he had to fill up later in life.</p> <p> Attempting to use this ability to undo unpleasant past events, Evan starts to find that every time he goes back and tries to fix things, he ends up making everything worse.</p> <p> How can he prevent more tragedies from happening and save the one girl he ever loved, Kayleigh (Amy Smart)?</p>",
                  ImageUrl="24.jpg",
                  CategoryId=12
                     },
                            new Movie()
               {
                  Id=25,
                  Name="Dangerous Lies (2020)",
                  ShortDescription="When a wealthy elderly man dies and unexpectedly leaves his estate to his new caregiver, she's drawn into a web of deception and murder. If she's going to survive, she'll have to question everyone's motives - even the people she loves.",
                  Description= "<p>When a wealthy elderly man dies and unexpectedly leaves his estate to his new caregiver, she's drawn into a web of deception and murder.</p> <p> If she's going to survive, she'll have to question everyone's motives - even the people she loves. </p> ",
                  ImageUrl="25.jpg",
                  CategoryId=13
                     },
                            new Movie()
               {
                  Id=26,
                  Name="Don't Breathe(2016)",
                  ShortDescription="Hoping to walk away with a massive fortune, a trio of thieves break into the house of a blind man who isn't as helpless as he seems.",
                  Description= "<p> Rocky, a young woman wanting to start a better life for her and her sister, agrees to take part in the robbery of a house owned by a wealthy blind man with her boyfriend Money and their friend Alex.</p> <p> But when the blind man turns out to be a more ruthless adversary than he seems, the group must find a way to escape his home before they become his latest victims. </p>",
                  ImageUrl="26.jpg",
                  CategoryId=13
                     },
                            new Movie()
               {
                  Id=27,
                  Name="The Exception(2016)",
                  ShortDescription="A German soldier tries to determine if the Dutch resistance has planted a spy to infiltrate the home of Kaiser Wilhelm in Holland during the onset of World War II, but falls for a young Jewish Dutch woman during his investigation.",
                  Description= "<p> Whiling away the hours in an isolated countryside estate near Nazi-occupied Utrecht, the abdicated German emperor, Kaiser Wilhelm II, is still considered an influential man, and above all, a desirable assassination target.</p> <p> As a result, to avert a possible attempt against the life of the silver-haired former monarch, the reluctant Wehrmacht Captain, Stefan Brandt, is put in charge of his security, as there are rumours that a stealthy spy is in their midst.</p> <p> However, against all odds, Stefan will commence a fervent clandestine affair with the mansion's cryptic Dutch handmaiden, Mieke de Jong, threatening to put in jeopardy an already dangerously volatile situation.</p> <p> Now, with the imminent arrival of the powerful Reichsführer, Heinrich Himmler, can Brandt protect both the Kaiser and the unexpected love of his life?</p>",
                  ImageUrl="27.jpg",
                  CategoryId=14
                     },
                            new Movie()
               {
                  Id=28,
                  Name="Sand Castle (2017)",
                  ShortDescription="The story follows a young soldier, and his introduction into the 2003 invasion of Iraq. Based on true events, it bears witness to the destruction, and horrors of war.",
                  Description= "<p> A soldier enlists just before the 9/11. He is not a brave man--simply volunteering to defend freedom. Arriving in Iraq in 2003, just after the occupation of Bagdad, with a few soldiers of his infantry platoon, he is sent to provide water to a village whose infrastructure was destroyed.</p> <p> Simple things however, such as water transportation, water distribution and the reconstruction of the plumbing became a challenge in war environment.</p>",
                  ImageUrl="28.jpg",
                  CategoryId=14
                     },
                            new Movie()
               {
                  Id=29,
                  Name="Slow West (2015)",
                  ShortDescription="A young Scottish man travels across America in pursuit of the woman he loves, attracting the attention of an outlaw who is willing to serve as a guide.",
                  Description= "<p> 'Slow West' follows a 16-year-old boy on a journey across 19th Century frontier America in search of the woman he loves, while accompanied by mysterious traveler Silas.</p>",
                  ImageUrl="29.jpg",
                  CategoryId=15
                     },
                            new Movie()
               {
                  Id=30,
                  Name="The Comancheros(1961)",
                  ShortDescription="Texas Ranger Jake Cutter arrests gambler Paul Regret, but soon finds himself teamed with his prisoner in an undercover effort to defeat a band of renegade arms merchants and thieves dealing with the Comanches known as Comancheros.",
                  Description= "Texas Ranger Jake Cutter arrests gambler Paul Regret, but soon finds himself teamed with his prisoner in an undercover effort to defeat a band of renegade arms merchants and thieves dealing with the Comanches known as Comancheros.",
                  ImageUrl="30.jpg",
                  CategoryId=15
                     },
            };
        }
        public static List<Movie> Movies {
            get {
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i => i.Id ==id);
        }

    }
}