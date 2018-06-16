using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTutA
{
		class Program
		{

				static void Main(string[] args)
				{
					QueryStringArray();
					QueryIntArray();
					QueryArrayList();
					QueryCollection();
					QueryAnimalData();
					Console.ReadLine();
				}

				static void QueryStringArray()
				{
					string[] dogs = {"K 9", "Brian Griffin", "Scoopy Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy"};

					var dogsSpaces = from dog in dogs
														where dog.Contains(" ")
														orderby dog descending
														select dog;
					
					foreach (var i in dogsSpaces)
					{
							System.Console.WriteLine(i);
					}
					System.Console.WriteLine();
				}

				static int[] QueryIntArray()
				{
					int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

					var gt20 = from num in nums
											where num > 20
											orderby num
											select num;

					foreach (var i in gt20)
					{
						System.Console.WriteLine(i);
					}
					System.Console.WriteLine();

					System.Console.WriteLine($"Get Type : {gt20.GetType()}");

					var listGT20 = gt20.ToList<int>();
					var arrayGT20 = gt20.ToArray();

					nums[0] = 40;

					foreach (var i in gt20)
					{
							System.Console.WriteLine(i);
					}

					System.Console.WriteLine();
					return arrayGT20;
				}

				static void QueryArrayList()
				{
					ArrayList famAnimals = new ArrayList()
					{
						new Animal
						{
							Name = "Heidi",
							Height = .8,
							Weight = 18
						},
						new Animal
						{
							Name = "Shrek",
							Height = 4,
							Weight = 130
						},
						new Animal
						{
							Name = "Congo",
							Height = 3.8,
							Weight = 90
						}
					};

					var famAnimalEnumerable = famAnimals.OfType<Animal>();

					var smAnimals = from animal in famAnimalEnumerable
													where animal.Weight <= 90
													orderby animal.Name
													select animal;
					
					foreach (var animal in smAnimals)
					{
						System.Console.WriteLine("{0} weighs {1} lbs", animal.Name, animal.Weight);
					}

					System.Console.WriteLine();
				}

				static void QueryCollection()
				{
					var animalList = new List<Animal>()
					{
						new Animal
						{
							Name = "German Shepherd",
							Height = 25,
							Weight = 77
						},
						new Animal
						{
							Name = "Chihuahua",
							Height = 7,
							Weight = 4.4
						},
						new Animal
						{
							Name = "Saint Bernard",
							Height = 30,
							Weight = 200
						}
					};

					var bigDogs = from dog in animalList
												where (dog.Weight > 70) && (dog.Height > 25)
												orderby dog.Name
												select dog;

					foreach (var dog in bigDogs)
					{
						System.Console.WriteLine("A {0} weighs {1} lbs", dog.Name, dog.Weight);
					}

					System.Console.WriteLine();
				}

				static void QueryAnimalData()
				{
					Animal[] animals = new[]
					{
						new Animal
						{
							Name = "German Shepherd",
							Height = 25,
							Weight = 77,
							AnimalID = 1
						},
						new Animal
						{
							Name = "Chihuahua",
							Height = 7,
							Weight = 4.4,
							AnimalID = 2
						},
						new Animal
						{
							Name = "Saint Bernard",
							Height = 30,
							Weight = 200,
							AnimalID = 3
						},
						new Animal
						{
							Name = "Pug",
							Height = 12,
							Weight = 16,
							AnimalID = 1
						},
						new Animal
						{
							Name = "Beagle",
							Height = 15,
							Weight = 23,
							AnimalID = 2
						}
					};

					Owner[] owners = new[]
					{
						new Owner
						{
							Name = "Doug Parks",
							OwnerID = 1
						},
						new Owner
						{
							Name = "Sally Smith",
							OwnerID = 2
						},
						new Owner
						{
							Name = "Paul Brooks",
							OwnerID = 3
						}
					};

					var nameHeight = from a in animals
														select new
														{
															a.Name,
															a.Height
														};
					
					Array arrNameHeight = nameHeight.ToArray();

					foreach (var i in arrNameHeight)
					{
							System.Console.WriteLine(i.ToString());
					}
					System.Console.WriteLine();

					var innerJoin =
							from animal in animals
							join owner in owners on animal.AnimalID
							equals owner.OwnerID
							select new
							{
								OwnerName = owner.Name,
								AnimalName = animal.Name
							};

					foreach (var i in innerJoin)
					{
						System.Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);
					}
					System.Console.WriteLine();

					var groupJoin = from owner in owners
													orderby owner.OwnerID
													join animal in animals
													on owner.OwnerID
													equals animal.AnimalID
													into ownerGroup
													select new
													{
														Owner = owner.Name,
														Animals = from owner2
																			in ownerGroup
																			orderby owner2.Name
																			select owner2
													};
						
						foreach (var ownerGroup in groupJoin)
						{
								System.Console.WriteLine(ownerGroup.Owner);
								foreach (var animal in ownerGroup.Animals)
								{
										System.Console.WriteLine("* {0}", animal.Name);
								}
						}
				}
		}
}
