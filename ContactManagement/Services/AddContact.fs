
namespace ContactManagement.Services

open ContactManagement.Models

module AddContact =

    let addContact
        (contacts: Map<int, Contact>)
        (name: string)
        (phone: string)
        (email: string) =

        // Create a new contact with the next available ID
        let nextId =
            if Map.isEmpty contacts then
                1
            else
                (contacts |> Map.toList |> List.map fst |> List.max) + 1

        let newContact =
            {
                Id = nextId
                Name = name.Trim()
                Phone = phone.Trim()
                Email = email.Trim()
            }

        // Validate the new contact
        if Validation.validateContact newContact then
            Ok (Map.add nextId newContact contacts)
        else
            Error ["Invalid contact data. Please check Name, Phone and Email."]
