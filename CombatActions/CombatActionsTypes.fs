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

module BasicLift =
    type T = BasicLift of int

    // Wrapper
    let create bl = BasicLift bl

    // Unwrapper
    let value (BasicLift bl) = bl