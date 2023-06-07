﻿//Valores globales
var title = { W: "Advertencia", E: "Algo salió mal", S: "Información almacenada correctamente", I: "Importante" }
var icon = { W: "warning", E: "error", S: "success", I: "info" };

//Listado de pacientes
var text = {
    Servidor: "Ocurrio un error al conectar con el servidor",
    SesionError: "Esté usuario no tiene perfil médico",
    MedicoError: "Error al recuperar el médico",
    EspecialidadError: "Error al recuperar la especialidad del médico", 
    Fecha: "La fecha inicial no puede ser mayor a la fecha final",
    Campos: "Completa todos los campos para poder continuar",
    LP_Medico: "Debes seleccionar un médico para poder obtener los datos de las citas",
    FechasVacias: "La fecha inicial o la fecha final no pueden ir vacias",
    SinPerfil:"El usuario seleccionado no tiene un perfil médico",
    //Diagnostico Secunadario
    DiagnosticoSecEmpty: "No se puede agregar el diagnóstico secundario, completa los campos",
    DiagnosticoSecSucces: "",
    DiagnosticoSecRepeat: "Selecciona un diagnóstico secundario diferente",
    DiagnosticoSecDelete: "",
    DiagnosticoPrincipal: "",
    //NotaMedica
    MSGNotaMedicaUpdate: "",
    MSGNotaMedicaInsert: "", 
    CamposRequeridos: "Completa los campos requeridos para poder continuar",
    OncologiaMSGTMN: "Debes seleccionar Tamaño, Metástasis y Nódulo para poder continuar",
    OncologiaMSGEstado: "La Etapa y el Estatus Actual son requeridos",
    HEMATOLOGIAMSG: "Debe capturar la Etapa, el Grado y el Estatus Actual",
    RemoverDS: "¿Deseas remover este diagnóstico secundario?",
    FinConsulta: "¿Deseas finalizar la consulta?",
    DiagnosticoVacio: "Por favor selecciona el Diagnóstico Principal que desea enviar",
    ValoresFueraRango: "Valores no permitidos en Signos Vitales y Somatometría",
    //Mensajes de la seccion Obstetrica
    InsercionObstetrica: "",
    NoExisteNotaMedica: "No existe ninguna nota médica relacionada",
    ValidarCampos: "Validar los campos inconsistentes",
    //HojaFrontal
    SeleccionarDiagnostico: "Seleccione un diagnóstico",
}

