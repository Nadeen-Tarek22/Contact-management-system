namespace ContactManagement.Services

open ContactManagement.Models

module Validation =

    let isValidName (name: string) =
        not (System.String.IsNullOrWhiteSpace(name))

    let isValidPhone (phone: string) =
        not (System.String.IsNullOrWhiteSpace(phone))

    let isValidEmail (email: string) =
        not (System.String.IsNullOrWhiteSpace(email))
        && email.Contains("@")

    let validateContact (contact: Contact) =
        isValidName contact.Name
        && isValidPhone contact.Phone
        && isValidEmail contact.Email