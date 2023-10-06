namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Database.ExecuteSqlCommand(@"
                INSERT INTO [Tests] (id,givenname,surname,isActive)
                VALUES
                ('491D52B0-1780-ACF1-2478-240F8A12057A','Elmo','Anthony',0),
                ('C546165E-DCF8-5837-1541-85A1286279AB','Madison','Strong',1),
                ('0AE36F41-4D72-9E43-C70B-AA616C72B29F','Tyrone','Humphrey',0),
                ('8D1F7DC9-DC9B-E8E8-0F4D-CCB0377E5C26','Jana','Garrison',1),
                ('72C78CBC-EAE8-401C-8D2E-BA64CA4D669E','Benjamin','Mullins',1),
                ('1AE68281-BA46-441E-6D92-C7816B213338','Myles','Nichols',1),
                ('3BD168AF-1722-7217-0268-A920C11F65E3','Cain','Robertson',0),
                ('9F459798-EA81-6C6B-EF0B-674ECF993AE6','Rebekah','Jackson',0),
                ('63ED3302-F3CC-8094-66A1-C1357121A821','Barrett','Barton',1),
                ('06A2B014-BD9B-94BD-2662-BE596B2793D6','Calvin','Lynch',0),
                ('978979E4-302C-132E-57B2-34E84AD9093F','Blossom','Maldonado',1),
                ('54FE91DA-2643-8D23-156B-D60CD0491F1A','Austin','Harper',1),
                ('1E567646-BD92-7215-5252-E3BCCBBE1A35','Morgan','Gilbert',0),
                ('283B503C-CB0A-262C-38D0-5953C7721E69','Sonya','Valenzuela',0),
                ('796A7AA4-99DD-A873-B9FA-E62D976BF34B','Audrey','Leach',0),
                ('651B8CA6-368E-6CBD-F1B8-4D32C18BC292','Halla','Hayden',1),
                ('16A5153D-238B-FC1A-92CA-56977E59F465','Orson','Durham',0),
                ('DDE95C48-E31A-6228-85D2-D1CB1E5BDC8C','Mari','Alston',1),
                ('0E645419-DFC7-C63D-5AB6-04797DCB80C8','Scarlett','Heath',0),
                ('64B6442D-E71B-32B7-6EEA-00A886599E4A','Price','Abbott',1),
                ('DD9A844C-D968-9149-F98D-BA20F3FD551A','Chaim','Wright',1),
                ('7689D1BB-91E9-2CC1-EB6B-1866A497232B','Aimee','Manning',1),
                ('4298765B-E718-9E16-CF5B-198AA2315590','Holmes','Klein',0),
                ('AC1567D4-C4AE-B662-3994-595C44651BA9','Leandra','Horne',0),
                ('EA53C6B6-8953-7CD1-8D5C-4BCF57CA2A4C','Carol','York',1),
                ('97769755-4D21-3CAE-24A8-ECC219BE2822','Kelsie','Glover',1),
                ('6C741EF3-6272-6374-CB76-55CE6AE6392D','Salvador','Gomez',1),
                ('3949D5E4-73DE-4894-5C71-A8CFCE243EA9','Sopoline','Frost',1),
                ('7926D25A-E232-A079-5B7C-4B52A8AC34D9','Honorato','Warren',0),
                ('1A943318-9CB1-36D7-6BE0-19131FBE78D3','Kylie','Cote',0),
                ('372DB5C1-6EF5-A541-9BC9-C2418A418413','Grace','Martinez',1),
                ('3351D769-27F4-B112-0CB6-78D149277CC9','Lance','Carter',0),
                ('7424BA9D-323A-4C15-8CEA-DD1AEC4CABE0','Shaine','Jordan',0),
                ('4474E563-13A5-485B-02CC-E795E3713BE3','Grace','Brewer',1),
                ('B7519101-64DD-9C15-AD25-14A70D8A6182','Zeph','Hogan',0),
                ('9D3E071B-EB21-FB6E-B16A-89EBEE2A86F6','Bertha','Mooney',1),
                ('52DA5646-79C4-3222-13CD-4496F8D86DA5','Cameron','Dixon',1),
                ('191CA19F-BC95-4928-783C-A4AA8FA29707','Kimberley','Parks',1),
                ('22277264-48D2-E375-D137-A0A978C69A24','Alexander','Buck',0),
                ('B169BAB1-0FBC-7A88-B772-5C4D7ABAC9A4','Raja','Duncan',0),
                ('CE2EFE2A-D319-6356-8FD8-8CF9DAE32773','Noelle','Macias',1),
                ('A92269A4-94BF-57C2-617F-F5F71DECB5E9','Kaseem','Andrews',1),
                ('1756589B-301B-474A-5A0E-0C1A1782788E','Ryan','Walter',1),
                ('09AAA156-80A3-2197-5861-B594D1BCC4E1','Daquan','Vincent',0),
                ('97A15421-E650-C7B3-53D5-D32663542734','Tobias','Clark',1),
                ('05347A7C-EC81-475E-DC67-57B53920EA86','Pamela','Stephens',1),
                ('A9EA31C7-ED2C-C555-622E-FAD4124A65DC','Oleg','Branch',0),
                ('0E3DC1B1-FD5C-5338-AD79-3588F0DF7A3F','Shelby','Mcintosh',1),
                ('48EAD982-AAE8-7B6A-646E-9EE26FED24EE','Isaac','Aguirre',0),
                ('29404F06-813D-9C4A-867B-9C7E492E89CE','Cynthia','Beard',0),
                ('1C7DCEB8-94B1-38B4-C18E-7661CD257495','Jin','Pace',1),
                ('A8734628-A53A-2765-6B39-49146A10A2C5','Flynn','Norris',1),
                ('AB6FFB8E-7556-F553-279B-A4741371F928','Hunter','Glenn',0),
                ('FEAEA636-CB23-A294-7C7B-62F5B68F766A','Zena','Wiley',0),
                ('DC285799-F1C3-810A-BC8B-71B525414497','Alfreda','Hines',0),
                ('63B464F3-463F-7E6A-328D-CE95E2F5E8D8','Uriel','Dillard',0),
                ('12E68B36-E846-E942-361D-5C5C8E9A1413','Brenda','Franco',1),
                ('B6A76C1E-4572-7EB2-CC98-E108A41B29E9','Hu','Pollard',0),
                ('28EA39B5-C71C-593D-4D76-67EE6A86F6C0','Sage','Hoover',1),
                ('2906B619-BCC2-BA18-89BE-381A2592EE35','Grant','Brock',1),
                ('7D99EFA3-619E-9B54-E34A-71F6B4B93720','Adam','William',0),
                ('F823E27E-5DAD-7424-A561-552E5F2C228E','Micah','Alvarez',1),
                ('996691B2-698D-6BCE-30E6-97233AEADE51','Cassidy','Salinas',0),
                ('A5017936-C1DC-85CA-2E6F-833A2F14ACCC','Kareem','Clarke',1),
                ('FC4C83E6-A221-D6EE-4B95-8D949E1A7226','Hedda','Clay',1),
                ('28D212D8-69AA-DE4D-1272-ACD81848D2A5','Phelan','Beard',1),
                ('FDD842EE-D615-E4D9-AF7F-F53902A30C35','Octavius','Roberts',0),
                ('18EAE21F-3812-D88C-0813-5B319E7C986E','Cassandra','Crawford',1),
                ('354738A8-63EC-9246-42BC-816DA34EA434','Chancellor','Kim',0),
                ('98DB9979-84E6-121B-4258-D8C54525A2A2','Shellie','Jimenez',1),
                ('C5DEE89D-4ED5-E31A-5C39-5DAE298CB808','Leo','Pratt',1),
                ('755965EA-1779-016B-2547-6634161E2879','Kim','Bean',0),
                ('E405E2DD-543C-4CE5-43D3-6BBE25273388','Brielle','Gutierrez',0),
                ('DBC55151-9889-F6AA-BDB4-1546B49C3B2B','Jenette','Decker',0),
                ('A63B1855-9376-59C7-1618-45E54B6E4BB8','Lysandra','Byers',1),
                ('D28CC775-2143-969F-8285-B321CB21B354','Rigel','Dyer',0),
                ('DD0EC59E-4380-1E04-A287-5B3EA2F859BE','Daniel','Rowland',1),
                ('865617FB-1ACA-1BA6-FC15-1AA5DC59E591','Shafira','Sloan',1),
                ('85CCDDB5-D1CD-400B-5352-E7915C615523','Marsden','Martinez',1),
                ('D4C80752-7C8C-5553-9AA0-8C6E59971BEE','Cairo','Larsen',0),
                ('9377B7B2-2276-D045-09B3-F8BB05B6510C','Dieter','Shaffer',0),
                ('44845493-50C6-5CC4-8B88-254B2C9EA74F','Gregory','Olsen',0),
                ('199886BA-71AA-5D63-2E45-203C1D7B4D68','Doris','Perry',1),
                ('13151268-6CB2-6AB5-FA6E-91BB7C337745','Cassandra','Robles',1),
                ('7BC8C12D-BD8B-D7DD-1EF2-2AA5712736C7','Tate','Taylor',1),
                ('2DAC598A-0C71-356F-A399-A0E392428E9C','Hiroko','Wilkins',1),
                ('E282B213-1E7D-6750-36C5-5A365167CFE1','Carlos','O''donnell',1),
                ('449E8182-FB93-BD52-7B33-0E6A3C14D69A','Ross','Mays',0),
                ('F96317C4-C46E-E0A1-5F5D-1A7E28E148D4','Allistair','Morrow',0),
                ('4F708CB5-729E-5E4D-C028-F093A9C237DD','Anika','Pennington',0),
                ('74EF1DE9-62D8-6884-EC88-E6E12097D568','Alexis','Leonard',1),
                ('EAE6E975-E21E-3887-1531-D383E413AF7A','Levi','Booker',1),
                ('4D0F73E7-4969-6C1A-B118-8163180C0E53','Emma','Fields',1),
                ('C0C487D3-10C5-A464-A394-86B65EC9603E','Susan','Sawyer',0),
                ('3626E4C8-D052-60EE-481F-2E9FCC7A4D71','Nayda','Cameron',1),
                ('54BB161B-5E9C-995F-9363-523B4E13BDEE','Charissa','Manning',0),
                ('1AA381E7-545E-E9D3-DE73-25B377D1E833','Reed','Calderon',1),
                ('2DAE6FA8-54B1-79C5-B6E8-ADA7B948D834','Yen','Brewer',1),
                ('60022BCB-1221-68C4-0934-9FEA4F8CCAA3','Ima','Paul',0),
                ('A49D7B99-EA0E-C978-4360-2D7D6622EF70','Sawyer','Mcconnell',1);");
        }
    }
}
