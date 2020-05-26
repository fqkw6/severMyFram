call python xls_deploy_tool.py PERSON xls/person.xls
call protoc tnt_deploy_person.proto --descriptor_set_out=person.protodesc
call ProtoGen\protogen -i:person.protodesc -o:person.cs
pause