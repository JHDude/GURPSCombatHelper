namespace CombatActions

//module CombatActionsTypes =
//    // type Strength = Strength of int
//    // type BasicLift = BasicLift of int
////    [<Measure>] type lb
////    [<Measure>] type kg
//    // let lbPerKg = 2.20462<lb/kg>

module Strength =
    type T = Strength of int

    // Wrapper
    let create st = Strength st

    // Unwrapper
    let value (Strength st) = st

module Dexterity =
    type T = Dexterity of int

    // Wrapper
    let create dx = Dexterity dx

    // Unwrapper
    let value (Dexterity dx) = dx

module Intelligence =
    type T = Intelligence of int

    // Wrapper
    let create int = Intelligence int

    // Unwrapper
    let value (Intelligence int) = int

module Health =
    type T = Health of int

    // Wrapper
    let create ht = Health ht

    // Unwrapper
    let value (Health ht) = ht

module BasicLift =
    type T = BasicLift of int

    // Wrapper
    let create bl = BasicLift bl

    // Unwrapper
    let value (BasicLift bl) = bl

type NumShots = 
    | NumShots of int

type ProjectileAmount =
    | Projectiles of int

type MultiProjectileAttack =
    {
        N : NumShots;
        P : ProjectileAmount;
    }

type WeaponType =
    | Melee
    | Ranged

type WeaponAcc =
    | Acc of int

type WeaponParry =
    | Parry of int

type WeaponROF =
    {
        ROF : int;
        MxN : MultiProjectileAttack option;
    }

type WeaponRecoil =
    | Recoil of int

type SwingOrThrust =
    | Swing
    | Thrust

type MeleeDamage =
    {
        Base : SwingOrThrust;
        Mod : int;
    }

type RangeDamage =
    {
        Dice : int;
        Mod : int;
    }

/// <summary>
/// Melee Or Range Damage
/// </summary>
type MORDamage =
    | Melee of MeleeDamage
    | Range of RangeDamage

type DamageType =
    | Affliction
    | Burning
    | Corrosion
    | Crushing
    | Cutting
    | Fatigue
    | Impaling
    | SmallPiercing
    | Piercing
    | LargePiercing
    | HugePiercing
    | Toxic

type DamageAndType =
    {
        Damage : MORDamage;
        Type : DamageType;
    }

/// <summary>
/// Lists all damage amounts / types that are linked together.
/// Single element lists are standard attacks
/// </summary>
type LinkedDamage =
    | Linked of List<DamageAndType>

type WeaponDamage =
    {
        MainAttack : LinkedDamage;
        AltAttacks : List<LinkedDamage> option;
    }

/// <summary>
/// The various places you can hit a humanoid in GURPS
/// </summary>
type HitLocation =
    | Torso
    | Vitals
    | Skull
    | Eye
    | Face
    | Neck
    | Groin
    | Arm
    | Leg
    | Hand
    | Foot
    | Weapon

type DamageReduction =
    | DR of int

type DefenseType = 
    | DefendAgainst of DamageType

type DRAndLocation =
    {
        DR : DamageReduction;
        Location : HitLocation;
        Types : List<DefenseType>
    }

type Armor =
    {
        ArmorName : string;
        ArmorAreas : List<DRAndLocation>;
        ArmorWeight : int;

    }