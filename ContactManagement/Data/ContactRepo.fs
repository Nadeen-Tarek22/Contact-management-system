namespace ContactManagement.Data

open ContactManagement.Models

module ContactRepository =

    let contacts =
        Map.ofList
            [
                (1, { Id = 1; Name = "Nadeen"; Phone = "01012345678"; Email = "nadeen229@gmail.com" })
                (2, { Id = 2; Name = "Habiba"; Phone = "01198765432"; Email = "Habiba7@gmail.com" })
                (3, { Id = 3; Name = "Nada"; Phone = "01234567890"; Email = "Nada2@gmail.com" })
                (4, { Id = 3; Name = "Hend"; Phone = "01234567965"; Email = "hend2@gmail.com" })
                (5, { Id = 3; Name = "Rawan"; Phone = "01200756912"; Email = "rawan42@gmail.com" })

            ]