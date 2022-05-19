La comatibilité de Windows Form vis à vis de Linux est très mauvaise.
Installer `Mono` et `Wine` ne seront pas suffisant pour pouvoir faire fonctionner l'application.

Si vous utiliser le système d'exploitation `Linux` le meilleur moyen de pouvoir développer 
avec le framework Windows Form est d'utiliser une machine virtuelle windows avec KVM QEMU.


Lancement d'une vm avec partage de fichier sous Arch Linux:

```
paru -S samba
qemu-system-x86_64 -net nic -net user,smb=[path/to/shared/dir] -smp [number of cores] -cpu host -enable-kvm -m [memory size] -drive format=qcow2,file=[path/to/vm/volume/disk/.qcow2]
\\10.0.2.4\qemu
```