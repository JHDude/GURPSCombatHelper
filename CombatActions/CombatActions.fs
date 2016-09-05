namespace CombatActions

type CombatActions() =

    /// <summary>
    /// Given a strength score, calculates basic lift
    /// </summary>
    /// <param name="st"></param>
    member private this.CalcBL (Strength.Strength st) =
        (st * st) / 5
        |> BasicLift.BasicLift

    /// <summary>
    /// Returns a tuple of #die to roll, and the modifier needed
    /// </summary>
    /// <param name="st"></param>
    member private this.ThrustDam (Strength.Strength st) =
        match st with
        | 1 -> (1, -6)
        | 2 -> (1, -6)
        | 3 -> (1, -5)
        | 4 -> (1, -5)
        | 5 -> (1, -4)
        | 6 -> (1, -4)
        | 7 -> (1, -3)
        | 8 -> (1, -3)
        | 9 -> (1, -2)
        | 10 -> (1, -2)
        | 11 -> (1,  -1)
        | 12 -> (1, -1)
        | 13 -> (1, 0)
        | 14 -> (1, 0)
        | 15 -> (1, 1)
        | 16 -> (1, 1)
        | 17 -> (1, 2)
        | 18 -> (1, 2)
        | 19 -> (2, -1)
        | 20 -> (2, -1)
        | 21 -> (2, 0)
        | 22 -> (2, 0)
        | 23 -> (2, 1)
        | 24 -> (2, 1)
        | 25 -> (2, 2)
        | 26 -> (2, 2)
        | 27 -> (3, -1)
        | 28 -> (3, -1)
        | 29 -> (3, 0)
        | 30 -> (3, 0)
        | 31 -> (3, 1)
        | 32 -> (3,1)
        | 33 -> (3,2)
        | 34 -> (3, 2)
        | 35 -> (4, -1)
        | 36 -> (4,-1)
        | 37 -> (4, 0)
        | 38 -> (4, 0)
        | 39 -> (4, 1)
        | 40 -> (4, 1)
        | a when a <=45 -> (5,0)
        | a when a <= 50 -> (5, 2)
        | a when a <= 55 -> (6,0)
        | a when a <= 60 -> (7, -1)
        | a when a <= 65 -> (7,1)
        | a when a <= 70 -> (8, 0)
        | a when a <= 75 -> (8, 2)
        | a when a <= 80 -> (9,0)
        | a when a <= 85 -> (9,2)
        | a when a <= 90 -> (10,0)
        | a when a <= 95 -> (10,2)
        | a when a <= 100 -> (11,0)
        | a when a > 100 -> (11 + (a%10),0)
        | _ -> (0, 0)

    member private this.ThrownDamage weight st =
        let bl = st |> this.CalcBL|> BasicLift.value
        let tDam = this.ThrustDam st
        match weight with
        | a when a <= (bl / 8) -> (fst tDam, snd tDam + ((fst tDam) * -2) )
        | a when a <= (bl / 4) -> (fst tDam, snd tDam + ((fst tDam) * -1) )
        | a when a <= (bl / 2) -> tDam
        | a when a <= bl -> (fst tDam, snd tDam + (fst tDam))
        | a when a <= (2 * bl) -> tDam
        | a when a <= (4 * bl) -> (fst tDam, snd tDam + int(floor(float(fst tDam) * (-0.5))))
        | a when a <= (8 * bl) -> (fst tDam, snd tDam + ((fst tDam) * -1))
        | _ -> (0,0)
        ||> sprintf "For damage, roll %id%+i\n"

    member this.ThrowObject st objWeight=
        let bl =  st |> this.CalcBL |> BasicLift.value
        let fbl = float(bl)
        //let fmbl = fbl * 1.0<CombatActionsTypes.lb>
        let wr = float(objWeight) / fbl

        let distance = match wr with
                        | a when a < 0.05 -> 3.5
                        | a when a < 0.1 -> 2.5
                        | a when a < 0.15 -> 2.0
                        | a when a < 0.2 -> 1.5
                        | a when a < 0.25 -> 1.2
                        | a when a < 0.3 -> 1.1
                        | a when a < 0.4 -> 1.0
                        | a when a < 0.5 -> 0.8
                        | a when a < 0.75 -> 0.7
                        | a when a < 1.0 -> 0.6
                        | a when a < 1.5 -> 0.4
                        | a when a < 2.0 -> 0.3
                        | a when a < 2.5 -> 0.25
                        | a when a < 3.0 -> 0.2
                        | a when a < 4.0 -> 0.15
                        | a when a < 5.0 -> 0.12
                        | a when a < 6.0 -> 0.1
                        | a when a < 7.0 -> 0.09
                        | a when a < 8.0 -> 0.08
                        | a when a < 9.0 -> 0.07
                        | a when a < 10.0 -> 0.06
                        | _ -> 0.05
                        |> (*) (st |> Strength.value |> float)

        (this.ThrownDamage objWeight st)
        |> (+) (sprintf "This object can be thrown %.3f yards.\n" distance)

    /// <summary>
    /// Calculates the additive penalty to dodge due to high weight
    /// </summary>
    /// <param name="st"></param>
    /// <param name="weight"></param>
    member this.CalcDodgeWeightPenalty st weight =
        let bl = st |> this.CalcBL |> BasicLift.value
        //Set up active pattern to match on range

        match weight with
            | a when a >= (10 * bl) -> -4
            | a when a >= (6 * bl) -> -3
            | a when a >= (3 * bl) -> -2
            | a when a >= (2 * bl) -> -1
            | _ -> 0