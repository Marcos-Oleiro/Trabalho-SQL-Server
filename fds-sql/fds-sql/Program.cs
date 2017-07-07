using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using fds_sql;

namespace sql_trab
{
    class Program
    {
        static void Main(string[] args)
        {

            fdsEntities db = new fdsEntities();
            int op = 0;

            while (op != 5)
            {


                Console.WriteLine("Sistema de Gerenciamento de Funcionários\n" +
                    "1 - Menu Funcionários\n" +
                    "2 - Menu Filial\n" +
                    "3 - Menu Setor\n" +
                    "4 - Menu Cargo\n" +
                    "5 - Sair\n" +
                    "Escolhe uma opção: ");


                op = Int32.Parse(Console.ReadLine());
                int opc = 0;
                //Console.WriteLine(op);
                Console.WriteLine("------------------------------------------------");
                switch (op)
                {
                    case 1: // funcionarios
                       
                        while (opc != 5)
                        {


                            Console.WriteLine(
                                "1 - Listar Funcionários\n" +
                                "2 - Adicionar Funcionário\n" +
                                "3 - Excluir Funcionário\n" +
                                "4 - Editar Funcionário\n" +
                                "5 - Sair");
                            Console.WriteLine("------------------------------------------------");
                            opc = Int32.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    opc = 0;
                                    List<empregado> a = db.empregado.ToList();
                                    for (int i = 0; i < a.Count; i++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("ID = " + a[i].id);
                                        Console.WriteLine("Nome = " + a[i].nome);
                                        Console.WriteLine("Setor = " + a[i].id_setor);
                                        Console.WriteLine("Filial= " + a[i].id_filial);
                                        Console.WriteLine("Cargo= " + a[i].id_cargo);
                                        Console.WriteLine("---------------");
                                    }
                                    break;
                                case 2:
                                    opc = 0;
                                    empregado e1 = new empregado();

                                    Console.WriteLine("Digite o nome: ");
                                    e1.nome = Console.ReadLine();

                                    Console.WriteLine("Qual id do setor: ");
                                    e1.id_setor = Int32.Parse(Console.ReadLine());

                                    Console.WriteLine("Qual id do filial: ");
                                    e1.id_filial = Int32.Parse(Console.ReadLine());

                                    Console.WriteLine("Qual id do cargo: ");
                                    e1.id_cargo = Int32.Parse(Console.ReadLine());

                                    db.empregado.Add(e1);
                                    db.SaveChanges();
                                    Console.WriteLine("Adicionado!");
                                    break;
                                case 3:
                                    List<empregado> b = db.empregado.ToList();
                                    for (int i = 0; i < b.Count; i++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("ID = " + b[i].id);
                                        Console.WriteLine("Nome = " + b[i].nome);
                                        Console.WriteLine("Setor = " + b[i].id_setor);
                                        Console.WriteLine("Filial= " + b[i].id_filial);
                                        Console.WriteLine("Cargo= " + b[i].id_cargo);
                                        Console.WriteLine("---------------");
                                    }

                                    Console.WriteLine("Informe a id do funcionário a ser deletado: ");
                                    int id = Int32.Parse(Console.ReadLine());
                                    var f = db.empregado.Where(x => x.id == id);
                                    var func = f.FirstOrDefault<empregado>();
                                    db.empregado.Remove(func);
                                    db.SaveChanges();

                                    opc = 0;
                                    break;
                                case 4:
                                    List<empregado> c = db.empregado.ToList();
                                    for (int i = 0; i < c.Count; i++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("ID = " + c[i].id);
                                        Console.WriteLine("Nome = " + c[i].nome);
                                        Console.WriteLine("Setor = " + c[i].id_setor);
                                        Console.WriteLine("Filial= " + c[i].id_filial);
                                        Console.WriteLine("Cargo= " + c[i].id_cargo);
                                        Console.WriteLine("---------------");
                                    }
                                    Console.WriteLine("Informe a id do funcionário a ser editado: ");
                                    int id_edit = Int32.Parse(Console.ReadLine());
                                    int campo_edit = 0;
                                    var l = db.empregado.Where(x => x.id == id_edit);
                                    var lf = l.FirstOrDefault<empregado>();
                                    while (campo_edit != 5)
                                    {
                                        Console.WriteLine("" +
                                            "1 - Editar o nome\n" +
                                            "2 - Editar o setor\n" +
                                            "3 - Editar o cargo\n" +
                                            "4 - Editar a filial\n" +
                                            "5 - Sair\n");
                                        campo_edit = Int32.Parse(Console.ReadLine());
                                        switch (campo_edit)
                                        {
                                            case 1:
                                                Console.WriteLine("Informe o novo nome");
                                                lf.nome = Console.ReadLine();
                                                db.SaveChanges();
                                                break;
                                            case 2:
                                                Console.WriteLine("Informe a id do novo setor");
                                                lf.id_setor = Int32.Parse(Console.ReadLine());
                                                db.SaveChanges();
                                                break;
                                            case 3:
                                                Console.WriteLine("Informe a id do novo cargo");
                                                lf.id_cargo= Int32.Parse(Console.ReadLine());
                                                db.SaveChanges();
                                                break;
                                            case 4:
                                                Console.WriteLine("Informe a id da nova filial");
                                                lf.id_filial = Int32.Parse(Console.ReadLine());
                                                db.SaveChanges();
                                                break;
                                        }

                                    }



                                    opc = 0;
                                    break;
                            }
                        }
                        break;
                    case 2: // filiais
                        while (opc != 5)
                        {


                            Console.WriteLine(
                                "1 - Listar Filiais\n" +
                                "2 - Adicionar Filial\n" +
                                "3 - Excluir Filial\n" +
                                "4 - Editar Filial\n" +
                                "5 - Sair");
                            opc = Int32.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    opc = 0;
                                    List<filial> f = db.filial.ToList();
                                    for (int x = 0; x < f.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + f[x].id);
                                        Console.WriteLine("Nome: " + f[x].nome);
                                        Console.WriteLine("---------------");
                                    }
                                    break;
                                case 2:
                                    opc = 0;
                                    filial fl = new filial();

                                    Console.WriteLine("Nome da Filial");
                                    fl.nome = Console.ReadLine();

                                    db.filial.Add(fl);
                                    db.SaveChanges();

                                    break;
                                case 3:
                                    List<filial> p = db.filial.ToList();
                                    for (int x = 0; x < p.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + p[x].id);
                                        Console.WriteLine("Nome: " + p[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id da filial a ser deletada: ");
                                    int id = Int32.Parse(Console.ReadLine());
                                    var l = db.filial.Where(x => x.id == id);
                                    var lf = l.FirstOrDefault<filial>();
                                    db.filial.Remove(lf);
                                    db.SaveChanges();

                                    opc = 0;
                                    break;
                                case 4:
                                    List<filial> q = db.filial.ToList();
                                    for (int x = 0; x < q.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + q[x].id);
                                        Console.WriteLine("Nome: " + q[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id da filial a ser editada: ");
                                    int ident = Int32.Parse(Console.ReadLine());
                                    var e = db.filial.Where(x => x.id == ident);
                                    var r = e.FirstOrDefault<filial>();
                                    Console.WriteLine("Digite o novo nome da filial: ");
                                    r.nome = Console.ReadLine();
                                    db.SaveChanges();
                                    opc = 0;
                                    break;
                            }
                        }
                        break;
                    case 3: // setores
                        while (opc != 5)
                        {


                            Console.WriteLine(
                                "1 - Listar Setores\n" +
                                "2 - Adicionar Setor\n" +
                                "3 - Excluir Setor\n" +
                                "4 - Editar Setor\n" +
                                "5 - Sair");
                            opc = Int32.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    opc = 0;
                                    List<setor> s = db.setor.ToList();
                                    for (int x = 0; x < s.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + s[x].id);
                                        Console.WriteLine("Nome: " + s[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    break;
                                case 2:
                                    opc = 0;
                                    setor st = new setor();

                                    Console.WriteLine("Nome da Setor");
                                    st.nome = Console.ReadLine();

                                    db.setor.Add(st);
                                    db.SaveChanges();

                                    break;
                                case 3:
                                    List<setor> p = db.setor.ToList();
                                    for (int x = 0; x < p.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + p[x].id);
                                        Console.WriteLine("Nome: " + p[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id do setor a ser deletado: ");
                                    int id = Int32.Parse(Console.ReadLine());
                                    var l = db.setor.Where(x => x.id == id);
                                    var lf = l.FirstOrDefault<setor>();
                                    db.setor.Remove(lf);
                                    db.SaveChanges();
                                    opc = 0;
                                    break;
                                case 4:
                                    List<setor> q = db.setor.ToList();
                                    for (int x = 0; x < q.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + q[x].id);
                                        Console.WriteLine("Nome: " + q[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id da setor a ser editado: ");
                                    int ident = Int32.Parse(Console.ReadLine());
                                    var e = db.setor.Where(x => x.id == ident);
                                    var r = e.FirstOrDefault<setor>();
                                    Console.WriteLine("Digite o novo nome do setor: ");
                                    r.nome = Console.ReadLine();
                                    db.SaveChanges();
                                    opc = 0;
                                    break;
                            }
                        }
                        break;
                    case 4: // cargos
                        while (opc != 5)
                        {
                            Console.WriteLine(
                                "1 - Listar Cargos\n" +
                                "2 - Adicionar Cargo\n" +
                                "3 - Excluir Cargo\n" +
                                "4 - Editar Cargo\n" +
                                "5 - Sair");
                            opc = Int32.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    opc = 0;
                                    List<cargo> c = db.cargo.ToList();
                                    for (int x = 0; x < c.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + c[x].id);
                                        Console.WriteLine("Nome: " + c[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    break;
                                case 2:
                                    opc = 0;
                                    cargo cg = new cargo();

                                    Console.WriteLine("Nome da Cargo");
                                    cg.nome = Console.ReadLine();

                                    db.cargo.Add(cg);
                                    db.SaveChanges();

                                    break;
                                case 3:
                                    List<cargo> p = db.cargo.ToList();
                                    for (int x = 0; x < p.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + p[x].id);
                                        Console.WriteLine("Nome: " + p[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id do cargo a ser deletado: ");
                                    int id = Int32.Parse(Console.ReadLine());
                                    var l = db.cargo.Where(x => x.id == id);
                                    var lf = l.FirstOrDefault<cargo>();
                                    db.cargo.Remove(lf);
                                    db.SaveChanges();
                                    opc = 0;
                                    break;
                                case 4:
                                    List<cargo> q = db.cargo.ToList();
                                    for (int x = 0; x < q.Count(); x++)
                                    {
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id: " + q[x].id);
                                        Console.WriteLine("Nome: " + q[x].nome);
                                        Console.WriteLine("---------------");

                                    }
                                    Console.WriteLine("Informe a id do cargo a ser editado: ");
                                    int ident = Int32.Parse(Console.ReadLine());
                                    var e = db.cargo.Where(x => x.id == ident);
                                    var r = e.FirstOrDefault<cargo>();
                                    Console.WriteLine("Digite o novo nome do cargo: ");
                                    r.nome = Console.ReadLine();
                                    db.SaveChanges();
                                    opc = 0;
                                    break;
                            }
                        }
                        break;
                }
            }

        }
    }
}