var icoComentarios = 'data:image/png;base64,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Vu27uwsysajBbk5tsCYArFD7Cndhm+BONFgTAFaoXaL7M1H/GdzEVwUBMF4aXeEKLgDj5X7BBYDBW9jmljIAjJf7M7G4wbKucAEYL0u8YBgABq8ILgAMnitcAKhAcAGgAreUAaACwQWACtxSBoAKXOECQAWucAGgAsEFgArcUgaAClzhAkAFggsAVQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUMHU1gNQ263l8tyZe3N360FgjG2WmdkiszOr13oS6hHcMbG4nJez8r1ckK1bjwIsN6vsm0NyaPbPFOntPMEdA1eUU7Jzrms9BvAwt+XMnJlkp7yrvDyPF91O8xxux11cji9z8j65haF2bd6b2XluOb+0noTBEdwOu6kcV/bJ57O49SDAWliS0/OkvKzcLLodJbid9ekyJ6fGmQujpORzmZOTnbidJLidNK8cW16Tu1qPAayHO/PqvLTME93O8aKpDrq2HJBftB4CmIQv5MJcV3b0IqpOcYXbOb8oB8stjLxLc0AudpXbKYLbMXPLM3Nt6yGAPrgxh+Vyye0Qwe2UG8oRuaX1EECf3JIjcqPkdobncDtkQTk417QeAuijq3NMFpYZnsvtBFe4HfL2nN96BKDPfpI/az0CfSK4nfGN8vHWIwADcGK+5bZyJ7il3BHzy56tRwAGouSNubfMdFt55LnC7Yj35urWIwAD8uv8besR6ANXuJ1wW9m59QjAAH0ot5atXeOOOFe4nfDh3Nt6BGCAfpuPtR6BSXOF2wH3lUe3HgEYsJOyoGzgGnekucLtgNNyR+sRgAG7I6e3HoFJEtwO+FzrAYAKnOmjzi3lkXdf2bL1CEAFZ7qpPOJc4Y68c3Jf6xGACubn3NYjMCmCO/K+33oAoJKzWw/ApAjuyLu09QBAJb7perQJ7si7rPUAQCXO9tEmuCPvmtYDAJVc1XoAJsWrlEfcojKt9QhAJfPzQJnqdcojyxXuiJvXegCgmuKMH2mCO+IWtR4AqMgZP8oEd8Rt0noAoCJn/CgT3BG3Uc/T8DAupmVDz+COMMEdeY9qPQBQibN9tAnuyJvTegCgkt1bD8CkCO7IE1wYF7NbD8CkCO7IO6D1AEAlB7YegEkR3JF3aLyKAsZBL4e0HoFJEdyRt31vj9YjABXsle387XqkCW4HvKT1AEAFx7YegEkS3A54Raa0HgEYsAnBHXmC2wE79I5sPQIwYEdlJzeUR5zgdsK7Wg8ADJizfPQJbicc2Du89QjAAD07B7i+HXmC2xEfju/Fha6ang+2HoE+ENyOeELvra1HAAbk7dnT9W0HCG5nvCd7th4BGIC98letR6AvBLczNu591XdlQufMzJezkevbThDcDpndO9kfKHTKRE7JHnLbEX4+d8qLeie1HgHoow/lBXLbGYLbMSf0/qb1CEBf9PL+vFVuO0RwO+cvep/J1NZDAJM0JZ/Mn8ttpwhuB72yd1q2aj0EMAmzcnpeL7cdI7id9JzeBTmo9RDAejo4F+RIue0cwe2onXo/yGdd58LI2TwfydnZUW47SHA7a0rv5b1L8uZs2HoQYC1tmLfksry1N1VuO0lwO2273sd6V+Ud2a71IMAabJ935qqc2HuU2HaWl7N23na95IFyRr6as3J162GAh3lsDsvzc3im9j7QehQGSnDHwoM3qK4sF2Zu5ubOzMs9rYeCMbZZZmaLzM7s7Jddep/Kp1oPRAWCO1Z2dbMKoBHP4QJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFUxtPQC13Vouz525N3e3HgTG2GaZmS0yO7N6rSehHsEdE4vLeTkr38sF2br1KMBys8q+OSSHZv9Mkd7OE9wxcEU5JTvnutZjAA9zW87MmUl2yrvKy/N40e00z+F23MXl+DIn75NbGGrX5r2ZneeW80vrSRgcwe2wm8pxZZ98PotbDwKshSU5PU/Ky8rNottRgttZny5zcmqcuTBKSj6XOTnZidtJgttJ88qx5TW5q/UYwHq4M6/OS8s80e0cL5rqoGvLAflF6yGASfhCLsx1ZUcvouoUV7id84tysNzCyLs0B+RiV7mdIrgdM7c8M9e2HgLogxtzWC6X3A4R3E65oRyRW1oPAfTJLTkiN0puZ3gOt0MWlINzTeshgD66OsdkYZnhudxOcIXbIW/P+a1HAPrsJ/mz1iPQJ4LbGd8oH289AjAAJ+Zbbit3glvKHTG/7Nl6BGAgSt6Ye8tMt5VHnivcjnhvrm49AjAgv87fth6BPnCF2wm3lZ1bjwAM0Idya9naNe6Ic4XbCR/Ova1HAAbot/lY6xGYNFe4HXBfeXTrEYABOykLygaucUeaK9wOOC13tB4BGLA7cnrrEZgkwe2Az7UeAKjAmT7q3FIeefeVLVuPAFRwppvKI84V7sg7J/e1HgGoYH7ObT0CkyK4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uL4deYLbER+O78WFrpqeD7YegT4Q3I54Qu+trUcABuTt2dP1bQcIbme8J3u2HgEYgL3yV61HoC8EtzM27n3Vd2VC58zMl7OR69tOENwOmd072R8odMpETskectsRfj53yot6J7UeAeijD+UFctsZgtsxJ/T+pvUIQF/08v68VW47RHA75y96n8nU1kMAkzQln8yfy22nCG4HvbJ3WrZqPQQwCbNyel4vtx0juJ30nN4FOaj1EMB6OjgX5Ei57RzB7aidej/IZ13nwsjZPB/J2dlRbjtIcDtrSu/lvUvy5mzYehBgLW2Yt+SyvLU3VW47SXA7bbvex3pX5R3ZrvUgwBpsn3fmqpzYe5TYdpaXs3bedr3kgXJGvpqzcnXrYYCHeWwOy/NzeKb2PtB6FAZKcMfCgzeoriwXZm7m5s7Myz2th4IxtllmZovMzuzsl116n8qnWg9EBYI7VnZ1swqgEc/hAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJABYILABUILgBUILgAUIHgAkAFggsAFQguAFQguABQgeACQAWCCwAVCC4AVCC4AFCB4AJA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';
