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

type WeaponType =
    | Melee
    | Ranged

type WeaponAcc =
    | Acc of int

type WeaponParry =
    | Parry of int

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